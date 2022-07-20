using NLog;
using System.Diagnostics;
using System.Globalization;

namespace CityLauncher
{
    public partial class CityLauncher : Form
    {
        private bool DisplaySetting = false;
        private bool ControlSetting = false;
        public bool DisplaySettingChanged
        {
            get
            {
                return DisplaySetting;
            }
            set
            {
                DisplaySetting = value;
                ApplySettingsButton.Enabled = true;
            }
        }
        public bool ControlSettingChanged
        {
            get
            {
                return ControlSetting;
            }
            set
            {
                ControlSetting = value;
                ApplySettingsButton.Enabled = true;
            }
        }

        private static readonly Logger Nlog = LogManager.GetCurrentClassLogger();

        public CityLauncher()
        {
            InitializeComponent();
        }

        private void Dx11Box_CheckedChanged(object sender, EventArgs e)
        {
            if (!Dx11Box.Checked)
            {
                MVSSBox.Enabled = false;
                HbaoBox.Enabled = false;
                TessellationBox.Enabled = false;
                ShadowSoftnessBox.Enabled = false;
            }
            else
            {
                MVSSBox.Enabled = true;
                HbaoBox.Enabled = true;
                TessellationBox.Enabled = true;
                ShadowSoftnessBox.Enabled = true;
            }
            DisplaySettingChanged = true;
        }

        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            if (DisplaySettingChanged)
            {
                new IniWriter().WriteAll();
            }
            if (ControlSettingChanged)
            {
                new InputWriter().WriteAll();
            }
        }

        private void SkipIntroBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void ManualModeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This option removes the 'read-only' flag of the configuration files, allowing for manual edits.\r\n" +
                "Starting the game through the launcher will re-add the 'read-only' flag, so make any desired edits before that.\r\n\r\n" +
                "Clicking 'Yes' will remove the flag, close the application and open your config directory.", @"Enable Manual Editing",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Program.FileHandler.BmEngine.IsReadOnly = false;
                Program.FileHandler.UserEngine.IsReadOnly = false;
                Program.FileHandler.BmInput.IsReadOnly = false;
                Process.Start("explorer.exe", Program.FileHandler.ConfigDirectoryPath);
                Application.Exit();
            }
        }

        private void MouseSensitivityTrackbar_Scroll(object sender, EventArgs e)
        {
            MouseSensitivityValueLabel.Text = MouseSensitivityTrackbar.Value.ToString();
            DisplaySettingChanged = true;
        }

        private void CustomFoV1Trackbar_Scroll(object sender, EventArgs e)
        {
            CustomFoV1ValueLabel.Text = CustomFoV1Trackbar.Value.ToString();
            DisplaySettingChanged = true;
        }

        private void CustomFoV2Trackbar_Scroll(object sender, EventArgs e)
        {
            CustomFoV2ValueLabel.Text = CustomFoV2Trackbar.Value.ToString();
            DisplaySettingChanged = true;
        }

        private void FwButton1_Click(object sender, EventArgs e)
        {
            new InputForm(FwButton1).ShowDialog();
        }

        private void BwButton1_Click(object sender, EventArgs e)
        {
            new InputForm(BwButton1).ShowDialog();

        }

        private void LeftButton1_Click(object sender, EventArgs e)
        {
            new InputForm(LeftButton1).ShowDialog();
        }

        private void RightButton1_Click(object sender, EventArgs e)
        {
            new InputForm(RightButton1).ShowDialog();
        }

        private void ACTButton1_Click(object sender, EventArgs e)
        {
            new InputForm(ACTButton1).ShowDialog();
        }

        private void PrevGadgetButton1_Click(object sender, EventArgs e)
        {
            new InputForm(PrevGadgetButton1).ShowDialog();
        }

        private void NextGadgetButton1_Click(object sender, EventArgs e)
        {
            new InputForm(NextGadgetButton1).ShowDialog();
        }

        private void UseGadgetStrikeButton1_Click(object sender, EventArgs e)
        {
            new InputForm(UseGadgetStrikeButton1).ShowDialog();
        }

        private void ZoomButton1_Click(object sender, EventArgs e)
        {
            new InputForm(ZoomButton1).ShowDialog();
        }

        private void CrouchButton1_Click(object sender, EventArgs e)
        {
            new InputForm(CrouchButton1).ShowDialog();
        }

        private void ToggleCrouchButton1_Click(object sender, EventArgs e)
        {
            new InputForm(ToggleCrouchButton1).ShowDialog();
        }

        private void RGUButton1_Click(object sender, EventArgs e)
        {
            new InputForm(RGUButton1).ShowDialog();
        }

        private void SCTButton1_Click(object sender, EventArgs e)
        {
            new InputForm(SCTButton1).ShowDialog();
        }

        private void GrappleButton1_Click(object sender, EventArgs e)
        {
            new InputForm(GrappleButton1).ShowDialog();

        }

        private void GadgetSecButton1_Click(object sender, EventArgs e)
        {
            new InputForm(GadgetSecButton1).ShowDialog();
        }

        private void DetectiveModeButton1_Click(object sender, EventArgs e)
        {
            new InputForm(DetectiveModeButton1).ShowDialog();
        }

        private void SCBSButton1_Click(object sender, EventArgs e)
        {
            new InputForm(SCBSButton1).ShowDialog();
        }

        private void MultiGroundTDButton1_Click(object sender, EventArgs e)
        {
            new InputForm(MultiGroundTDButton1).ShowDialog();
        }

        private void DisarmDestroyButton1_Click(object sender, EventArgs e)
        {
            new InputForm(DisarmDestroyButton1).ShowDialog();
        }

        private void CWDisarmFixButton1_Click(object sender, EventArgs e)
        {
            new InputForm(CWDisarmFixButton1).ShowDialog();
        }

        private void Gadget1Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget1Button1).ShowDialog();
        }

        private void Gadget2Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget2Button1).ShowDialog();
        }

        private void Gadget3Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget3Button1).ShowDialog();
        }

        private void Gadget4Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget4Button1).ShowDialog();
        }

        private void Gadget5Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget5Button1).ShowDialog();
        }

        private void Gadget6Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget6Button1).ShowDialog();
        }

        private void Gadget7Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget7Button1).ShowDialog();
        }

        private void Gadget8Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget8Button1).ShowDialog();
        }

        private void Gadget9Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget9Button1).ShowDialog();
        }

        private void Gadget10Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget10Button1).ShowDialog();
        }

        private void Gadget11Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget11Button1).ShowDialog();
        }

        private void Gadget12Button1_Click(object sender, EventArgs e)
        {
            new InputForm(Gadget12Button1).ShowDialog();
        }

        private void QFireGadget1Button1_Click(object sender, EventArgs e)
        {
            new InputForm(QFireGadget1Button1).ShowDialog();
        }

        private void QFireGadget2Button1_Click(object sender, EventArgs e)
        {
            new InputForm(QFireGadget2Button1).ShowDialog();
        }

        private void QFireGadget3Button1_Click(object sender, EventArgs e)
        {
            new InputForm(QFireGadget3Button1).ShowDialog();
        }

        private void QFireGadget4Button1_Click(object sender, EventArgs e)
        {
            new InputForm(QFireGadget4Button1).ShowDialog();
        }

        private void QFireGadget5Button1_Click(object sender, EventArgs e)
        {
            new InputForm(QFireGadget5Button1).ShowDialog();
        }

        private void ToggleHudButton_Click(object sender, EventArgs e)
        {
            new InputForm(ToggleHudButton).ShowDialog();
        }

        private void SpeedRunButton_Click(object sender, EventArgs e)
        {
            new InputForm(SpeedRunButton).ShowDialog();
        }

        private void CentreCameraButton_Click(object sender, EventArgs e)
        {
            new InputForm(CentreCameraButton).ShowDialog();
        }

        private void CustomFoV1Button_Click(object sender, EventArgs e)
        {
            new InputForm(CustomFoV1Button).ShowDialog();
        }

        private void CustomFoV2Button_Click(object sender, EventArgs e)
        {
            new InputForm(CustomFoV2Button).ShowDialog();
        }

        private void CustomCommandButton_Click(object sender, EventArgs e)
        {
            new InputForm(CustomCommandButton).ShowDialog();
        }

        private void ResetFoVButton_Click(object sender, EventArgs e)
        {
            new InputForm(ResetFoVButton).ShowDialog();
        }

        private void OpenConsoleButton_Click(object sender, EventArgs e)
        {
            new InputForm(OpenConsoleButton).ShowDialog();
        }

        private void ResetControlButton_Click(object sender, EventArgs e)
        {
            Program.InputHandler.ResetControls();
        }

        private void ResetDisplayButton_Click(object sender, EventArgs e)
        {
            Program.IniHandler.ResetDisplay();
        }

        private void CapeStunButton_Click(object sender, EventArgs e)
        {
            new InputForm(CapeStunButton).ShowDialog();
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            new InputForm(MapButton).ShowDialog();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            using (Process LaunchGame = new Process())
            {
                if (FileHandler.DetectGameExe())
                {
                    LaunchGame.StartInfo.FileName = "BatmanAC.exe";
                    LaunchGame.StartInfo.CreateNoWindow = true;
                    LaunchGame.Start();
                    Nlog.Info("StartGameButton_Click - Launching the game. Concluding logs at {0} on {1}.", DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Could not find 'BatmanAC.exe'. Is the Launcher in the correct folder?", "Error!", MessageBoxButtons.OK);
                }

            }
        }

        private void TempLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/neatodev/CityLauncher", UseShellExecute = true });
        }

        private void ResolutionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void VsyncBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void FullscreenBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void DetailModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void LanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void FrameCapTextBox_MaskChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void AmbientOcclusionBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void MotionBlurBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void DynShadowBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void DistortionBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void ReflectionBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void DOFBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void LightRayBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void DynLightBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void LensFlareBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void BloomBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void AntiAliasingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void MVSSBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void HbaoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void PhysXBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void PoolsizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void AnisoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void TessellationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void ShadowQualityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void ShadowDrawDistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void ShadowSoftnessBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySettingChanged = true;
        }

        private void VanillaPresetButton_Click(object sender, EventArgs e)
        {
            PresetHandler.SetVanilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PresetHandler.SetOptimized();
        }

        private void DarkKnightPresetButton_Click(object sender, EventArgs e)
        {
            PresetHandler.SetDarkKnight();
        }

        private void SaturationTrackbar_Scroll(object sender, EventArgs e)
        {
            SaturationValueLabel.Text = SaturationTrackbar.Value.ToString() + "%";
            DisplaySettingChanged = true;
        }

        private void HighlightsTrackbar_Scroll(object sender, EventArgs e)
        {
            HighlightsValueLabel.Text = HighlightsTrackbar.Value.ToString() + "%";
            DisplaySettingChanged = true;
        }

        private void MidtonesTrackbar_Scroll(object sender, EventArgs e)
        {
            MidtonesValueLabel.Text = MidtonesTrackbar.Value.ToString() + "%";
            DisplaySettingChanged = true;
        }

        private void ShadowsTrackbar_Scroll(object sender, EventArgs e)
        {
            ShadowsValueLabel.Text = ShadowsTrackbar.Value.ToString() + "%";
            DisplaySettingChanged = true;
        }
    }
}