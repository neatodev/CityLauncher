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
    }
}