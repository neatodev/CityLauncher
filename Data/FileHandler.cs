using CityLauncher.Properties;

namespace CityLauncher
{
    internal class FileHandler
    {

        private bool IntroFilesRenamed;
        private readonly string Startup = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf");
        private readonly string StartupNV = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf");
        private readonly string StartupRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf.bak");
        private readonly string StartupNVRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf.bak");

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
            CheckIntroVideoFilesRenamed();
        }

        private void CheckConfigFilesExist()
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config"));
            }


            if (!File.Exists(BmEnginePath))
            {
                CreateConfigFile(BmEnginePath, Resources.BmEngine);
            }

            if (!File.Exists(UserEnginePath))
            {
                CreateConfigFile(UserEnginePath, Resources.UserEngine);

            }

            if (File.Exists(UserInputPath))
            {
                string[] Lines = File.ReadAllLines(UserInputPath);
                if (Lines.Length < 105)
                {
                    File.Delete(UserInputPath);
                    CreateConfigFile(UserInputPath, Resources.UserInput);
                }
            }
            else if (!File.Exists(UserInputPath))
            {
                CreateConfigFile(UserInputPath, Resources.UserInput);
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
