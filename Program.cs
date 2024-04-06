using NLog;
using NLog.Config;
using NLog.Targets;
using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
using System.Reflection;
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
        ///     @author Neato (https://www.nexusmods.com/users/81089053)
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
            Nlog.Info("InitializeProgram - Current application version: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            ApplicationConfiguration.Initialize();
            InitFonts();
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

            config.AddRule(LogLevel.Debug, LogLevel.Error, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Error, logfile);
            LogManager.Configuration = config;
        }

        private static void InitFonts()
        {
            bool calibri = IsFontInstalled("calibri");
            bool impact = IsFontInstalled("impact");

            if (!impact && !calibri)
            {
                Nlog.Warn("InitFonts - Impact and Calibri are not installed. May cause display issues.");
                MessageBox.Show("The fonts \"Calibri\" and \"Impact\" are missing on your system. This may lead to display and scaling issues inside of the application.", "Missing fonts!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!impact)
            {
                Nlog.Warn("InitFonts - Impact is not installed. May cause display issues.");
                MessageBox.Show("The font \"Impact\" is missing on your system. This may lead to display and scaling issues inside of the application.", "Missing font!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!calibri)
            {
                Nlog.Warn("InitFonts - Calibri is not installed. May cause display issues.");
                MessageBox.Show("The font \"Calibri\" is missing on your system. This may lead to display and scaling issues inside of the application.", "Missing font!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Nlog.Info("InitFonts - Necessary fonts installed.");
        }

        private static bool IsFontInstalled(string FontFamily)
        {
            using (Font f = new Font(FontFamily, 10f, FontStyle.Regular))
            {
                StringComparison comparison = StringComparison.InvariantCultureIgnoreCase;
                return (string.Compare(FontFamily, f.Name, comparison) == 0);
            }
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