namespace CityLauncher
{
    public partial class CityLauncher : Form
    {
        public bool SettingChanged = false;
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
            }
            else
            {
                MVSSBox.Enabled = true;
                HbaoBox.Enabled = true;
                TessellationBox.Enabled = true;
            }
        }

        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            new IniWriter().WriteAll();
            new InputWriter().WriteControls();
        }

        private void SkipIntroBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingChanged = true;
        }

        private void ManualModeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This option removes the 'read-only' flag of the configuration files, allowing for manual edits.\r\n" +
                "Starting the game through the launcher will re-add the 'read-only' flag, so make any desired edits before that.\r\n\r\n" +
                "Do you wish to continue?", @"Enable Manual Editing",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Program.FileHandler.BmEngine.IsReadOnly = false;
                Program.FileHandler.UserEngine.IsReadOnly = false;
                Program.FileHandler.BmInput.IsReadOnly = false;
                MessageBox.Show("Manual Editing Enabled", @"Success!");
            }
        }

        private void MouseSensitivityTrackbar_Scroll(object sender, EventArgs e)
        {
            MouseSensitivityValueLabel.Text = MouseSensitivityTrackbar.Value.ToString();
        }

        private void CustomFoV1Trackbar_Scroll(object sender, EventArgs e)
        {
            CustomFoV1ValueLabel.Text = CustomFoV1Trackbar.Value.ToString();
        }

        private void CustomFoV2Trackbar_Scroll(object sender, EventArgs e)
        {
            CustomFoV2ValueLabel.Text = CustomFoV2Trackbar.Value.ToString();
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
    }
}