using IniParser;
using IniParser.Model;

namespace CityLauncher
{
    internal class IniWriter
    {
        string BmEnginePath;
        FileIniDataParser BmEngineWriter;

        public IniWriter()
        {
            BmEnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini");
            BmEngineWriter = new FileIniDataParser();
        }

        public void WriteAll()
        {
            WriteBmEngineBasic();
        }

        private void WriteBmEngineBasic()
        {
            // Resolution
            var ResX = Program.MainWindow.ResolutionBox.SelectedItem.ToString().Substring(0, Program.MainWindow.ResolutionBox.SelectedItem.ToString().LastIndexOf("x"));
            var ResY = Program.MainWindow.ResolutionBox.SelectedItem.ToString().Substring(Program.MainWindow.ResolutionBox.SelectedItem.ToString().LastIndexOf("x") + 1);
            IniHandler.BmEngineData["SystemSettings"]["ResX"] = ResX;
            IniHandler.BmEngineData["SystemSettings"]["ResY"] = ResY;

            // Fullscreen

        }
    }
}
