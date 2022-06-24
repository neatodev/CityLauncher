using IniParser;

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
            BmEngineWriter.WriteFile(BmEnginePath, IniHandler.BmEngineData);
        }

        private void WriteBmEngineBasic()
        {
            // Resolution
            var ResX = Program.MainWindow.ResolutionBox.SelectedItem.ToString().Substring(0, Program.MainWindow.ResolutionBox.SelectedItem.ToString().LastIndexOf("x"));
            var ResY = Program.MainWindow.ResolutionBox.SelectedItem.ToString().Substring(Program.MainWindow.ResolutionBox.SelectedItem.ToString().LastIndexOf("x") + 1);
            IniHandler.BmEngineData["SystemSettings"]["ResX"] = ResX;
            IniHandler.BmEngineData["SystemSettings"]["ResY"] = ResY;

            // Fullscreen
            if (Program.MainWindow.FullscreenBox.SelectedIndex == 0)
            {
                IniHandler.BmEngineData["SystemSettings"]["Fullscreen"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["Fullscreen"] = "False";
            }

            // VSync
            if (Program.MainWindow.VsyncBox.SelectedIndex == 0)
            {
                IniHandler.BmEngineData["SystemSettings"]["UseVsync"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["UseVsync"] = "False";
            }

            // Detail Mode
            switch (Program.MainWindow.DetailModeBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["DetailMode"] = "1";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["DetailMode"] = "2";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["DetailMode"] = "0";
                    break;
            }

            // Framerate Cap
            Int16 Framecap = Int16.Parse(Program.MainWindow.FrameCapTextBox.Text.Trim());
            if (Framecap <= 24)
            {
                Program.MainWindow.FrameCapTextBox.Text = "62";
                IniHandler.BmEngineData["Engine.Engine"]["MaxSmoothedFrameRate"] = "62";
            }
            else
            {
                Framecap += 2;
                IniHandler.BmEngineData["Engine.Engine"]["MaxSmoothedFrameRate"] = Framecap.ToString();
            }

            // Language
            switch (Program.MainWindow.LanguageBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Deu";
                    break;
                case 2:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Esm";
                    break;
                case 3:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Esn";
                    break;
                case 4:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Fra";
                    break;
                case 5:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Ita";
                    break;
                case 6:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Jpn";
                    break;
                case 7:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Kor";
                    break;
                case 8:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Pol";
                    break;
                case 9:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Por";
                    break;
                case 10:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Rus";
                    break;
                default:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Int";
                    break;
            }

            // DX11 Features
            if (Program.MainWindow.Dx11Box.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["AllowD3D11"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["AllowD3D11"] = "False";
            }

        }
    }
}
