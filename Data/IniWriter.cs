using IniParser;
using NLog;

namespace CityLauncher
{
    internal class IniWriter
    {
        string BmEnginePath;
        string UserEnginePath;
        string BmEngineTemp;
        string UserEngineTemp;
        FileIniDataParser DataParser;

        string[] ExcludedEntries = { "LightComplexityColors", "ShaderComplexityColors" };

        private static Logger Nlog = LogManager.GetCurrentClassLogger();


        public IniWriter()
        {
            BmEnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini");
            UserEnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserEngine.ini");
            DataParser = new FileIniDataParser();
        }

        public void WriteAll()
        {
            WriteBmEngineBasic();
            WriteBmEngineAdvanced();
            WriteToTempFile();
            MergeBmEngine();
            Program.FileHandler.RenameIntroVideoFiles();
        }

        private void WriteToTempFile()
        {
            var TempDir = Path.Combine(Environment.CurrentDirectory, "Temp");
            BmEngineTemp = Path.Combine(TempDir, "BmEngineTemp.ini");
            UserEngineTemp = Path.Combine(TempDir, "UserEngineTemp.ini");
            Directory.CreateDirectory(TempDir);
            File.Create(BmEngineTemp).Dispose();
            File.Create(UserEngineTemp).Dispose();


            DataParser.WriteFile(BmEngineTemp, IniHandler.BmEngineData);
            DataParser.WriteFile(UserEngineTemp, IniHandler.UserEngineData);

        }

        private void MergeBmEngine()
        {
            string[] BmEngineOrig = File.ReadAllLines(BmEnginePath);
            string[] BmEngineNew = File.ReadAllLines(BmEngineTemp);

            for (int i = 0; i < BmEngineNew.Length - 1; i++)
            {
                if (BmEngineNew[i].Contains('='))
                {
                    var LineTrimmed = BmEngineNew[i].Substring(0, BmEngineNew[i].LastIndexOf('='));
                    for (int j = 0; j < BmEngineOrig.Length; j++)
                    {
                        if (BmEngineOrig[j].Contains('=') && BmEngineOrig[j].Substring(0, BmEngineOrig[j].LastIndexOf('=')) == LineTrimmed)
                        {
                            if (LineTrimmed != ExcludedEntries[0] && LineTrimmed != ExcludedEntries[1])
                            {
                                BmEngineOrig[j] = BmEngineNew[i];
                            }
                        }
                    }
                }
            }

            using (StreamWriter BmEngineFile = new StreamWriter(BmEnginePath))
            {
                foreach (string Line in BmEngineOrig)
                {
                    BmEngineFile.WriteLine(Line);
                }
                BmEngineFile.Close();
            }
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
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Deu";
                    break;
                case 2:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Esm";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Esm";
                    break;
                case 3:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Esn";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Esn";
                    break;
                case 4:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Fra";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Fra";
                    break;
                case 5:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Ita";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Ita";
                    break;
                case 6:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Jpn";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Jpn";
                    break;
                case 7:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Kor";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Kor";
                    break;
                case 8:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Pol";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Pol";
                    break;
                case 9:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Por";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Por";
                    break;
                case 10:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Rus";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Rus";
                    break;
                default:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Int";
                    IniHandler.UserEngineData["Engine.Engine"]["Language"] = "Int";
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

        private void WriteBmEngineAdvanced()
        {
            // Anti-Aliasing
            switch (Program.MainWindow.AntiAliasingBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "0";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "1xMSAA";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "1";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "1xMSAA";
                    break;
                case 3:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "2";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "1xMSAA";
                    break;
                case 4:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "3";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "2xMSAA";
                    break;
                case 5:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "0";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "4xMSAA";
                    break;
                case 6:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "0";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "8xMSAA";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "0";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "1xMSAA";
                    break;
            }

            // Anisotropic Filtering
            switch (Program.MainWindow.AnisoBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["MaxAnisotropy"] = "8";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["MaxAnisotropy"] = "16";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["MaxAnisotropy"] = "4";
                    break;
            }

            // Ambient Occlusion
            if (Program.MainWindow.AmbientOcclusionBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["AmbientOcclusion"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["AmbientOcclusion"] = "False";
            }

            // Tessellation Quality
            switch (Program.MainWindow.TessellationBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "2048.000000";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "256.000000";
                    break;
                case 3:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "128.000000";
                    break;
                case 4:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "64.000000";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "0.000000";
                    break;
            }

            // Ambient Occlusion
            switch (Program.MainWindow.HbaoBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["HBAOGamma"] = "3.000000";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["HBAOGamma"] = "5.000000";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["HBAOGamma"] = "1.750000";
                    break;
            }

            // Shadow Quality
            switch (Program.MainWindow.ShadowQualityBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["MaxShadowResolution"] = "1024";
                    IniHandler.BmEngineData["SystemSettings"]["ShadowDepthBias"] = "0.024000";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["MaxShadowResolution"] = "2048";
                    IniHandler.BmEngineData["SystemSettings"]["ShadowDepthBias"] = "0.048000";
                    break;
                case 3:
                    IniHandler.BmEngineData["SystemSettings"]["MaxShadowResolution"] = "4096";
                    IniHandler.BmEngineData["SystemSettings"]["ShadowDepthBias"] = "0.096000";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["MaxShadowResolution"] = "512";
                    IniHandler.BmEngineData["SystemSettings"]["ShadowDepthBias"] = "0.012000";
                    break;
            }

            // Depth of Field
            if (Program.MainWindow.DOFBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["DepthOfField"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["DepthOfField"] = "False";
            }

            // Motion Blur
            if (Program.MainWindow.MotionBlurBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["MotionBlur"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["MotionBlur"] = "False";
            }

            // Dynamic Lighting
            if (Program.MainWindow.DynLightBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["CompositeDynamicLights"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["CompositeDynamicLights"] = "False";
            }

            // Dynamic Shadows
            if (Program.MainWindow.DynShadowBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["DynamicShadows"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["DynamicShadows"] = "False";
            }

            // Distortion
            if (Program.MainWindow.DistortionBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["Distortion"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["Distortion"] = "False";
            }

            // Lens Flares
            if (Program.MainWindow.LensFlareBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["LensFlares"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["LensFlares"] = "False";
            }

            // Bloom
            if (Program.MainWindow.BloomBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["Bloom"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["Bloom"] = "False";
            }

            // Light Rays
            if (Program.MainWindow.LightRayBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["bAllowLightShafts"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["bAllowLightShafts"] = "False";
            }

            // MVSS Coverage
            switch (Program.MainWindow.MVSSBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"] = "0.750000";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"] = "0.500000";
                    break;
                case 3:
                    IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"] = "0.250000";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"] = "1.000000";
                    break;
            }

            // Shadow Draw Distance
            switch (Program.MainWindow.ShadowDrawDistBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"] = "1.500000";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"] = "2.000000";
                    break;
                case 3:
                    IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"] = "4.000000";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"] = "1.000000";
                    break;
            }

            // PhysX
            switch (Program.MainWindow.PhysXBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["Engine.Engine"]["PhysXLevel"] = "1";
                    break;
                case 2:
                    IniHandler.BmEngineData["Engine.Engine"]["PhysXLevel"] = "2";
                    break;
                default:
                    IniHandler.BmEngineData["Engine.Engine"]["PhysXLevel"] = "0";
                    break;
            }

            // Poolsize
            switch (Program.MainWindow.PoolsizeBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] = "1024";
                    break;
                case 2:
                    IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] = "2048";
                    break;
                case 3:
                    IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] = "3072";
                    break;
                case 4:
                    IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] = "4096";
                    break;
                case 5:
                    IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] = "0";
                    break;
                default:
                    IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] = "512";
                    break;
            }
        }
    }
}
