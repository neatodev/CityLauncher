using IniParser;
using IniParser.Model;

namespace CityLauncher
{
    internal class IniHandler
    {
        public static IniData? BmEngineData { get; set; }
        public static IniData? UserEngineData { get; set; }


        public IniHandler()
        {
            var IniConfigurator = new FileIniDataParser();
            IniConfigurator.Parser.Configuration.AllowDuplicateKeys = true;
            IniConfigurator.Parser.Configuration.AssigmentSpacer = "";
            BmEngineData = IniConfigurator.ReadFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini"));
            UserEngineData = IniConfigurator.ReadFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserEngine.ini"));
        }

    }
}
