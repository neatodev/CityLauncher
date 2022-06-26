namespace CityLauncher
{
    public partial class CityLauncher : Form
    {
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

        private void SkipIntroButton_Click(object sender, EventArgs e)
        {
            new FileHandler().RemoveIntroVideoFiles();
        }
    }
}