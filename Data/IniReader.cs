using IniParser;
using IniParser.Model;

namespace CityLauncher
{
    internal class IniReader
    {
        IniData BmEngineData;


        public IniReader()
        {
            var DisplayIni = new FileIniDataParser();
            DisplayIni.Parser.Configuration.AllowDuplicateKeys = true;
            BmEngineData = DisplayIni.ReadFile((Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini")));
        }

        public void InitDisplay()
        {
            if (BmEngineData["SystemSettings"]["Fullscreen"] == "True")
            {
                Program.MainWindow.FullscreenBox.SelectedIndex = 0;
            }
        }
        
    }
}
