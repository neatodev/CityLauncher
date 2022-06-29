using NLog;
using NLog.Config;
using NLog.Targets;

namespace CityLauncher
{
    internal static class Program
    {

        private static readonly Logger Nlog = LogManager.GetCurrentClassLogger();

        private static readonly string CurrentTime = DateTime.Now.ToString("dd-MM-yy__hh-mm-ss");

        public static CityLauncher MainWindow;

        public static IniHandler IniHandler;

        public static FileHandler FileHandler;

        public static InputHandler InputHandler;

        /// <summary>
        ///     Replacement Application for the original Batman: Arkham Asylum BmLauncher
        ///     Offers more configuration options, enables compatibility with High-Res Texture Packs
        ///     and automatically takes care of the ReadOnly properties of each file, removing
        ///     any requirement to manually edit .ini files. Guarantees a much more comfortable user experience.
        ///     @author Neato (https://steamcommunity.com/id/frofoo)
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetupLogger();
            InitializeProgram();
            Application.Run(MainWindow);
        }

        private static void InitializeProgram()
        {
            ApplicationConfiguration.Initialize();
            MainWindow = new CityLauncher();
            FileHandler = new FileHandler();
            IniHandler = new IniHandler();
            InputHandler = new InputHandler();
            new IniReader().InitDisplay();
        }

        private static void SetupLogger()
        {
            LoggingConfiguration config = new LoggingConfiguration();
            ConsoleTarget Logconsole = new ConsoleTarget("logconsole");
            if (!Directory.Exists("logs"))
            {
                Directory.CreateDirectory("logs");
            }

            FileTarget Logfile = new FileTarget("logfile")
            {
                FileName = Directory.GetCurrentDirectory() + "\\logs\\citylauncher_report__" + CurrentTime + ".log"
            };
            DirectoryInfo LogDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\logs");
            DateTime OldestAllowedArchive = DateTime.Now - new TimeSpan(3, 0, 0, 0);
            foreach (FileInfo file in LogDirectory.GetFiles())
            {
                if (file.CreationTime < OldestAllowedArchive)
                {
                    file.Delete();
                }
            }

            config.AddRule(LogLevel.Debug, LogLevel.Warn, Logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Warn, Logfile);
            LogManager.Configuration = config;
        }
    }
}