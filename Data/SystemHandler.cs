using Microsoft.Win32;
using NLog;
using System.Globalization;
using System.Management;
using System.Reflection;

namespace CityLauncher
{
    internal class SystemHandler
    {
        private string RegDirectory;
        public string GPUData = "";
        public string CPUData = "";

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
            } catch (Exception e)
            {
                Nlog.Error("InitializeCPU - Could not read CPU information. Error: {0}", e);
                return DateTime.Now.ToString("dddd, MMMM dd, yyyy", new CultureInfo("en-GB"));
            }
        }

        private string InitializeGPUValues()
        {
            try
            {
                RegDirectory = Path.Combine(Registry.LocalMachine.ToString(), "SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000");
                var key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000");

                if (key == null)
                {
                    RegDirectory = Path.Combine(Registry.LocalMachine.ToString(), "SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0001");
                }

                var VRam = ConvertVRamValue((object)Registry.GetValue(RegDirectory, "HardwareInformation.qwMemorySize", 0));
                if (VRam.Trim() == "")
                {
                    return SetGPUNameVideoController();
                }
                Nlog.Info("InitializeGPUValues - Recognized GPU as {0} with a total VRAM amount of {1}.", (string)Registry.GetValue(RegDirectory, "DriverDesc", "Could not find GPU name."), ConvertVRamValue((object)Registry.GetValue(RegDirectory, "HardwareInformation.qwMemorySize", 0)));
                return (string)Registry.GetValue(RegDirectory, "DriverDesc", "GPU not found.") + " " + ConvertVRamValue((object)Registry.GetValue(RegDirectory, "HardwareInformation.qwMemorySize", 0));
            } catch (Exception e)
            {
                Nlog.Error("InitializeGPUValues - Could not read Graphics Card information. Error: {0}", e);
                return "Application Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }

        }

        private string SetGPUNameVideoController()
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
            if (GPUList.Count > 1)
            {
                foreach (string s in GPUList)
                {
                    if (!s.Contains("NVIDIA") || !s.Contains("AMD"))
                    {
                        continue;
                    }
                    GPU = s;
                    break;
                }
            }
            Nlog.Warn("SetGPUNameVideoController - Used fallback method to determine GPU as {0}. Could not correctly determine VRAM amount. Your GPU drivers may be corrupted.", GPU);
            return GPU;
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
                return "(" + VRamValue.ToString() + Affix + ")";
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
