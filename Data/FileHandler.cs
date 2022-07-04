using CityLauncher.Properties;

namespace CityLauncher
{
    internal class FileHandler
    {

        private bool IntroFilesRenamed;
        private readonly string CustomDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Custom");
        private readonly string Startup = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf");
        private readonly string StartupNV = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf");
        private readonly string StartupRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf.bak");
        private readonly string StartupNVRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf.bak");
        private readonly string ConfigDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config");

        public string BmEnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini");
        public string UserEnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserEngine.ini");
        public string BmInputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmInput.ini");
        public string UserInputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserInput.ini");

        public FileInfo BmEngine = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini"));
        public FileInfo UserEngine = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserEngine.ini"));
        public FileInfo BmInput = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmInput.ini"));

        public FileHandler()
        {
            CheckConfigFilesExist();
            CheckCustomFilesExist();
            CheckIntroVideoFilesRenamed();
        }

        private void CheckCustomFilesExist()
        {
            if (!Directory.Exists(CustomDirectoryPath))
            {
                Directory.CreateDirectory(CustomDirectoryPath);
            }

            if (!File.Exists(Path.Combine(CustomDirectoryPath, "centre_camera.txt")))
            {
                CreateConfigFile(Path.Combine(CustomDirectoryPath, "centre_camera.txt"), Resources.centre_camera);
            }

            if (!File.Exists(Path.Combine(CustomDirectoryPath, "custom_commands.txt")))
            {
                CreateConfigFile(Path.Combine(CustomDirectoryPath, "custom_commands.txt"), Resources.custom_commands);
            }
        }

        private void CheckConfigFilesExist()
        {
            if (!Directory.Exists(ConfigDirectoryPath))
            {
                Directory.CreateDirectory(ConfigDirectoryPath);
            }

            if (!File.Exists(BmEnginePath))
            {
                CreateConfigFile(BmEnginePath, Resources.BmEngine);
            }

            if (!File.Exists(BmInputPath))
            {
                CreateConfigFile(BmInputPath, Resources.BmInput);
            }

            if (!File.Exists(UserEnginePath))
            {
                CreateConfigFile(UserEnginePath, Resources.UserEngine);

            }

            if (File.Exists(UserInputPath))
            {
                string[] Lines = File.ReadAllLines(UserInputPath);
                if (Lines.Length < 106)
                {
                    File.Delete(UserInputPath);
                    CreateConfigFile(UserInputPath, Resources.UserInput);
                }
            }
            else if (!File.Exists(UserInputPath))
            {
                CreateConfigFile(UserInputPath, Resources.UserInput);
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmCamera.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmCamera.ini"), Resources.BmCamera);
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmCompat.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmCompat.ini"), Resources.BmCompat);
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmGame.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmGame.ini"), Resources.BmGame);
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmLightmass.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmLightmass.ini"), Resources.BmLightmass);
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmUI.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmUI.ini"), Resources.BmUI);
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "UserGame.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "UserGame.ini"), Resources.UserGame);
            }
        }

        public void CreateConfigFile(string Path, string Resource)
        {
            File.Create(Path).Dispose();
            var FileWriter = new StreamWriter(Path);
            FileWriter.Write(Resource);
            FileWriter.Close();
        }

        private static bool DetectGameExe()
        {
            var GameExe = Path.Combine(Directory.GetCurrentDirectory(), "BatmanAC.exe");
            if (File.Exists(GameExe))
            {
                return true;
            }
            return false;
        }

        private void CheckIntroVideoFilesRenamed()
        {
            if (!DetectGameExe())
            {
                Program.MainWindow.SkipIntroBox.Enabled = false;
                return;
            }

            if (File.Exists(Startup) && File.Exists(StartupNV))
            {
                Program.MainWindow.SkipIntroBox.Enabled = true;
                Program.MainWindow.SkipIntroBox.Checked = false;
                IntroFilesRenamed = false;
            }

            if (File.Exists(StartupRenamed) && File.Exists(StartupNVRenamed))
            {
                Program.MainWindow.SkipIntroBox.Enabled = true;
                Program.MainWindow.SkipIntroBox.Checked = true;
                IntroFilesRenamed = true;
            }
        }

        public void RenameIntroVideoFiles()
        {
            if (!Program.MainWindow.SkipIntroBox.Enabled || !Program.MainWindow.SettingChanged)
            {
                return;
            }

            if (!IntroFilesRenamed && Program.MainWindow.SkipIntroBox.Checked)
            {
                File.Move(Startup, StartupRenamed);
                File.Move(StartupNV, StartupNVRenamed);
                IntroFilesRenamed = !IntroFilesRenamed;
            }
            else if (IntroFilesRenamed && !Program.MainWindow.SkipIntroBox.Checked)
            {
                File.Move(StartupRenamed, Startup);
                File.Move(StartupNVRenamed, StartupNV);
                IntroFilesRenamed = !IntroFilesRenamed;
            }
        }
    }
}
