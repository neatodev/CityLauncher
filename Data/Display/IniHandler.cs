﻿using CityLauncher.Properties;
using IniParser;
using IniParser.Model;
using NLog;
using System.Globalization;

namespace CityLauncher
{
    internal class IniHandler
    {
        public static IniData? BmEngineData { get; set; }
        public static IniData? BmInputData { get; set; }

        private static Logger Nlog = LogManager.GetCurrentClassLogger();

        public string[] TexturePackDefaults = { "(MinLODSize=256,MaxLODSize=2048,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)",
                                                "(MinLODSize=128,MaxLODSize=2048,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)",
                                                "(MinLODSize=128,MaxLODSize=1024,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)",
                                                "(MinLODSize=1024,MaxLODSize=2048,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)"};

        public string[] TexturePackEnabled = { "(MinLODSize=256,MaxLODSize=4096,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)",
                                               "(MinLODSize=128,MaxLODSize=4096,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)",
                                               "(MinLODSize=128,MaxLODSize=8192,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)",
                                               "(MinLODSize=1024,MaxLODSize=4096,LODBias=0,MinMagFilter=Aniso,MipFilter=Point,MipGenSettings=TMGS_SimpleAverage)"};

        public bool[] TexPackEnabled = { false, false, false, false, false };
        public bool[] TexPackPlusEnabled = { false, false, false };

        public IniHandler()
        {
            BmEngineData = SetIniData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini"));
            BmInputData = SetIniData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmInput.ini"));
            RemoveSections();
            Nlog.Info("Constructor - Successfully initialized IniHandler.");
        }

        private IniData SetIniData(string Path)
        {
            var IniConfigurator = new FileIniDataParser();
            IniConfigurator.Parser.Configuration.AllowDuplicateKeys = true;
            IniConfigurator.Parser.Configuration.AssigmentSpacer = "";
            return IniConfigurator.ReadFile(Path);
        }

        private static void RemoveSections()
        {
            BmEngineData.Sections.RemoveSection("URL");
            BmEngineData.Sections.RemoveSection("Engine.StreamingMovies");
            BmEngineData.Sections.RemoveSection("Engine.ISVHacks");
            BmEngineData.Sections.RemoveSection("Engine.GameEngine");
            BmEngineData.Sections.RemoveSection("Engine.DemoRecDriver");
            BmEngineData.Sections.RemoveSection("Engine.PackagesToAlwaysCook");
            BmEngineData.Sections.RemoveSection("Engine.StartupPackages");
            BmEngineData.Sections.RemoveSection("Engine.PackagesToForceCookPerMap");
            BmEngineData.Sections.RemoveSection("Core.System");
            BmEngineData.Sections.RemoveSection("Engine.Client");
            BmEngineData.Sections.RemoveSection("WinDrv.WindowsClient");
            BmEngineData.Sections.RemoveSection("IpDrv.TcpNetDriver");
            BmEngineData.Sections.RemoveSection("IpServer.UdpServerQuery");
            BmEngineData.Sections.RemoveSection("IpDrv.UdpBeacon");
            BmEngineData.Sections.RemoveSection("StreamByURL");
            BmEngineData.Sections.RemoveSection("UnrealEd.EditorEngine");
            BmEngineData.Sections.RemoveSection("UnrealEd.UnrealEdEngine");
            BmEngineData.Sections.RemoveSection("Engine.DataStoreClient");
            BmEngineData.Sections.RemoveSection("DevOptions.Shaders");
            BmEngineData.Sections.RemoveSection("DevOptions.Debug");
            BmEngineData.Sections.RemoveSection("StatNotifyProviders");
            BmEngineData.Sections.RemoveSection("StatNotifyProviders.StatNotifyProvider_UDP");
            BmEngineData.Sections.RemoveSection("RemoteControl");
            BmEngineData.Sections.RemoveSection("LogFiles");
            BmEngineData.Sections.RemoveSection("AnimationCompression");
            BmEngineData.Sections.RemoveSection("IpDrv.OnlineSubsystemCommonImpl");
            BmEngineData.Sections.RemoveSection("IpDrv.OnlineGameInterfaceImpl");
            BmEngineData.Sections.RemoveSection("Engine.StaticMeshCollectionActor");
            BmEngineData.Sections.RemoveSection("Engine.StaticLightCollectionActor");
            BmEngineData.Sections.RemoveSection("LiveSock");
            BmEngineData.Sections.RemoveSection("CustomStats");
            BmEngineData.Sections.RemoveSection("MemorySplitClassesToTrack");
            BmEngineData.Sections.RemoveSection("MemLeakCheckExtraExecsToRun");
            BmEngineData.Sections.RemoveSection("ConfigCoalesceFilter");
            BmEngineData.Sections.RemoveSection("TaskPerfTracking");
            BmEngineData.Sections.RemoveSection("TaskPerfMemDatabase");
            BmEngineData.Sections.RemoveSection("SystemSettingsEditor");
            BmEngineData.Sections.RemoveSection("SystemSettingsSplitScreen2");
            BmEngineData.Sections.RemoveSection("SystemSettingsMobile");
            BmEngineData.Sections.RemoveSection("SystemSettingsMobileTextureBias");
            BmEngineData.Sections.RemoveSection("SystemSettingsIPhone3GS");
            BmEngineData.Sections.RemoveSection("SystemSettingsIPhone4");
            BmEngineData.Sections.RemoveSection("SystemSettingsIPodTouch4");
            BmEngineData.Sections.RemoveSection("SystemSettingsIPad");
            BmEngineData.Sections.RemoveSection("Engine.PhysicsLODVerticalEmitter");
            BmEngineData.Sections.RemoveSection("Engine.OnlineSubsystem");
            BmEngineData.Sections.RemoveSection("Engine.OnlineRecentPlayersList");
            BmEngineData.Sections.RemoveSection("VoIP");
            BmEngineData.Sections.RemoveSection("FullScreenMovie");
            BmEngineData.Sections.RemoveSection("IPDrv.WebConnection");
            BmEngineData.Sections.RemoveSection("IPDrv.WebServer");
            BmEngineData.Sections.RemoveSection("IPDrv.WebResponse");
            BmEngineData.Sections.RemoveSection("TextureTracking");
            BmEngineData.Sections.RemoveSection("AnimNotify");
            BmEngineData.Sections.RemoveSection("Engine.UIDataStore_OnlinePlayerData");
            BmEngineData.Sections.RemoveSection("Engine.LocalPlayer");
            BmEngineData.Sections.RemoveSection("MobileSupport");
            BmEngineData.Sections.RemoveSection("Engine.GameViewportClient");
            BmEngineData.Sections.RemoveSection("ContentComparisonReferenceTypes");
            BmEngineData.Sections.RemoveSection("Engine.ApexDestructibleActor");
            BmEngineData.Sections.RemoveSection("Configuration");
            BmEngineData.Sections.RemoveSection("Engine.RockMergeLevels");
            BmEngineData.Sections.RemoveSection("BmEditor.BmEdEngine");
            BmEngineData.Sections.RemoveSection("Windows.StandardUser");
            BmEngineData.Sections.RemoveSection("Engine.AudioDevice");
            BmEngineData.Sections.RemoveSection("BmGameInfoSummary");
            BmEngineData.Sections.RemoveSection("Metrics");
            BmEngineData.Sections.RemoveSection("OnlineSubsystemSteamworks.OnlineSubsystemSteamworks");
            BmEngineData.Sections.RemoveSection("IniVersion");
            BmEngineData.Sections.RemoveSection("AppCompat");
        }

        public int ColorIniToLauncher(string input)
        {
            double inp = double.Parse(input, CultureInfo.InvariantCulture);
            return (int)((inp / 0.04) - 125) * (-1);
        }

        public string ColorLauncherToIni(int input)
        {
            string Affix = "";
            if ((double)(125 - input) * 0.04 % 1 == 0)
            {
                Affix = ".00";
            }
            return ((double)(125 - input) * 0.04).ToString() + Affix;
        }

        public void ResetDisplay()
        {
            Program.FileHandler.BmEngine.IsReadOnly = false;
            File.Delete(Program.FileHandler.BmEnginePath);
            Program.FileHandler.CreateConfigFile(Program.FileHandler.BmEnginePath, Resources.BmEngine);
            BmEngineData = SetIniData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini"));
            RemoveSections();
            Program.FileHandler.BmEngine.IsReadOnly = true;
            new IniReader().InitDisplay();
            Nlog.Info("ResetDisplay - Successfully reset display settings.");
        }
    }
}
