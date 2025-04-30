using Microsoft.Win32;
using NLog;
using System.Globalization;
using System.Management;
using System.Text.RegularExpressions;

namespace CityLauncher
{
    internal class SystemHandler
    {
        public string GPUData = "";
        public string CPUData = "";
        private static readonly Regex AmdDiscreteRegex = new Regex(@"\b(?:AMD\s*\(?.*?\)?\s*)?Radeon(?:\s*\(?.*?\)?\s*)?(?:[^\w\r\n]*(?:RX|Pro|R\d|HD|Vega)?\s*\d{2,5}\s*(?:M|XT|XTX|VII)?)?\b", RegexOptions.IgnoreCase);
        private static readonly Regex IntelArcRegex = new Regex(@"\b(?:Intel\s*\(?.*?\)?\s*)?Arc\s*[^\w\r\n]*([A-Z])\s*(\d{3,5})(M)?\b", RegexOptions.IgnoreCase);

        private static Logger Nlog = LogManager.GetCurrentClassLogger();

        public SystemHandler()
        {
            Nlog.Info("Constructor - Successfully initialized SystemHandler.");
            CPUData = InitializeCPU().ToUpper();
            GPUData = InitializeGPUValues().ToUpper();
        }

        private string InitializeCPU()
        {
            try
            {
                var CPU = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First();
                uint Clockspeed = (uint)CPU["MaxClockSpeed"];
                double GHzSpeed = (double)Clockspeed / 1000;
                Nlog.Info("InitializeCPU - Recognized CPU as {0} with a base clock speed of {1}GHz.", CPU["Name"].ToString().Trim(' '), Math.Round(GHzSpeed, 1));
                var CPUName = CPU["Name"].ToString().Trim(' ');
                if (CPUName.ToUpper().Contains("GHZ"))
                {
                    return CPUName;
                }
                else
                {
                    return CPUName + " @ " + Math.Round(GHzSpeed, 1) + "GHz";
                }
            }
            catch (Exception e)
            {
                Nlog.Error("InitializeCPU - Could not read CPU information. Error: {0}", e);
                Program.MainWindow.BasicToolTip.SetToolTip(Program.MainWindow.CPULabel, "Current date.");
                return DateTime.Now.ToString("dddd, MMMM dd, yyyy", new CultureInfo("en-GB"));
            }
        }

        private string InitializeGPUValues()
        {
            try
            {
                string basePath = @"SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}";
                RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(basePath);
                if (baseKey == null)
                {
                    Nlog.Error("InitializeGPUValues - Registry base path not found.");
                    return SetGPUNameVideoController();
                }

                string GPUName = null;
                object VRAM = null;
                int priority = 4; // Lower = better

                foreach (string subKeyName in baseKey.GetSubKeyNames())
                {
                    if (!Regex.IsMatch(subKeyName, @"^\d{4}$")) continue;

                    string regPath = $@"{basePath}\{subKeyName}";
                    using RegistryKey subKey = Registry.LocalMachine.OpenSubKey(regPath);
                    if (subKey == null) continue;

                    string driverDesc = subKey.GetValue("DriverDesc") as string;
                    object vramValue = subKey.GetValue("HardwareInformation.qwMemorySize");

                    if (string.IsNullOrWhiteSpace(driverDesc)) continue;

                    string upper = driverDesc.ToUpper();

                    // Priority 1: NVIDIA
                    if (upper.Contains("NVIDIA") || upper.Contains("RTX") || upper.Contains("GTX"))
                    {
                        GPUName = driverDesc;
                        VRAM = vramValue;
                        break; // top priority, break early
                    }

                    // Priority 2: Intel Arc
                    if (IntelArcRegex.IsMatch(driverDesc))
                    {
                        if (priority > 2)
                        {
                            GPUName = driverDesc;
                            VRAM = vramValue;
                            priority = 2;
                        }
                        continue;
                    }

                    // Priority 3: AMD Discrete (RX line)
                    if (AmdDiscreteRegex.IsMatch(driverDesc))
                    {
                        if (priority > 3)
                        {
                            GPUName = driverDesc;
                            VRAM = vramValue;
                            priority = 3;
                        }
                    }
                }

                if (string.IsNullOrEmpty(GPUName))
                {
                    return SetGPUNameVideoController();
                }
                string VRamStr = ConvertVRamValue(VRAM);
                Nlog.Info("InitializeGPUValues - Recognized GPU as {0} with a total VRAM amount of {1}.", GPUName, VRamStr);
                return GPUName + " (" + VRamStr + ")";
            }
            catch (Exception e)
            {
                Nlog.Error("InitializeGPUValues - Could not read Graphics Card information. Error: {0}", e);
                Program.MainWindow.BasicToolTip.SetToolTip(Program.MainWindow.GPULabel, "Something went wrong! This is where your GPU should be.");
                return SetGPUNameVideoController();
            }
        }


        private string SetGPUNameVideoController()
        {
            try
            {
                List<string> GPUList = new();
                ManagementObjectSearcher search = new("SELECT * FROM Win32_VideoController");
                foreach (ManagementBaseObject o in search.Get())
                {
                    ManagementObject obj = (ManagementObject)o;
                    foreach (PropertyData data in obj.Properties)
                    {
                        if (data.Name == "Description")
                        {
                            GPUList.Add(data.Value.ToString());
                        }
                    }
                }
                var GPU = GPUList[0];

                // Priority scores: higher is better
                int priority = 4;

                foreach (string s in GPUList)
                {
                    string upper = s.ToUpper();

                    // Priority 1: NVIDIA
                    if (upper.Contains("NVIDIA") || upper.Contains("RTX") || upper.Contains("GTX"))
                    {
                        GPU = s;
                        priority = 1;

                        // No need to keep scanning—NVIDIA is top priority
                        break;
                    }

                    // Priority 2: Intel Arc
                    else if (IntelArcRegex.IsMatch(s) && priority > 2)
                    {
                        GPU = s;
                        priority = 2;
                    }

                    // Priority 3: AMD Radeon (discrete only)
                    else if (AmdDiscreteRegex.IsMatch(s) && priority > 3)
                    {
                        GPU = s;
                        priority = 3;
                    }
                }
                Nlog.Warn("SetGPUNameVideoController - Used fallback method to determine GPU as {0}. Could not correctly determine VRAM amount. Your GPU drivers may be corrupted.", GPU);
                return GPU;
            }
            catch (Exception e)
            {
                Nlog.Error("SetGPUNameVideoController - Couldn't locate GPU with fallback method.");
                Program.MainWindow.BasicToolTip.SetToolTip(Program.MainWindow.GPULabel, "Something went wrong! This is where your GPU should be.");
                return "GPU not found!";
            }
        }

        ///<Returns VRAM value in GB in most cases.</Returns>.</summary>
        private string ConvertVRamValue(object VRam)
        {
            try
            {
                Int64 VRamValue = (Int64)VRam;

                var Affix = "MB";
                if (VRamValue >= 1073741824)
                {
                    VRamValue /= 1024;
                    Affix = "GB";
                }
                VRamValue /= 1048576;
                return VRamValue.ToString() + Affix;
            }
            catch (InvalidCastException)
            {
                return "";
            }
            catch (NullReferenceException)
            {
                return "";
            }
        }
    }
}