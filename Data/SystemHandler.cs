using Microsoft.Win32;
using NLog;
using System.Management;

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
            Nlog.Info("Constructor - Sucessfully initialized SystemHandler.");
            CPUData = InitializeCPU();
            GPUData = InitializeGPUValues();
        }

        private string InitializeCPU()
        {
            var CPU = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First();
            uint Clockspeed = (uint)CPU["MaxClockSpeed"];
            double GHzSpeed = (double)Clockspeed / 1000;
            Nlog.Info("InitializeCPU - Recognized CPU as {0} with a base clock speed of {1}GHz.", CPU["Name"].ToString().Trim(' '), Math.Round(GHzSpeed, 1));
            return CPU["Name"].ToString().Trim(' ') + " @ " + Math.Round(GHzSpeed, 1) + "GHz";
        }

        private string InitializeGPUValues()
        {
            RegDirectory = Path.Combine(Registry.LocalMachine.ToString(), "SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000");

            Nlog.Info("InitializeGPUValues - Recognized GPU as {0} with a total VRAM amount of {1}.", (string)Registry.GetValue(RegDirectory, "DriverDesc", "Could not find GPU name."), ConvertVRamValue((Int64)Registry.GetValue(RegDirectory, "HardwareInformation.qwMemorySize", 0)));

            return (string)Registry.GetValue(RegDirectory, "DriverDesc", "Not found") + " (" + ConvertVRamValue((Int64)Registry.GetValue(RegDirectory, "HardwareInformation.qwMemorySize", 0)) + ")";
        }

        ///<Returns VRAM value in GB in most cases.</Returns>.</summary>
        private string ConvertVRamValue(Int64 VRam)
        {
            var Affix = "MB";
            if (VRam >= 1073741824)
            {
                VRam = VRam / 1024;
                Affix = "GB";
            }
            VRam = VRam / 1048576;
            return VRam.ToString() + Affix;
        }
    }
}
