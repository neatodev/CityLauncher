using NLog;

namespace CityLauncher
{
    internal class IniReader
    {

        private static Logger Nlog = LogManager.GetCurrentClassLogger();

        public void InitDisplay()
        {
            InitDisplayBasic();
            InitDisplayAdvanced();
            Nlog.Info("InitDisplay - Sucessfully initialized display settings.");
        }

        private void InitDisplayBasic()
        {
            // Resolution
            var ResX = IniHandler.BmEngineData["SystemSettings"]["ResX"];
            var ResY = IniHandler.BmEngineData["SystemSettings"]["ResY"];
            new Resolution().GetResolutions();
            foreach (string Resolution in Resolution.ResolutionList)
            {
                Program.MainWindow.ResolutionBox.Items.Add(Resolution);
                if (ResX + "x" + ResY == Resolution)
                {
                    Program.MainWindow.ResolutionBox.SelectedIndex = Program.MainWindow.ResolutionBox.Items.IndexOf(Resolution);
                }
            }

            // Fullscreen
            if (IniHandler.BmEngineData["SystemSettings"]["Fullscreen"] == "True")
            {
                Program.MainWindow.FullscreenBox.SelectedIndex = 0;
            }
            else
            {
                Program.MainWindow.FullscreenBox.SelectedIndex = 1;
            }

            // VSync
            if (IniHandler.BmEngineData["SystemSettings"]["UseVsync"] == "True")
            {
                Program.MainWindow.VsyncBox.SelectedIndex = 0;
            }
            else
            {
                Program.MainWindow.VsyncBox.SelectedIndex = 1;
            }

            // DetailMode
            switch (IniHandler.BmEngineData["SystemSettings"]["DetailMode"])
            {
                case "1":
                    Program.MainWindow.DetailModeBox.SelectedIndex = 1;
                    break;
                case "2":
                    Program.MainWindow.DetailModeBox.SelectedIndex = 2;
                    break;
                default:
                    Program.MainWindow.DetailModeBox.SelectedIndex = 0;
                    break;
            }

            // Framerate Cap
            short Framecap = short.Parse(IniHandler.BmEngineData["Engine.Engine"]["MaxSmoothedFrameRate"]);
            Framecap -= 2;
            Program.MainWindow.FrameCapTextBox.Text = Framecap.ToString();

            // DX11 Features
            if (IniHandler.BmEngineData["SystemSettings"]["AllowD3D11"] == "True")
            {
                Program.MainWindow.Dx11Box.Checked = true;
            }
            else
            {
                Program.MainWindow.Dx11Box.Checked = false;
                Program.MainWindow.MVSSBox.Enabled = false;
                Program.MainWindow.HbaoBox.Enabled = false;
                Program.MainWindow.TessellationBox.Enabled = false;
            }

            // Language
            switch (IniHandler.BmEngineData["Engine.Engine"]["Language"])
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

        private void InitDisplayAdvanced()
        {
            // Anti-Aliasing
            switch (IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"])
            {
                case "1":
                    Program.MainWindow.AntiAliasingBox.SelectedIndex = 1;
                    break;
                case "2":
                    Program.MainWindow.AntiAliasingBox.SelectedIndex = 2;
                    break;
                case "3":
                    Program.MainWindow.AntiAliasingBox.SelectedIndex = 3;
                    break;
                default:
                    if (IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] == "1xMSAA")
                    {
                        Program.MainWindow.AntiAliasingBox.SelectedIndex = 0;
                        break;
                    }
                    else
                    {
                        switch (IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"])
                        {
                            case "2xMSAA":
                                Program.MainWindow.AntiAliasingBox.SelectedIndex = 4;
                                break;
                            case "4xMSAA":
                                Program.MainWindow.AntiAliasingBox.SelectedIndex = 5;
                                break;
                            default:
                                Program.MainWindow.AntiAliasingBox.SelectedIndex = 6;
                                break;
                        }
                        break;
                    }
            }

            // Anisotropic Filtering
            switch (IniHandler.BmEngineData["SystemSettings"]["MaxAnisotropy"])
            {
                case "8":
                    Program.MainWindow.AnisoBox.SelectedIndex = 1;
                    break;
                case "16":
                    Program.MainWindow.AnisoBox.SelectedIndex = 2;
                    break;
                default:
                    Program.MainWindow.AnisoBox.SelectedIndex = 0;
                    break;
            }

            // Ambient Occlusion
            if (IniHandler.BmEngineData["SystemSettings"]["AmbientOcclusion"] == "True")
            {
                Program.MainWindow.AmbientOcclusionBox.Checked = true;
            }
            else
            {
                Program.MainWindow.AmbientOcclusionBox.Checked = false;
            }

            // Tessellation Quality
            switch (IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"])
            {
                case "2048.000000":
                    Program.MainWindow.TessellationBox.SelectedIndex = 1;
                    break;
                case "512.000000":
                    Program.MainWindow.TessellationBox.SelectedIndex = 2;
                    break;
                case "256.000000":
                    Program.MainWindow.TessellationBox.SelectedIndex = 3;
                    break;
                case "128.000000":
                    Program.MainWindow.TessellationBox.SelectedIndex = 4;
                    break;
                case "64.000000":
                    Program.MainWindow.TessellationBox.SelectedIndex = 5;
                    break;
                default:
                    Program.MainWindow.TessellationBox.SelectedIndex = 0;
                    break;
            }

            // HBAO Intensity
            switch (IniHandler.BmEngineData["SystemSettings"]["HBAOGamma"])
            {
                case "3.000000":
                    Program.MainWindow.HbaoBox.SelectedIndex = 1;
                    break;
                case "5.000000":
                    Program.MainWindow.HbaoBox.SelectedIndex = 2;
                    break;
                default:
                    Program.MainWindow.HbaoBox.SelectedIndex = 0;
                    break;
            }

            // Shadow Quality
            // ShadowDepthBias is not read and only modified during the writing process.
            switch (IniHandler.BmEngineData["SystemSettings"]["MaxShadowResolution"])
            {
                case "1024":
                    Program.MainWindow.ShadowQualityBox.SelectedIndex = 1;
                    break;
                case "2048":
                    Program.MainWindow.ShadowQualityBox.SelectedIndex = 2;
                    break;
                case "4096":
                    Program.MainWindow.ShadowQualityBox.SelectedIndex = 3;
                    break;
                default:
                    Program.MainWindow.ShadowQualityBox.SelectedIndex = 0;
                    break;
            }

            // Depth of Field
            if (IniHandler.BmEngineData["SystemSettings"]["DepthOfField"] == "True")
            {
                Program.MainWindow.DOFBox.Checked = true;
            }
            else
            {
                Program.MainWindow.DOFBox.Checked = false;
            }

            // Motion Blur
            if (IniHandler.BmEngineData["SystemSettings"]["MotionBlur"] == "True")
            {
                Program.MainWindow.MotionBlurBox.Checked = true;
            }
            else
            {
                Program.MainWindow.MotionBlurBox.Checked = false;
            }

            // Dynamic Lighting
            if (IniHandler.BmEngineData["SystemSettings"]["CompositeDynamicLights"] == "True")
            {
                Program.MainWindow.DynLightBox.Checked = true;
            }
            else
            {
                Program.MainWindow.DynLightBox.Checked = false;
            }

            // Dynamic Shadows
            if (IniHandler.BmEngineData["SystemSettings"]["DynamicShadows"] == "True")
            {
                Program.MainWindow.DynShadowBox.Checked = true;
            }
            else
            {
                Program.MainWindow.DynShadowBox.Checked = false;
            }

            // Distortion
            if (IniHandler.BmEngineData["SystemSettings"]["Distortion"] == "True")
            {
                Program.MainWindow.DistortionBox.Checked = true;
            }
            else
            {
                Program.MainWindow.DistortionBox.Checked = false;
            }

            // Lens Flares
            if (IniHandler.BmEngineData["SystemSettings"]["LensFlares"] == "True")
            {
                Program.MainWindow.LensFlareBox.Checked = true;
            }
            else
            {
                Program.MainWindow.LensFlareBox.Checked = false;
            }

            // Bloom
            if (IniHandler.BmEngineData["SystemSettings"]["Bloom"] == "True")
            {
                Program.MainWindow.BloomBox.Checked = true;
            }
            else
            {
                Program.MainWindow.BloomBox.Checked = false;
            }

            // Light Rays
            if (IniHandler.BmEngineData["SystemSettings"]["bAllowLightShafts"] == "True")
            {
                Program.MainWindow.LightRayBox.Checked = true;
            }
            else
            {
                Program.MainWindow.LightRayBox.Checked = false;
            }

            // MVSS Coverage
            switch (IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"])
            {
                case "0.750000":
                    Program.MainWindow.MVSSBox.SelectedIndex = 1;
                    break;
                case "0.500000":
                    Program.MainWindow.MVSSBox.SelectedIndex = 2;
                    break;
                case "0.250000":
                    Program.MainWindow.MVSSBox.SelectedIndex = 3;
                    break;
                default:
                    Program.MainWindow.MVSSBox.SelectedIndex = 0;
                    break;
            }

            // Shadow Draw Distance
            switch (IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"])
            {
                case "1.500000":
                    Program.MainWindow.ShadowDrawDistBox.SelectedIndex = 1;
                    break;
                case "2.000000":
                    Program.MainWindow.ShadowDrawDistBox.SelectedIndex = 2;
                    break;
                case "4.000000":
                    Program.MainWindow.ShadowDrawDistBox.SelectedIndex = 3;
                    break;
                default:
                    Program.MainWindow.ShadowDrawDistBox.SelectedIndex = 0;
                    break;
            }

            // PhysX
            switch (IniHandler.BmEngineData["Engine.Engine"]["PhysXLevel"])
            {
                case "1":
                    Program.MainWindow.PhysXBox.SelectedIndex = 1;
                    break;
                case "2":
                    Program.MainWindow.PhysXBox.SelectedIndex = 2;
                    break;
                default:
                    Program.MainWindow.PhysXBox.SelectedIndex = 0;
                    break;
            }

            // Poolsize
            switch (IniHandler.BmEngineData["TextureStreaming"]["PoolSize"])
            {
                case "1024":
                    Program.MainWindow.PoolsizeBox.SelectedIndex = 1;
                    break;
                case "2048":
                    Program.MainWindow.PoolsizeBox.SelectedIndex = 2;
                    break;
                case "3072":
                    Program.MainWindow.PoolsizeBox.SelectedIndex = 3;
                    break;
                case "4096":
                    Program.MainWindow.PoolsizeBox.SelectedIndex = 4;
                    break;
                case "0":
                    Program.MainWindow.PoolsizeBox.SelectedIndex = 5;
                    break;
                default:
                    Program.MainWindow.PoolsizeBox.SelectedIndex = 0;
                    break;
            }

            // Reflections
            if (IniHandler.BmEngineData["SystemSettings"]["Reflections"] == "True")
            {
                Program.MainWindow.ReflectionBox.Checked = true;
            }
            else
            {
                Program.MainWindow.ReflectionBox.Checked = false;
            }

        }

    }
}
