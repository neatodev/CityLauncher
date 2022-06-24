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
            WriteBmEngine();
        }

        private void WriteBmEngine()
        {

        }
    }
}
