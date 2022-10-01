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
            InitColors();
            InitTexturePackFix();
            Program.MainWindow.DisplaySettingChanged = false;
            Program.MainWindow.ApplySettingsButton.Enabled = false;
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
            Program.MainWindow.DetailModeBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["DetailMode"] switch
            {
                "1" => 1,
                "2" => 2,
                _ => 0,
            };

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
                Program.MainWindow.ShadowSoftnessBox.Enabled = false;
            }

            // Language
            Program.MainWindow.LanguageBox.SelectedIndex = IniHandler.BmEngineData["Engine.Engine"]["Language"] switch
            {
                "Deu" => 1,
                "Esm" => 2,
                "Esn" => 3,
                "Fra" => 4,
                "Ita" => 5,
                "Jpn" => 6,
                "Kor" => 7,
                "Pol" => 8,
                "Por" => 9,
                "Rus" => 10,
                _ => 0,
            };
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
                        Program.MainWindow.AntiAliasingBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] switch
                        {
                            "2xMSAA" => 4,
                            "4xMSAA" => 5,
                            _ => 6,
                        };
                        break;
                    }
            }

            // Anisotropic Filtering
            Program.MainWindow.AnisoBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["MaxAnisotropy"] switch
            {
                "8" => 1,
                "16" => 2,
                _ => 0,
            };

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
            Program.MainWindow.TessellationBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] switch
            {
                "2048.000000" => 1,
                "512.000000" => 2,
                "256.000000" => 3,
                "128.000000" => 4,
                "64.000000" => 5,
                _ => 0,
            };

            // HBAO Intensity
            Program.MainWindow.HbaoBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["HBAOGamma"] switch
            {
                "3.000000" => 1,
                "5.000000" => 2,
                _ => 0,
            };

            // Shadow Quality
            // ShadowDepthBias is not read and only modified during the writing process.
            Program.MainWindow.ShadowQualityBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["MaxShadowResolution"] switch
            {
                "1024" => 1,
                "2048" => 2,
                "4096" => 3,
                _ => 0,
            };

            // Depth of Field
            if (IniHandler.BmEngineData["SystemSettings"]["DepthOfField"] == "True")
            {
                Program.MainWindow.DOFBox.Checked = true;
                Program.MainWindow.AdvancedColorBox.Enabled = true;
            }
            else
            {
                Program.MainWindow.DOFBox.Checked = false;
                Program.MainWindow.AdvancedColorBox.Text = "Advanced Color Settings ('Depth of Field' must be enabled to edit.)";
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

            // Shadow Softness
            Program.MainWindow.ShadowSoftnessBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowLightRadius"] switch
            {
                "2.000000" => 0,
                "4.000000" => 1,
                "8.000000" => 2,
                "32.000000" => 4,
                _ => 3,
            };

            // MVSS Coverage
            Program.MainWindow.MVSSBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"] switch
            {
                "0.750000" => 1,
                "0.500000" => 2,
                "0.250000" => 3,
                _ => 0,
            };

            // Shadow Draw Distance
            Program.MainWindow.ShadowDrawDistBox.SelectedIndex = IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"] switch
            {
                "1.500000" => 1,
                "2.000000" => 2,
                "4.000000" => 3,
                _ => 0,
            };

            // PhysX
            Program.MainWindow.PhysXBox.SelectedIndex = IniHandler.BmEngineData["Engine.Engine"]["PhysXLevel"] switch
            {
                "1" => 1,
                "2" => 2,
                _ => 0,
            };

            // Poolsize
            Program.MainWindow.PoolsizeBox.SelectedIndex = IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] switch
            {
                "1024" => 1,
                "2048" => 2,
                "3072" => 3,
                "4096" => 4,
                "0" => 5,
                _ => 0,
            };

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
        private void InitColors()
        {
            // Saturation
            Program.MainWindow.SaturationTrackbar.Value = Program.IniHandler.ColorIniToLauncher(IniHandler.BmEngineData["Engine.Player"]["PP_DesaturationMultiplier"]);
            Program.MainWindow.SaturationValueLabel.Text = Program.MainWindow.SaturationTrackbar.Value.ToString() + "%";

            // Highlights
            Program.MainWindow.HighlightsTrackbar.Value = Program.IniHandler.ColorIniToLauncher(IniHandler.BmEngineData["Engine.Player"]["PP_HighlightsMultiplier"]);
            Program.MainWindow.HighlightsValueLabel.Text = Program.MainWindow.HighlightsTrackbar.Value.ToString() + "%";

            // Midtones
            Program.MainWindow.MidtonesTrackbar.Value = Program.IniHandler.ColorIniToLauncher(IniHandler.BmEngineData["Engine.Player"]["PP_MidTonesMultiplier"]);
            Program.MainWindow.MidtonesValueLabel.Text = Program.MainWindow.MidtonesTrackbar.Value.ToString() + "%";

            // Shadows
            Program.MainWindow.ShadowsTrackbar.Value = Program.IniHandler.ColorIniToLauncher(IniHandler.BmEngineData["Engine.Player"]["PP_ShadowsMultiplier"]);
            Program.MainWindow.ShadowsValueLabel.Text = Program.MainWindow.ShadowsTrackbar.Value.ToString() + "%";
        }

        private void InitTexturePackFix()
        {
            //TEXTUREGROUP_Character
            if (IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_Character"] == Program.IniHandler.TexturePackEnabled[0])
            {
                Program.IniHandler.TexPackEnabled[0] = true;
            }
            //TEXTUREGROUP_CharacterNormalMap
            if (IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_CharacterNormalMap"] == Program.IniHandler.TexturePackEnabled[1])
            {
                Program.IniHandler.TexPackEnabled[1] = true;
            }
            //TEXTUREGROUP_World_Hi
            if (IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_World_Hi"] == Program.IniHandler.TexturePackEnabled[1])
            {
                Program.IniHandler.TexPackEnabled[2] = true;
            }
            //TEXTUREGROUP_WorldNormalMap_Hi
            if (IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_WorldNormalMap_Hi"] == Program.IniHandler.TexturePackEnabled[1])
            {
                Program.IniHandler.TexPackEnabled[3] = true;
            }
            //TEXTUREGROUP_World
            if (IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_World"] == Program.IniHandler.TexturePackEnabled[1])
            {
                Program.IniHandler.TexPackPlusEnabled[0] = true;
            }
            //TEXTUREGROUP_WorldNormalMap
            if (IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_WorldNormalMap"] == Program.IniHandler.TexturePackEnabled[1])
            {
                Program.IniHandler.TexPackPlusEnabled[1] = true;
            }

            if (Program.IniHandler.TexPackEnabled.All(x => x) && Program.IniHandler.TexPackPlusEnabled.All(x => x))
            {
                Program.MainWindow.TextureFixButton.Text = "DISABLE TEXTURE PACK FIX";
                Program.MainWindow.BasicToolTip.SetToolTip(Program.MainWindow.TextureFixButton, "Disable Texture Pack Fix.");
                Program.MainWindow.TexturePlusCheckBox.Enabled = true;
                Program.MainWindow.TexturePlusCheckBox.Checked = true;
            }
            else if (Program.IniHandler.TexPackEnabled.All(x => x))
            {
                Program.MainWindow.TextureFixButton.Text = "Disable Texture Pack Fix";
                Program.MainWindow.BasicToolTip.SetToolTip(Program.MainWindow.TextureFixButton, "Disable Texture Pack Fix.");
                Program.MainWindow.TexturePlusCheckBox.Enabled = true;
                Program.MainWindow.TexturePlusCheckBox.Checked = false;
            }
            else
            {
                Program.MainWindow.TexturePlusCheckBox.Checked = false;
                Program.MainWindow.TexturePlusCheckBox.Enabled = false;
            }
        }
    }
}
