namespace CityLauncher
{
    internal class FileHandler
    {
        public FileHandler()
        {
            CheckIntroVideoFilesDeleted();
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

        private void CheckIntroVideoFilesDeleted()
        {
            if (!DetectGameExe())
            {
                Program.MainWindow.SkipIntroButton.Text = "Could not find executable.";
                return;
            }
            var Startup = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf");
            var StartupNV = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf");

            if (File.Exists(Startup) || File.Exists(StartupNV))
            {
                Program.MainWindow.SkipIntroButton.Enabled = true;
                Program.MainWindow.SkipIntroButton.Text = "Skip Intro Movies";
            }
        }

        public void RemoveIntroVideoFiles()
        {
            var Startup = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf");
            var StartupNV = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf");
            try
            {
                File.Delete(Startup);
                File.Delete(StartupNV);
            }
            catch (FileNotFoundException)
            {
                //TODO Add logger
            }
            Program.MainWindow.SkipIntroButton.Enabled = false;
            Program.MainWindow.SkipIntroButton.Text = "Intro Movies disabled!";
        }
    }
}
