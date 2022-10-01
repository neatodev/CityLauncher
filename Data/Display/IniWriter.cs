using IniParser;
using NLog;

namespace CityLauncher
{
    internal class IniWriter
    {
        private readonly string BmEnginePath;
        private readonly string UserEnginePath;
        private string BmEngineTemp;
        private string UserEngineLangValue;
        readonly FileIniDataParser DataParser;
        readonly string[] ExcludedEntries = { "LightComplexityColors", "ShaderComplexityColors" };

        private static Logger Nlog = LogManager.GetCurrentClassLogger();


        public IniWriter()
        {
            BmEnginePath = Program.FileHandler.BmEnginePath;
            UserEnginePath = Program.FileHandler.UserEnginePath;
            DataParser = new FileIniDataParser();
            Nlog.Info("Constructor - Sucessfully initialized IniWriter.");
        }

        public void WriteAll()
        {
            Program.FileHandler.BmEngine.IsReadOnly = false;
            Program.FileHandler.UserEngine.IsReadOnly = false;
            Program.FileHandler.BmInput.IsReadOnly = false;
            WriteBmEngineBasic();
            WriteBmEngineAdvanced();
            WriteColors();
            WriteTextureGroupLines();
            WriteToTempFile();
            MergeBmEngine();
            WriteToUserEngine();
            Program.FileHandler.RenameIntroVideoFiles();
            Program.FileHandler.BmEngine.IsReadOnly = true;
            Program.FileHandler.UserEngine.IsReadOnly = true;
            Program.FileHandler.BmInput.IsReadOnly = true;
            Nlog.Info("WriteAll - Sucessfully wrote settings to 'BmEngine.ini' and 'UserEngine.ini'.");
        }

        private void WriteToTempFile()
        {
            var TempDir = Path.Combine(Environment.CurrentDirectory, "Temp");
            BmEngineTemp = Path.Combine(TempDir, "BmEngineTemp.ini");
            Directory.CreateDirectory(TempDir);
            File.Create(BmEngineTemp).Dispose();

            DataParser.WriteFile(BmEngineTemp, IniHandler.BmEngineData);
        }

        private void MergeBmEngine()
        {
            string[] BmEngineOrig = File.ReadAllLines(BmEnginePath);
            string[] BmEngineNew = File.ReadAllLines(BmEngineTemp);

            for (int i = 0; i < BmEngineNew.Length - 1; i++)
            {
                if (BmEngineNew[i].Contains('='))
                {
                    var LineTrimmed = BmEngineNew[i].Substring(0, BmEngineNew[i].IndexOf('='));
                    for (int j = 0; j < BmEngineOrig.Length; j++)
                    {
                        if (BmEngineOrig[j].Contains('=') && BmEngineOrig[j].Substring(0, BmEngineOrig[j].IndexOf('=')) == LineTrimmed)
                        {
                            if (LineTrimmed == ExcludedEntries[0] || LineTrimmed == ExcludedEntries[1])
                            {
                                continue;
                            }
                            BmEngineOrig[j] = BmEngineNew[i];
                        }
                    }
                }
            }

            using (StreamWriter BmEngineFile = new(BmEnginePath))
            {
                foreach (string Line in BmEngineOrig)
                {
                    BmEngineFile.WriteLine(Line);
                }
                BmEngineFile.Close();
            }
            DeleteTempFolder();
        }

        private void WriteToUserEngine()
        {
            string[] UserEngine = File.ReadAllLines(UserEnginePath);

            using (StreamWriter UserEngineFile = new(UserEnginePath))
            {
                foreach (string Line in UserEngine)
                {
                    if (Line.Contains("Language"))
                    {
                        UserEngineFile.WriteLine(UserEngineLangValue);
                        continue;
                    }
                    UserEngineFile.WriteLine(Line);
                }
                UserEngineFile.Close();
            }
        }

        private void DeleteTempFolder()
        {
            File.Delete(BmEngineTemp);
            Directory.Delete(Path.Combine(Environment.CurrentDirectory, "Temp"));
        }

        private void WriteBmEngineBasic()
        {
            // Resolution
            var ResX = Program.MainWindow.ResolutionBox.SelectedItem.ToString().Substring(0, Program.MainWindow.ResolutionBox.SelectedItem.ToString().LastIndexOf("x"));
            var ResY = Program.MainWindow.ResolutionBox.SelectedItem.ToString().Substring(Program.MainWindow.ResolutionBox.SelectedItem.ToString().LastIndexOf("x") + 1);
            IniHandler.BmEngineData["SystemSettings"]["ResX"] = ResX;
            IniHandler.BmEngineData["SystemSettings"]["ResY"] = ResY;
            Nlog.Info("WriteBmEngineBasic - Set Resolution to {0}x{1}", ResX, ResY);

            // Fullscreen
            if (Program.MainWindow.FullscreenBox.SelectedIndex == 0)
            {
                IniHandler.BmEngineData["SystemSettings"]["Fullscreen"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["Fullscreen"] = "False";
            }
            Nlog.Info("WriteBmEngineBasic - Set Fullscreen to {0}", IniHandler.BmEngineData["SystemSettings"]["Fullscreen"]);

            // VSync
            if (Program.MainWindow.VsyncBox.SelectedIndex == 0)
            {
                IniHandler.BmEngineData["SystemSettings"]["UseVsync"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["UseVsync"] = "False";
            }
            Nlog.Info("WriteBmEngineBasic - Set VSync to {0}", IniHandler.BmEngineData["SystemSettings"]["UseVsync"]);

            // Detail Mode
            IniHandler.BmEngineData["SystemSettings"]["DetailMode"] = Program.MainWindow.DetailModeBox.SelectedIndex switch
            {
                1 => "1",
                2 => "2",
                _ => "0",
            };
            Nlog.Info("WriteBmEngineBasic - Set Detail Mode to {0}", IniHandler.BmEngineData["SystemSettings"]["DetailMode"]);

            // Framerate Cap
            short Framecap = short.Parse(Program.MainWindow.FrameCapTextBox.Text.Trim());
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
            Nlog.Info("WriteBmEngineBasic - Set Framerate Limit to {0}", (Framecap - 2).ToString());

            // Language
            switch (Program.MainWindow.LanguageBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Deu";
                    UserEngineLangValue = "Language=Deu";
                    break;
                case 2:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Esm";
                    UserEngineLangValue = "Language=Esm";
                    break;
                case 3:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Esn";
                    UserEngineLangValue = "Language=Esn";
                    break;
                case 4:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Fra";
                    UserEngineLangValue = "Language=Fra";
                    break;
                case 5:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Ita";
                    UserEngineLangValue = "Language=Ita";
                    break;
                case 6:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Jpn";
                    UserEngineLangValue = "Language=Jpn";
                    break;
                case 7:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Kor";
                    UserEngineLangValue = "Language=Kor";
                    break;
                case 8:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Pol";
                    UserEngineLangValue = "Language=Pol";
                    break;
                case 9:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Por";
                    UserEngineLangValue = "Language=Por";
                    break;
                case 10:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Rus";
                    UserEngineLangValue = "Language=Rus";
                    break;
                default:
                    IniHandler.BmEngineData["Engine.Engine"]["Language"] = "Int";
                    UserEngineLangValue = "Language=Int";
                    break;
            }
            Nlog.Info("WriteBmEngineBasic - Set Language to {0}", UserEngineLangValue);

            // DX11 Features
            if (Program.MainWindow.Dx11Box.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["AllowD3D11"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["AllowD3D11"] = "False";
            }
            Nlog.Info("WriteBmEngineBasic - Set DX11 Features to {0}", IniHandler.BmEngineData["SystemSettings"]["AllowD3D11"]);


        }

        private void WriteBmEngineAdvanced()
        {
            // Anti-Aliasing
            switch (Program.MainWindow.AntiAliasingBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "1";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "1xMSAA";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "2";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "1xMSAA";
                    break;
                case 3:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "3";
                    IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"] = "1xMSAA";
                    break;
                case 4:
                    IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"] = "0";
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
            Nlog.Info("WriteBmEngineAdvanced - Set FXAA to {0} and MSAA to {1}", IniHandler.BmEngineData["SystemSettings"]["PostProcessAAType"], IniHandler.BmEngineData["SystemSettings"]["MultisampleMode"]);

            // Anisotropic Filtering
            IniHandler.BmEngineData["SystemSettings"]["MaxAnisotropy"] = Program.MainWindow.AnisoBox.SelectedIndex switch
            {
                1 => "8",
                2 => "16",
                _ => "4",
            };
            Nlog.Info("WriteBmEngineAdvanced - Set Anisotropic Filtering to {0}", IniHandler.BmEngineData["SystemSettings"]["MaxAnisotropy"]);

            // Ambient Occlusion
            if (Program.MainWindow.AmbientOcclusionBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["AmbientOcclusion"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["AmbientOcclusion"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Ambient Occlusion to {0}", IniHandler.BmEngineData["SystemSettings"]["AmbientOcclusion"]);

            // Tessellation Quality
            switch (Program.MainWindow.TessellationBox.SelectedIndex)
            {
                case 1:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "2048.000000";
                    IniHandler.BmEngineData["SystemSettings"]["WorldDisplacementMultiplier"] = "1.000000";
                    break;
                case 2:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "512.000000";
                    IniHandler.BmEngineData["SystemSettings"]["WorldDisplacementMultiplier"] = "1.000000";
                    break;
                case 3:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "256.000000";
                    IniHandler.BmEngineData["SystemSettings"]["WorldDisplacementMultiplier"] = "1.000000";
                    break;
                case 4:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "128.000000";
                    IniHandler.BmEngineData["SystemSettings"]["WorldDisplacementMultiplier"] = "1.100000";
                    break;
                case 5:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "64.000000";
                    IniHandler.BmEngineData["SystemSettings"]["WorldDisplacementMultiplier"] = "1.200000";
                    break;
                default:
                    IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"] = "0.000000";
                    IniHandler.BmEngineData["SystemSettings"]["WorldDisplacementMultiplier"] = "1.000000";
                    break;
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Tessellation Quality to {0}", IniHandler.BmEngineData["SystemSettings"]["TessellationAdaptivePixelsPerTriangle"]);

            // HBAO Intensity
            IniHandler.BmEngineData["SystemSettings"]["HBAOGamma"] = Program.MainWindow.HbaoBox.SelectedIndex switch
            {
                1 => "3.000000",
                2 => "5.000000",
                _ => "1.750000",
            };
            Nlog.Info("WriteBmEngineAdvanced - Set HBAO Intensity to {0}", IniHandler.BmEngineData["SystemSettings"]["HBAOGamma"]);

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
            Nlog.Info("WriteBmEngineAdvanced - Set Shadow Quality to {0} and Shadow Depth Bias to {1}", IniHandler.BmEngineData["SystemSettings"]["MaxShadowResolution"], IniHandler.BmEngineData["SystemSettings"]["ShadowDepthBias"]);

            // Depth of Field
            if (Program.MainWindow.DOFBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["DepthOfField"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["DepthOfField"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Depth of Field to {0}", IniHandler.BmEngineData["SystemSettings"]["DepthOfField"]);

            // Motion Blur
            if (Program.MainWindow.MotionBlurBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["MotionBlur"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["MotionBlur"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Motion Blur to {0}", IniHandler.BmEngineData["SystemSettings"]["MotionBlur"]);

            // Dynamic Lighting
            if (Program.MainWindow.DynLightBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["CompositeDynamicLights"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["CompositeDynamicLights"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Dynamic Lighting to {0}", IniHandler.BmEngineData["SystemSettings"]["CompositeDynamicLights"]);

            // Dynamic Shadows
            if (Program.MainWindow.DynShadowBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["DynamicShadows"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["DynamicShadows"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Dynamic Shadows to {0}", IniHandler.BmEngineData["SystemSettings"]["DynamicShadows"]);

            // Distortion
            if (Program.MainWindow.DistortionBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["Distortion"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["Distortion"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Distortion to {0}", IniHandler.BmEngineData["SystemSettings"]["Distortion"]);

            // Lens Flares
            if (Program.MainWindow.LensFlareBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["LensFlares"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["LensFlares"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Lens Flares to {0}", IniHandler.BmEngineData["SystemSettings"]["LensFlares"]);

            // Bloom
            if (Program.MainWindow.BloomBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["Bloom"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["Bloom"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Bloom to {0}", IniHandler.BmEngineData["SystemSettings"]["Bloom"]);

            // Light Rays
            if (Program.MainWindow.LightRayBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["bAllowLightShafts"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["bAllowLightShafts"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Light Rays to {0}", IniHandler.BmEngineData["SystemSettings"]["bAllowLightShafts"]);

            // Shadow Softness
            IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowLightRadius"] = Program.MainWindow.ShadowSoftnessBox.SelectedIndex switch
            {
                0 => "2.000000",
                1 => "4.000000",
                2 => "8.000000",
                4 => "32.000000",
                _ => "16.000000",
            };
            Nlog.Info("WriteBmEngineAdvanced - Set Shadow Softness to {0}", IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowLightRadius"]);

            // MVSS Coverage
            IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"] = Program.MainWindow.MVSSBox.SelectedIndex switch
            {
                1 => "0.750000",
                2 => "0.500000",
                3 => "0.250000",
                _ => "1.000000",
            };
            Nlog.Info("WriteBmEngineAdvanced - Set MVSS Coverage to {0}", IniHandler.BmEngineData["SystemSettings"]["MultiViewSoftShadowDepthBiasScale"]);

            // Shadow Draw Distance
            IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"] = Program.MainWindow.ShadowDrawDistBox.SelectedIndex switch
            {
                1 => "1.500000",
                2 => "2.000000",
                3 => "4.000000",
                _ => "1.000000",
            };
            Nlog.Info("WriteBmEngineAdvanced - Set Shadow Draw Distance to {0}", IniHandler.BmEngineData["SystemSettings"]["ShadowTexelsPerPixel"]);

            // PhysX
            IniHandler.BmEngineData["Engine.Engine"]["PhysXLevel"] = Program.MainWindow.PhysXBox.SelectedIndex switch
            {
                1 => "1",
                2 => "2",
                _ => "0",
            };
            Nlog.Info("WriteBmEngineAdvanced - Set PhysX to {0}", IniHandler.BmEngineData["Engine.Engine"]["PhysXLevel"]);

            // Poolsize
            IniHandler.BmEngineData["TextureStreaming"]["PoolSize"] = Program.MainWindow.PoolsizeBox.SelectedIndex switch
            {
                1 => "1024",
                2 => "2048",
                3 => "3072",
                4 => "4096",
                5 => "0",
                _ => "512",
            };
            Nlog.Info("WriteBmEngineAdvanced - Set Poolsize to {0}", IniHandler.BmEngineData["TextureStreaming"]["PoolSize"]);

            // Reflections
            if (Program.MainWindow.ReflectionBox.Checked)
            {
                IniHandler.BmEngineData["SystemSettings"]["Reflections"] = "True";
            }
            else
            {
                IniHandler.BmEngineData["SystemSettings"]["Reflections"] = "False";
            }
            Nlog.Info("WriteBmEngineAdvanced - Set Reflections to {0}", IniHandler.BmEngineData["SystemSettings"]["Reflections"]);
        }

        private void WriteColors()
        {
            // Saturation
            IniHandler.BmEngineData["Engine.Player"]["PP_DesaturationMultiplier"] = Program.IniHandler.ColorLauncherToIni(Program.MainWindow.SaturationTrackbar.Value);
            Nlog.Info("WriteColors - Set Saturation to {0}", IniHandler.BmEngineData["Engine.Player"]["PP_DesaturationMultiplier"]);

            // Highlights
            IniHandler.BmEngineData["Engine.Player"]["PP_HighlightsMultiplier"] = Program.IniHandler.ColorLauncherToIni(Program.MainWindow.HighlightsTrackbar.Value);
            Nlog.Info("WriteColors - Set Highlights to {0}", IniHandler.BmEngineData["Engine.Player"]["PP_HighlightsMultiplier"]);

            // Midtones
            IniHandler.BmEngineData["Engine.Player"]["PP_MidTonesMultiplier"] = Program.IniHandler.ColorLauncherToIni(Program.MainWindow.MidtonesTrackbar.Value);
            Nlog.Info("WriteColors - Set Midtones to {0}", IniHandler.BmEngineData["Engine.Player"]["PP_MidTonesMultiplier"]);

            // Shadows
            IniHandler.BmEngineData["Engine.Player"]["PP_ShadowsMultiplier"] = Program.IniHandler.ColorLauncherToIni(Program.MainWindow.ShadowsTrackbar.Value);
            Nlog.Info("WriteColors - Set Shadows to {0}", IniHandler.BmEngineData["Engine.Player"]["PP_ShadowsMultiplier"]);
        }

        private void WriteTextureGroupLines()
        {
            if (Program.IniHandler.TexPackEnabled.All(x => x))
            {
                //TEXTUREGROUP_Character
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_Character"] = Program.IniHandler.TexturePackEnabled[0];
                //TEXTUREGROUP_CharacterNormalMap
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_CharacterNormalMap"] = Program.IniHandler.TexturePackEnabled[1];
                //TEXTUREGROUP_World_Hi
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_World_Hi"] = Program.IniHandler.TexturePackEnabled[1];
                //TEXTUREGROUP_WorldNormalMap_Hi
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_WorldNormalMap_Hi"] = Program.IniHandler.TexturePackEnabled[1];

                if (Program.MainWindow.TexturePlusCheckBox.Enabled && Program.MainWindow.TexturePlusCheckBox.Checked)
                {
                    //TEXTUREGROUP_World
                    IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_World"] = Program.IniHandler.TexturePackEnabled[1];
                    //TEXTUREGROUP_WorldNormalMap
                    IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_WorldNormalMap"] = Program.IniHandler.TexturePackEnabled[1];
                }
                else
                {
                    //TEXTUREGROUP_World
                    IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_World"] = Program.IniHandler.TexturePackDefaults[2];
                    //TEXTUREGROUP_WorldNormalMap
                    IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_WorldNormalMap"] = Program.IniHandler.TexturePackDefaults[2];
                }
            }
            else
            {
                //TEXTUREGROUP_Character
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_Character"] = Program.IniHandler.TexturePackDefaults[0];
                //TEXTUREGROUP_CharacterNormalMap
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_CharacterNormalMap"] = Program.IniHandler.TexturePackDefaults[1];
                //TEXTUREGROUP_World_Hi
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_World_Hi"] = Program.IniHandler.TexturePackDefaults[1];
                //TEXTUREGROUP_WorldNormalMap_Hi
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_WorldNormalMap_Hi"] = Program.IniHandler.TexturePackDefaults[1];
                //TEXTUREGROUP_World
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_World"] = Program.IniHandler.TexturePackDefaults[2];
                //TEXTUREGROUP_WorldNormalMap
                IniHandler.BmEngineData["SystemSettings"]["TEXTUREGROUP_WorldNormalMap"] = Program.IniHandler.TexturePackDefaults[2];
            }
        }
    }
}
