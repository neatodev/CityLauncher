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
    }
}
