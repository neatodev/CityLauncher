namespace CityLauncher
{
    internal class FileHandler
    {

        private bool IntroFilesRenamed;
        private string Startup = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf");
        private string StartupNV = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf");
        private string StartupRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf.bak");
        private string StartupNVRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf.bak");

        public FileInfo BmEngine = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini"));
        public FileInfo UserEngine = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserEngine.ini"));

        public FileHandler()
        {
            CheckIntroVideoFilesRenamed();
        }

        private bool DetectGameExe()
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
