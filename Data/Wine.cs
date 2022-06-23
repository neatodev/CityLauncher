using NLog;
using System.Runtime.InteropServices;

namespace CityLauncher
{
    static internal class Wine
    {
        private static readonly Logger Nlog = LogManager.GetCurrentClassLogger();

        public static bool Exists()
        {
            try
            {
                Nlog.Info("IsWine - Wine detected. Version: {0}", GetWineVersion());
                return true;
            }
            catch (EntryPointNotFoundException e)
            {
                Nlog.Warn(
                    "Wine.Exists() - Wine not found. (Windows Users can ignore this.).\r\nEntryPointNotFoundException: {0}",
                    e);
                return false;
            }
        }

        [DllImport("ntdll.dll", EntryPoint = "wine_get_version", CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Ansi)]
        private static extern string GetWineVersion();
    }
}

