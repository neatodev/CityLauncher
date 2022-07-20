namespace CityLauncher
{
    internal static class PresetHandler
    {
        public static void SetVanilla()
        {
            Program.MainWindow.Dx11Box.Checked = true;
            Program.MainWindow.DetailModeBox.SelectedIndex = 2;
            Program.MainWindow.AmbientOcclusionBox.Checked = true;
            Program.MainWindow.MotionBlurBox.Checked = true;
            Program.MainWindow.DynShadowBox.Checked = true;
            Program.MainWindow.DistortionBox.Checked = true;
            Program.MainWindow.ReflectionBox.Checked = true;
            Program.MainWindow.DOFBox.Checked = true;
            Program.MainWindow.LightRayBox.Checked = true;
            Program.MainWindow.LensFlareBox.Checked = true;
            Program.MainWindow.BloomBox.Checked = true;
            Program.MainWindow.AntiAliasingBox.SelectedIndex = 3;
            Program.MainWindow.MVSSBox.SelectedIndex = 0;
            Program.MainWindow.PhysXBox.SelectedIndex = 2;
            Program.MainWindow.PoolsizeBox.SelectedIndex = 0;
            Program.MainWindow.AnisoBox.SelectedIndex = 0;
            Program.MainWindow.TessellationBox.SelectedIndex = 3;
            Program.MainWindow.ShadowQualityBox.SelectedIndex = 0;
            Program.MainWindow.ShadowDrawDistBox.SelectedIndex = 0;
            Program.MainWindow.ShadowSoftnessBox.SelectedIndex = 3;
        }

        public static void SetOptimized()
        {
            Program.MainWindow.Dx11Box.Checked = true;
            Program.MainWindow.DetailModeBox.SelectedIndex = 2;
            Program.MainWindow.AmbientOcclusionBox.Checked = true;
            Program.MainWindow.MotionBlurBox.Checked = false;
            Program.MainWindow.DynShadowBox.Checked = true;
            Program.MainWindow.DistortionBox.Checked = true;
            Program.MainWindow.ReflectionBox.Checked = true;
            Program.MainWindow.DOFBox.Checked = true;
            Program.MainWindow.LightRayBox.Checked = true;
            Program.MainWindow.LensFlareBox.Checked = true;
            Program.MainWindow.BloomBox.Checked = true;
            Program.MainWindow.AntiAliasingBox.SelectedIndex = 3;
            Program.MainWindow.MVSSBox.SelectedIndex = 2;
            Program.MainWindow.PhysXBox.SelectedIndex = 1;
            Program.MainWindow.PoolsizeBox.SelectedIndex = 2;
            Program.MainWindow.AnisoBox.SelectedIndex = 2;
            Program.MainWindow.TessellationBox.SelectedIndex = 2;
            Program.MainWindow.ShadowQualityBox.SelectedIndex = 2;
            Program.MainWindow.ShadowDrawDistBox.SelectedIndex = 2;
            Program.MainWindow.ShadowSoftnessBox.SelectedIndex = 3;
        }

        public static void SetDarkKnight()
        {
            Program.MainWindow.Dx11Box.Checked = true;
            Program.MainWindow.DetailModeBox.SelectedIndex = 2;
            Program.MainWindow.AmbientOcclusionBox.Checked = true;
            Program.MainWindow.MotionBlurBox.Checked = false;
            Program.MainWindow.DynShadowBox.Checked = true;
            Program.MainWindow.DistortionBox.Checked = true;
            Program.MainWindow.ReflectionBox.Checked = true;
            Program.MainWindow.DOFBox.Checked = true;
            Program.MainWindow.LightRayBox.Checked = true;
            Program.MainWindow.LensFlareBox.Checked = true;
            Program.MainWindow.BloomBox.Checked = true;
            Program.MainWindow.AntiAliasingBox.SelectedIndex = 4;
            Program.MainWindow.MVSSBox.SelectedIndex = 3;
            Program.MainWindow.PhysXBox.SelectedIndex = 2;
            Program.MainWindow.PoolsizeBox.SelectedIndex = 4;
            Program.MainWindow.AnisoBox.SelectedIndex = 2;
            Program.MainWindow.TessellationBox.SelectedIndex = 4;
            Program.MainWindow.ShadowQualityBox.SelectedIndex = 3;
            Program.MainWindow.ShadowDrawDistBox.SelectedIndex = 3;
            Program.MainWindow.ShadowSoftnessBox.SelectedIndex = 3;
        }

        public static void SetColorDefault()
        {
            Program.MainWindow.SaturationTrackbar.Value = 100;
            Program.MainWindow.SaturationValueLabel.Text = "100%";
            Program.MainWindow.HighlightsTrackbar.Value = 100;
            Program.MainWindow.HighlightsValueLabel.Text = "100%";
            Program.MainWindow.MidtonesTrackbar.Value = 100;
            Program.MainWindow.MidtonesValueLabel.Text = "100%";
            Program.MainWindow.ShadowsTrackbar.Value = 100;
            Program.MainWindow.ShadowsValueLabel.Text = "100%";
        }

        public static void SetColorNoir()
        {
            Program.MainWindow.SaturationTrackbar.Value = 0;
            Program.MainWindow.SaturationValueLabel.Text = "0%";
            Program.MainWindow.HighlightsTrackbar.Value = 100;
            Program.MainWindow.HighlightsValueLabel.Text = "100%";
            Program.MainWindow.MidtonesTrackbar.Value = 100;
            Program.MainWindow.MidtonesValueLabel.Text = "100%";
            Program.MainWindow.ShadowsTrackbar.Value = 100;
            Program.MainWindow.ShadowsValueLabel.Text = "100%";
        }

        public static void SetColorVivid()
        {
            Program.MainWindow.SaturationTrackbar.Value = 120;
            Program.MainWindow.SaturationValueLabel.Text = "120%";
            Program.MainWindow.HighlightsTrackbar.Value = 100;
            Program.MainWindow.HighlightsValueLabel.Text = "100%";
            Program.MainWindow.MidtonesTrackbar.Value = 100;
            Program.MainWindow.MidtonesValueLabel.Text = "100%";
            Program.MainWindow.ShadowsTrackbar.Value = 100;
            Program.MainWindow.ShadowsValueLabel.Text = "100%";
        }

        public static void SetColorMuted()
        {
            Program.MainWindow.SaturationTrackbar.Value = 85;
            Program.MainWindow.SaturationValueLabel.Text = "85%";
            Program.MainWindow.HighlightsTrackbar.Value = 100;
            Program.MainWindow.HighlightsValueLabel.Text = "100%";
            Program.MainWindow.MidtonesTrackbar.Value = 100;
            Program.MainWindow.MidtonesValueLabel.Text = "100%";
            Program.MainWindow.ShadowsTrackbar.Value = 100;
            Program.MainWindow.ShadowsValueLabel.Text = "100%";
        }

        public static void SetColorHighContrast()
        {
            Program.MainWindow.SaturationTrackbar.Value = 105;
            Program.MainWindow.SaturationValueLabel.Text = "105%";
            Program.MainWindow.HighlightsTrackbar.Value = 105;
            Program.MainWindow.HighlightsValueLabel.Text = "105%";
            Program.MainWindow.MidtonesTrackbar.Value = 95;
            Program.MainWindow.MidtonesValueLabel.Text = "95%";
            Program.MainWindow.ShadowsTrackbar.Value = 100;
            Program.MainWindow.ShadowsValueLabel.Text = "100%";
        }

        public static void SetColorLowContrast()
        {
            Program.MainWindow.SaturationTrackbar.Value = 95;
            Program.MainWindow.SaturationValueLabel.Text = "95%";
            Program.MainWindow.HighlightsTrackbar.Value = 90;
            Program.MainWindow.HighlightsValueLabel.Text = "90%";
            Program.MainWindow.MidtonesTrackbar.Value = 105;
            Program.MainWindow.MidtonesValueLabel.Text = "105%";
            Program.MainWindow.ShadowsTrackbar.Value = 105;
            Program.MainWindow.ShadowsValueLabel.Text = "105%";
        }
    }
}
