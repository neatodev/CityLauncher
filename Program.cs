using NLog;
using NLog.Config;
using NLog.Targets;
using System.Diagnostics;
using System.Globalization;
using System.Media;
using System.Runtime.InteropServices;

namespace CityLauncher
{
    internal static class Program
    {

        private static readonly Logger Nlog = LogManager.GetCurrentClassLogger();

        public static readonly string CurrentTime = DateTime.Now.ToString("dd-MM-yy__hh-mm-ss");

        public static CityLauncher MainWindow;

        public static IniHandler IniHandler;

        public static FileHandler FileHandler;

        public static InputHandler InputHandler;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        ///     Replacement Application for the original Batman: Arkham City BmLauncher
        ///     Offers more configuration options, enables compatibility with High-Res Texture Packs
        ///     and automatically takes care of the ReadOnly properties of each file, removing
        ///     any requirement to manually edit .ini files. Guarantees a much more comfortable user experience.
        ///     @author Neato (https://steamcommunity.com/id/frofoo)
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool IsNewWindow = true;
            using (Mutex mtx = new(true, "{BD4C408D-EF15-4C98-B792-C30D089E19D1}", out IsNewWindow))
            {
                if (args.Contains("-nolauncher"))
                {
                    SetupCulture();
                    SetupLogger();
                    LauncherBypass();
                }
                else if (IsNewWindow)
                {
                    SetupCulture();
                    SetupLogger();
                    InitializeProgram();
                    Application.Run(MainWindow);
                }
                else
                {
                    Process Current = Process.GetCurrentProcess();
                    foreach (Process P in Process.GetProcessesByName(Current.ProcessName))
                    {
                        if (P.Id != Current.Id)
                        {
                            SetForegroundWindow(P.MainWindowHandle);
                            break;
                        }
                    }
                }
            }
        }

        private static void SetupCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private static void InitializeProgram()
        {
            Nlog.Info("InitializeProgram - Starting logs at {0} on {1}.", DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
            ApplicationConfiguration.Initialize();
            MainWindow = new CityLauncher();
            FileHandler = new FileHandler();
            IniHandler = new IniHandler();
            InputHandler = new InputHandler();
            var SystemHandler = new SystemHandler();
            MainWindow.GPULabel.Text = SystemHandler.GPUData;
            MainWindow.CPULabel.Text = SystemHandler.CPUData;
            new IniReader().InitDisplay();
            new InputReader().InitControls();
        }

        private static void SetupLogger()
        {
            LoggingConfiguration config = new();
            ConsoleTarget logconsole = new("logconsole");
            if (!Directory.Exists("logs"))
            {
                Directory.CreateDirectory("logs");
            }

            FileTarget logfile = new("logfile")
            {
                FileName = Directory.GetCurrentDirectory() + "\\logs\\citylauncher_report__" + CurrentTime + ".log"
            };
            DirectoryInfo LogDirectory = new(Directory.GetCurrentDirectory() + "\\logs");
            DateTime OldestAllowedArchive = DateTime.Now - new TimeSpan(3, 0, 0, 0);
            foreach (FileInfo file in LogDirectory.GetFiles())
            {
                if (file.CreationTime < OldestAllowedArchive)
                {
                    file.Delete();
                }
            }

            config.AddRule(LogLevel.Debug, LogLevel.Warn, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Warn, logfile);
            LogManager.Configuration = config;
        }

        private static void LauncherBypass()
        {
            Nlog.Info("LauncherBypass - Starting logs at {0} on {1}.", DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
            using (Process LaunchGame = new())
            {
                if (FileHandler.DetectGameExe())
                {
                    LaunchGame.StartInfo.FileName = "BatmanAC.exe";
                    LaunchGame.StartInfo.CreateNoWindow = true;
                    LaunchGame.Start();
                    Nlog.Info("LauncherBypass - Launching the game. Concluding logs at {0} on {1}.", DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Could not find 'BatmanAC.exe'.\nIs the Launcher in the correct folder?", "Error!", MessageBoxButtons.OK);
                }
            }
        }
}
}