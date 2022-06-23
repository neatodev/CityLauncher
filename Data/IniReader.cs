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
            BmEngineData = DisplayIni.ReadFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini"));
        }

        public void InitDisplay()
        {
            // Resolution
            var ResX = BmEngineData["SystemSettings"]["ResX"];
            var ResY = BmEngineData["SystemSettings"]["ResY"];
            new Resolution();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (string Resolution in Resolution.ResolutionList)
            {
                Program.MainWindow.ResolutionBox.Items.Add(Resolution);
                if (ResX + "x" + ResY == Resolution)
                {
                    Program.MainWindow.ResolutionBox.SelectedIndex = Program.MainWindow.ResolutionBox.Items.IndexOf(Resolution);
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            // Fullscreen
            if (BmEngineData["SystemSettings"]["Fullscreen"] == "True")
            {
                Program.MainWindow.FullscreenBox.SelectedIndex = 0;
            }
            else
            {
                Program.MainWindow.FullscreenBox.SelectedIndex = 1;
            }

            // VSync
            if (BmEngineData["SystemSettings"]["UseVsync"] == "True")
            {
                Program.MainWindow.VsyncBox.SelectedIndex = 0;
            }
            else
            {
                Program.MainWindow.VsyncBox.SelectedIndex = 1;
            }

            // DetailMode
            switch (BmEngineData["SystemSettings"]["DetailMode"])
            {
                case "0":
                    Program.MainWindow.DetailModeBox.SelectedIndex = 0;
                    break;
                case "1":
                    Program.MainWindow.DetailModeBox.SelectedIndex = 1;
                    break;
                default:
                    Program.MainWindow.DetailModeBox.SelectedIndex = 2;
                    break;
            }

            // Framerate Cap
            Program.MainWindow.FrameCapTextBox.Text = BmEngineData["Engine.Engine"]["MaxSmoothedFrameRate"];

            // DX11 Features
            if (BmEngineData["SystemSettings"]["AllowD3D11"] == "True")
            {
                Program.MainWindow.Dx11Box.SelectedIndex = 0;
            }
            else
            {
                Program.MainWindow.Dx11Box.SelectedIndex = 1;
            }

            // Language
            switch (BmEngineData["Engine.Engine"]["Language"])
            {
                case "Deu":
                    Program.MainWindow.LanguageBox.SelectedIndex = 1;
                    break;
                case "Esm":
                    Program.MainWindow.LanguageBox.SelectedIndex = 2;
                    break;
                case "Esn":
                    Program.MainWindow.LanguageBox.SelectedIndex = 3;
                    break;
                case "Fra":
                    Program.MainWindow.LanguageBox.SelectedIndex = 4;
                    break;
                case "Ita":
                    Program.MainWindow.LanguageBox.SelectedIndex = 5;
                    break;
                case "Jpn":
                    Program.MainWindow.LanguageBox.SelectedIndex = 6;
                    break;
                case "Kor":
                    Program.MainWindow.LanguageBox.SelectedIndex = 7;
                    break;
                case "Pol":
                    Program.MainWindow.LanguageBox.SelectedIndex = 8;
                    break;
                case "Por":
                    Program.MainWindow.LanguageBox.SelectedIndex = 9;
                    break;
                case "Rus":
                    Program.MainWindow.LanguageBox.SelectedIndex = 10;
                    break;
                default:
                    Program.MainWindow.LanguageBox.SelectedIndex = 0;
                    break;
            }
        }

    }
}
