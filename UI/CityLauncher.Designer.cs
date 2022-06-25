namespace CityLauncher
{
    partial class CityLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DisplayTab = new System.Windows.Forms.TabPage();
            this.AdvancedDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.LensFlareBox = new System.Windows.Forms.CheckBox();
            this.LightRayBox = new System.Windows.Forms.CheckBox();
            this.BloomBox = new System.Windows.Forms.CheckBox();
            this.DistortionBox = new System.Windows.Forms.CheckBox();
            this.DynShadowBox = new System.Windows.Forms.CheckBox();
            this.DynLightBox = new System.Windows.Forms.CheckBox();
            this.MotionBlurBox = new System.Windows.Forms.CheckBox();
            this.DOFBox = new System.Windows.Forms.CheckBox();
            this.AmbientOcclusionBox = new System.Windows.Forms.CheckBox();
            this.PoolsizeBox = new System.Windows.Forms.ComboBox();
            this.PoolsizeLabel = new System.Windows.Forms.Label();
            this.PhysXBox = new System.Windows.Forms.ComboBox();
            this.ShadowDrawDistBox = new System.Windows.Forms.ComboBox();
            this.ShadowDrawLabel = new System.Windows.Forms.Label();
            this.MVSSBox = new System.Windows.Forms.ComboBox();
            this.ShadowQualityBox = new System.Windows.Forms.ComboBox();
            this.PhysXLabel = new System.Windows.Forms.Label();
            this.MVSSLabel = new System.Windows.Forms.Label();
            this.HbaoBox = new System.Windows.Forms.ComboBox();
            this.AntiAliasingBox = new System.Windows.Forms.ComboBox();
            this.AnisoBox = new System.Windows.Forms.ComboBox();
            this.TessellationBox = new System.Windows.Forms.ComboBox();
            this.TessellationLabel = new System.Windows.Forms.Label();
            this.HBAOLabel = new System.Windows.Forms.Label();
            this.AntiAliasingLabel = new System.Windows.Forms.Label();
            this.MaxShadowLabel = new System.Windows.Forms.Label();
            this.AnisotropyLabel = new System.Windows.Forms.Label();
            this.BasicDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.Dx11Box = new System.Windows.Forms.CheckBox();
            this.LanguageBox = new System.Windows.Forms.ComboBox();
            this.FrameCapTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ResolutionBox = new System.Windows.Forms.ComboBox();
            this.VsyncBox = new System.Windows.Forms.ComboBox();
            this.FullscreenBox = new System.Windows.Forms.ComboBox();
            this.DetailModeBox = new System.Windows.Forms.ComboBox();
            this.DetailModeLabel = new System.Windows.Forms.Label();
            this.VsyncLabel = new System.Windows.Forms.Label();
            this.FrameCapLabel = new System.Windows.Forms.Label();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.FullscreenLabel = new System.Windows.Forms.Label();
            this.ControlTab = new System.Windows.Forms.TabPage();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.ApplySettingsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.DisplayTab.SuspendLayout();
            this.AdvancedDisplayGroupBox.SuspendLayout();
            this.BasicDisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.DisplayTab);
            this.tabControl1.Controls.Add(this.ControlTab);
            this.tabControl1.Controls.Add(this.AboutTab);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // DisplayTab
            // 
            this.DisplayTab.Controls.Add(this.AdvancedDisplayGroupBox);
            this.DisplayTab.Controls.Add(this.BasicDisplayGroupBox);
            this.DisplayTab.Location = new System.Drawing.Point(4, 38);
            this.DisplayTab.Name = "DisplayTab";
            this.DisplayTab.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayTab.Size = new System.Drawing.Size(645, 491);
            this.DisplayTab.TabIndex = 0;
            this.DisplayTab.Text = "Display";
            this.DisplayTab.UseVisualStyleBackColor = true;
            // 
            // AdvancedDisplayGroupBox
            // 
            this.AdvancedDisplayGroupBox.AutoSize = true;
            this.AdvancedDisplayGroupBox.Controls.Add(this.LensFlareBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.LightRayBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.BloomBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DistortionBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DynShadowBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DynLightBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.MotionBlurBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DOFBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AmbientOcclusionBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.PoolsizeBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.PoolsizeLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.PhysXBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.ShadowDrawDistBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.ShadowDrawLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.MVSSBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.ShadowQualityBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.PhysXLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.MVSSLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.HbaoBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AntiAliasingBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AnisoBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.TessellationBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.TessellationLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.HBAOLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AntiAliasingLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.MaxShadowLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AnisotropyLabel);
            this.AdvancedDisplayGroupBox.Location = new System.Drawing.Point(3, 198);
            this.AdvancedDisplayGroupBox.Name = "AdvancedDisplayGroupBox";
            this.AdvancedDisplayGroupBox.Size = new System.Drawing.Size(639, 290);
            this.AdvancedDisplayGroupBox.TabIndex = 15;
            this.AdvancedDisplayGroupBox.TabStop = false;
            this.AdvancedDisplayGroupBox.Text = "Advanced";
            // 
            // LensFlareBox
            // 
            this.LensFlareBox.AutoSize = true;
            this.LensFlareBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LensFlareBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LensFlareBox.Location = new System.Drawing.Point(432, 61);
            this.LensFlareBox.Name = "LensFlareBox";
            this.LensFlareBox.Size = new System.Drawing.Size(101, 23);
            this.LensFlareBox.TabIndex = 49;
            this.LensFlareBox.Text = "Lens Flares";
            this.LensFlareBox.UseVisualStyleBackColor = true;
            // 
            // LightRayBox
            // 
            this.LightRayBox.AutoSize = true;
            this.LightRayBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LightRayBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LightRayBox.Location = new System.Drawing.Point(180, 61);
            this.LightRayBox.Name = "LightRayBox";
            this.LightRayBox.Size = new System.Drawing.Size(95, 23);
            this.LightRayBox.TabIndex = 48;
            this.LightRayBox.Text = "Light Rays";
            this.LightRayBox.UseVisualStyleBackColor = true;
            // 
            // BloomBox
            // 
            this.BloomBox.AutoSize = true;
            this.BloomBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BloomBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloomBox.Location = new System.Drawing.Point(539, 32);
            this.BloomBox.Name = "BloomBox";
            this.BloomBox.Size = new System.Drawing.Size(69, 23);
            this.BloomBox.TabIndex = 47;
            this.BloomBox.Text = "Bloom";
            this.BloomBox.UseVisualStyleBackColor = true;
            // 
            // DistortionBox
            // 
            this.DistortionBox.AutoSize = true;
            this.DistortionBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DistortionBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DistortionBox.Location = new System.Drawing.Point(441, 32);
            this.DistortionBox.Name = "DistortionBox";
            this.DistortionBox.Size = new System.Drawing.Size(92, 23);
            this.DistortionBox.TabIndex = 46;
            this.DistortionBox.Text = "Distortion";
            this.DistortionBox.UseVisualStyleBackColor = true;
            // 
            // DynShadowBox
            // 
            this.DynShadowBox.AutoSize = true;
            this.DynShadowBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DynShadowBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DynShadowBox.Location = new System.Drawing.Point(281, 32);
            this.DynShadowBox.Name = "DynShadowBox";
            this.DynShadowBox.Size = new System.Drawing.Size(145, 23);
            this.DynShadowBox.TabIndex = 45;
            this.DynShadowBox.Text = "Dynamic Shadows";
            this.DynShadowBox.UseVisualStyleBackColor = true;
            // 
            // DynLightBox
            // 
            this.DynLightBox.AutoSize = true;
            this.DynLightBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DynLightBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DynLightBox.Location = new System.Drawing.Point(286, 61);
            this.DynLightBox.Name = "DynLightBox";
            this.DynLightBox.Size = new System.Drawing.Size(140, 23);
            this.DynLightBox.TabIndex = 44;
            this.DynLightBox.Text = "Dynamic Lighting";
            this.DynLightBox.UseVisualStyleBackColor = true;
            // 
            // MotionBlurBox
            // 
            this.MotionBlurBox.AutoSize = true;
            this.MotionBlurBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MotionBlurBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MotionBlurBox.Location = new System.Drawing.Point(171, 32);
            this.MotionBlurBox.Name = "MotionBlurBox";
            this.MotionBlurBox.Size = new System.Drawing.Size(104, 23);
            this.MotionBlurBox.TabIndex = 43;
            this.MotionBlurBox.Text = "Motion Blur";
            this.MotionBlurBox.UseVisualStyleBackColor = true;
            // 
            // DOFBox
            // 
            this.DOFBox.AutoSize = true;
            this.DOFBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DOFBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOFBox.Location = new System.Drawing.Point(46, 61);
            this.DOFBox.Name = "DOFBox";
            this.DOFBox.Size = new System.Drawing.Size(119, 23);
            this.DOFBox.TabIndex = 42;
            this.DOFBox.Text = "Depth of Field";
            this.DOFBox.UseVisualStyleBackColor = true;
            // 
            // AmbientOcclusionBox
            // 
            this.AmbientOcclusionBox.AutoSize = true;
            this.AmbientOcclusionBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AmbientOcclusionBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmbientOcclusionBox.Location = new System.Drawing.Point(15, 32);
            this.AmbientOcclusionBox.Name = "AmbientOcclusionBox";
            this.AmbientOcclusionBox.Size = new System.Drawing.Size(150, 23);
            this.AmbientOcclusionBox.TabIndex = 41;
            this.AmbientOcclusionBox.Text = "Ambient Occlusion";
            this.AmbientOcclusionBox.UseVisualStyleBackColor = true;
            // 
            // PoolsizeBox
            // 
            this.PoolsizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoolsizeBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PoolsizeBox.FormattingEnabled = true;
            this.PoolsizeBox.Items.AddRange(new object[] {
            "512 (Default)",
            "1024",
            "2048",
            "3072",
            "4096",
            "Infinite"});
            this.PoolsizeBox.Location = new System.Drawing.Point(119, 231);
            this.PoolsizeBox.Name = "PoolsizeBox";
            this.PoolsizeBox.Size = new System.Drawing.Size(152, 27);
            this.PoolsizeBox.TabIndex = 40;
            // 
            // PoolsizeLabel
            // 
            this.PoolsizeLabel.AutoSize = true;
            this.PoolsizeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PoolsizeLabel.Location = new System.Drawing.Point(51, 234);
            this.PoolsizeLabel.Name = "PoolsizeLabel";
            this.PoolsizeLabel.Size = new System.Drawing.Size(62, 19);
            this.PoolsizeLabel.TabIndex = 39;
            this.PoolsizeLabel.Text = "Poolsize";
            // 
            // PhysXBox
            // 
            this.PhysXBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhysXBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhysXBox.FormattingEnabled = true;
            this.PhysXBox.Items.AddRange(new object[] {
            "Off",
            "Medium",
            "High"});
            this.PhysXBox.Location = new System.Drawing.Point(119, 198);
            this.PhysXBox.Name = "PhysXBox";
            this.PhysXBox.Size = new System.Drawing.Size(152, 27);
            this.PhysXBox.TabIndex = 38;
            // 
            // ShadowDrawDistBox
            // 
            this.ShadowDrawDistBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadowDrawDistBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShadowDrawDistBox.FormattingEnabled = true;
            this.ShadowDrawDistBox.Items.AddRange(new object[] {
            "Low (Default)",
            "Medium",
            "High",
            "Very High"});
            this.ShadowDrawDistBox.Location = new System.Drawing.Point(481, 198);
            this.ShadowDrawDistBox.Name = "ShadowDrawDistBox";
            this.ShadowDrawDistBox.Size = new System.Drawing.Size(152, 27);
            this.ShadowDrawDistBox.TabIndex = 37;
            // 
            // ShadowDrawLabel
            // 
            this.ShadowDrawLabel.AutoSize = true;
            this.ShadowDrawLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShadowDrawLabel.Location = new System.Drawing.Point(317, 201);
            this.ShadowDrawLabel.Name = "ShadowDrawLabel";
            this.ShadowDrawLabel.Size = new System.Drawing.Size(158, 19);
            this.ShadowDrawLabel.TabIndex = 36;
            this.ShadowDrawLabel.Text = "Shadow Draw Distance";
            // 
            // MVSSBox
            // 
            this.MVSSBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MVSSBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MVSSBox.FormattingEnabled = true;
            this.MVSSBox.Items.AddRange(new object[] {
            "Low (Default)",
            "Medium",
            "High",
            "Very High"});
            this.MVSSBox.Location = new System.Drawing.Point(119, 132);
            this.MVSSBox.Name = "MVSSBox";
            this.MVSSBox.Size = new System.Drawing.Size(152, 27);
            this.MVSSBox.TabIndex = 35;
            // 
            // ShadowQualityBox
            // 
            this.ShadowQualityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadowQualityBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShadowQualityBox.FormattingEnabled = true;
            this.ShadowQualityBox.Items.AddRange(new object[] {
            "Low (Default)",
            "Medium",
            "High",
            "Very High"});
            this.ShadowQualityBox.Location = new System.Drawing.Point(481, 165);
            this.ShadowQualityBox.Name = "ShadowQualityBox";
            this.ShadowQualityBox.Size = new System.Drawing.Size(152, 27);
            this.ShadowQualityBox.TabIndex = 26;
            // 
            // PhysXLabel
            // 
            this.PhysXLabel.AutoSize = true;
            this.PhysXLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhysXLabel.Location = new System.Drawing.Point(21, 201);
            this.PhysXLabel.Name = "PhysXLabel";
            this.PhysXLabel.Size = new System.Drawing.Size(92, 19);
            this.PhysXLabel.TabIndex = 24;
            this.PhysXLabel.Text = "Nvidia PhysX";
            // 
            // MVSSLabel
            // 
            this.MVSSLabel.AutoSize = true;
            this.MVSSLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MVSSLabel.Location = new System.Drawing.Point(3, 135);
            this.MVSSLabel.Name = "MVSSLabel";
            this.MVSSLabel.Size = new System.Drawing.Size(110, 19);
            this.MVSSLabel.TabIndex = 23;
            this.MVSSLabel.Text = "MVSS Coverage";
            // 
            // HbaoBox
            // 
            this.HbaoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HbaoBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HbaoBox.FormattingEnabled = true;
            this.HbaoBox.Items.AddRange(new object[] {
            "Subtle",
            "Medium (Default)",
            "Intense"});
            this.HbaoBox.Location = new System.Drawing.Point(119, 165);
            this.HbaoBox.Name = "HbaoBox";
            this.HbaoBox.Size = new System.Drawing.Size(152, 27);
            this.HbaoBox.TabIndex = 14;
            // 
            // AntiAliasingBox
            // 
            this.AntiAliasingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AntiAliasingBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AntiAliasingBox.FormattingEnabled = true;
            this.AntiAliasingBox.Items.AddRange(new object[] {
            "Off",
            "FXAA Low",
            "FXAA Medium",
            "FXAA High",
            "2x MSAA",
            "4x MSAA",
            "8x MSAA"});
            this.AntiAliasingBox.Location = new System.Drawing.Point(119, 99);
            this.AntiAliasingBox.Name = "AntiAliasingBox";
            this.AntiAliasingBox.Size = new System.Drawing.Size(152, 27);
            this.AntiAliasingBox.TabIndex = 9;
            // 
            // AnisoBox
            // 
            this.AnisoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnisoBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnisoBox.FormattingEnabled = true;
            this.AnisoBox.Items.AddRange(new object[] {
            "4x",
            "8x",
            "16x"});
            this.AnisoBox.Location = new System.Drawing.Point(481, 99);
            this.AnisoBox.Name = "AnisoBox";
            this.AnisoBox.Size = new System.Drawing.Size(152, 27);
            this.AnisoBox.TabIndex = 8;
            // 
            // TessellationBox
            // 
            this.TessellationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TessellationBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TessellationBox.FormattingEnabled = true;
            this.TessellationBox.Items.AddRange(new object[] {
            "Off",
            "Normal",
            "High (Default)",
            "Very High",
            "Extreme"});
            this.TessellationBox.Location = new System.Drawing.Point(481, 132);
            this.TessellationBox.Name = "TessellationBox";
            this.TessellationBox.Size = new System.Drawing.Size(152, 27);
            this.TessellationBox.TabIndex = 10;
            // 
            // TessellationLabel
            // 
            this.TessellationLabel.AutoSize = true;
            this.TessellationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TessellationLabel.Location = new System.Drawing.Point(337, 135);
            this.TessellationLabel.Name = "TessellationLabel";
            this.TessellationLabel.Size = new System.Drawing.Size(138, 19);
            this.TessellationLabel.TabIndex = 4;
            this.TessellationLabel.Text = "Tessellation Quality";
            // 
            // HBAOLabel
            // 
            this.HBAOLabel.AutoSize = true;
            this.HBAOLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HBAOLabel.Location = new System.Drawing.Point(5, 168);
            this.HBAOLabel.Name = "HBAOLabel";
            this.HBAOLabel.Size = new System.Drawing.Size(108, 19);
            this.HBAOLabel.TabIndex = 2;
            this.HBAOLabel.Text = "HBAO Intensity";
            // 
            // AntiAliasingLabel
            // 
            this.AntiAliasingLabel.AutoSize = true;
            this.AntiAliasingLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AntiAliasingLabel.Location = new System.Drawing.Point(21, 102);
            this.AntiAliasingLabel.Name = "AntiAliasingLabel";
            this.AntiAliasingLabel.Size = new System.Drawing.Size(92, 19);
            this.AntiAliasingLabel.TabIndex = 1;
            this.AntiAliasingLabel.Text = "Anti-Aliasing";
            // 
            // MaxShadowLabel
            // 
            this.MaxShadowLabel.AutoSize = true;
            this.MaxShadowLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxShadowLabel.Location = new System.Drawing.Point(365, 168);
            this.MaxShadowLabel.Name = "MaxShadowLabel";
            this.MaxShadowLabel.Size = new System.Drawing.Size(110, 19);
            this.MaxShadowLabel.TabIndex = 5;
            this.MaxShadowLabel.Text = "Shadow Quality";
            // 
            // AnisotropyLabel
            // 
            this.AnisotropyLabel.AutoSize = true;
            this.AnisotropyLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnisotropyLabel.Location = new System.Drawing.Point(336, 102);
            this.AnisotropyLabel.Name = "AnisotropyLabel";
            this.AnisotropyLabel.Size = new System.Drawing.Size(139, 19);
            this.AnisotropyLabel.TabIndex = 0;
            this.AnisotropyLabel.Text = "Anisotropic Filtering";
            // 
            // BasicDisplayGroupBox
            // 
            this.BasicDisplayGroupBox.AutoSize = true;
            this.BasicDisplayGroupBox.Controls.Add(this.Dx11Box);
            this.BasicDisplayGroupBox.Controls.Add(this.LanguageBox);
            this.BasicDisplayGroupBox.Controls.Add(this.FrameCapTextBox);
            this.BasicDisplayGroupBox.Controls.Add(this.ResolutionBox);
            this.BasicDisplayGroupBox.Controls.Add(this.VsyncBox);
            this.BasicDisplayGroupBox.Controls.Add(this.FullscreenBox);
            this.BasicDisplayGroupBox.Controls.Add(this.DetailModeBox);
            this.BasicDisplayGroupBox.Controls.Add(this.DetailModeLabel);
            this.BasicDisplayGroupBox.Controls.Add(this.VsyncLabel);
            this.BasicDisplayGroupBox.Controls.Add(this.FrameCapLabel);
            this.BasicDisplayGroupBox.Controls.Add(this.ResolutionLabel);
            this.BasicDisplayGroupBox.Controls.Add(this.LanguageLabel);
            this.BasicDisplayGroupBox.Controls.Add(this.FullscreenLabel);
            this.BasicDisplayGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BasicDisplayGroupBox.Name = "BasicDisplayGroupBox";
            this.BasicDisplayGroupBox.Size = new System.Drawing.Size(639, 193);
            this.BasicDisplayGroupBox.TabIndex = 13;
            this.BasicDisplayGroupBox.TabStop = false;
            this.BasicDisplayGroupBox.Text = "Basic";
            // 
            // Dx11Box
            // 
            this.Dx11Box.AutoSize = true;
            this.Dx11Box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dx11Box.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dx11Box.Location = new System.Drawing.Point(91, 134);
            this.Dx11Box.Name = "Dx11Box";
            this.Dx11Box.Size = new System.Drawing.Size(180, 27);
            this.Dx11Box.TabIndex = 15;
            this.Dx11Box.Text = "DirectX 11 Features";
            this.Dx11Box.UseVisualStyleBackColor = true;
            this.Dx11Box.CheckedChanged += new System.EventHandler(this.Dx11Box_CheckedChanged);
            // 
            // LanguageBox
            // 
            this.LanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageBox.FormattingEnabled = true;
            this.LanguageBox.Items.AddRange(new object[] {
            "English",
            "Deutsch",
            "Español (México)",
            "Español (España)",
            "Français",
            "Italiano",
            "やまと",
            "한국인",
            "Polskie",
            "Português",
            "Русский"});
            this.LanguageBox.Location = new System.Drawing.Point(481, 101);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(152, 27);
            this.LanguageBox.TabIndex = 14;
            // 
            // FrameCapTextBox
            // 
            this.FrameCapTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrameCapTextBox.Location = new System.Drawing.Point(240, 101);
            this.FrameCapTextBox.Mask = "000";
            this.FrameCapTextBox.Name = "FrameCapTextBox";
            this.FrameCapTextBox.PromptChar = ' ';
            this.FrameCapTextBox.Size = new System.Drawing.Size(31, 27);
            this.FrameCapTextBox.TabIndex = 11;
            this.FrameCapTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FrameCapTextBox.ValidatingType = typeof(int);
            // 
            // ResolutionBox
            // 
            this.ResolutionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionBox.FormattingEnabled = true;
            this.ResolutionBox.Location = new System.Drawing.Point(119, 35);
            this.ResolutionBox.Name = "ResolutionBox";
            this.ResolutionBox.Size = new System.Drawing.Size(152, 27);
            this.ResolutionBox.TabIndex = 7;
            // 
            // VsyncBox
            // 
            this.VsyncBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VsyncBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VsyncBox.FormattingEnabled = true;
            this.VsyncBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.VsyncBox.Location = new System.Drawing.Point(119, 68);
            this.VsyncBox.Name = "VsyncBox";
            this.VsyncBox.Size = new System.Drawing.Size(152, 27);
            this.VsyncBox.TabIndex = 9;
            // 
            // FullscreenBox
            // 
            this.FullscreenBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FullscreenBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullscreenBox.FormattingEnabled = true;
            this.FullscreenBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.FullscreenBox.Location = new System.Drawing.Point(481, 35);
            this.FullscreenBox.Name = "FullscreenBox";
            this.FullscreenBox.Size = new System.Drawing.Size(152, 27);
            this.FullscreenBox.TabIndex = 8;
            // 
            // DetailModeBox
            // 
            this.DetailModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DetailModeBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailModeBox.FormattingEnabled = true;
            this.DetailModeBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.DetailModeBox.Location = new System.Drawing.Point(481, 68);
            this.DetailModeBox.Name = "DetailModeBox";
            this.DetailModeBox.Size = new System.Drawing.Size(152, 27);
            this.DetailModeBox.TabIndex = 10;
            // 
            // DetailModeLabel
            // 
            this.DetailModeLabel.AutoSize = true;
            this.DetailModeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailModeLabel.Location = new System.Drawing.Point(367, 71);
            this.DetailModeLabel.Name = "DetailModeLabel";
            this.DetailModeLabel.Size = new System.Drawing.Size(108, 19);
            this.DetailModeLabel.TabIndex = 4;
            this.DetailModeLabel.Text = "Texture Quality";
            // 
            // VsyncLabel
            // 
            this.VsyncLabel.AutoSize = true;
            this.VsyncLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VsyncLabel.Location = new System.Drawing.Point(22, 71);
            this.VsyncLabel.Name = "VsyncLabel";
            this.VsyncLabel.Size = new System.Drawing.Size(91, 19);
            this.VsyncLabel.TabIndex = 3;
            this.VsyncLabel.Text = "Vertical Sync";
            // 
            // FrameCapLabel
            // 
            this.FrameCapLabel.AutoSize = true;
            this.FrameCapLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrameCapLabel.Location = new System.Drawing.Point(123, 104);
            this.FrameCapLabel.Name = "FrameCapLabel";
            this.FrameCapLabel.Size = new System.Drawing.Size(111, 19);
            this.FrameCapLabel.TabIndex = 2;
            this.FrameCapLabel.Text = "Framerate Limit";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionLabel.Location = new System.Drawing.Point(35, 38);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(78, 19);
            this.ResolutionLabel.TabIndex = 1;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageLabel.Location = new System.Drawing.Point(403, 104);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(72, 19);
            this.LanguageLabel.TabIndex = 5;
            this.LanguageLabel.Text = "Language";
            // 
            // FullscreenLabel
            // 
            this.FullscreenLabel.AutoSize = true;
            this.FullscreenLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullscreenLabel.Location = new System.Drawing.Point(400, 38);
            this.FullscreenLabel.Name = "FullscreenLabel";
            this.FullscreenLabel.Size = new System.Drawing.Size(75, 19);
            this.FullscreenLabel.TabIndex = 0;
            this.FullscreenLabel.Text = "Fullscreen";
            // 
            // ControlTab
            // 
            this.ControlTab.Location = new System.Drawing.Point(4, 38);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.ControlTab.Size = new System.Drawing.Size(645, 491);
            this.ControlTab.TabIndex = 1;
            this.ControlTab.Text = "Controls";
            this.ControlTab.UseVisualStyleBackColor = true;
            // 
            // AboutTab
            // 
            this.AboutTab.Location = new System.Drawing.Point(4, 38);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(645, 491);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // ApplySettingsButton
            // 
            this.ApplySettingsButton.Location = new System.Drawing.Point(261, 575);
            this.ApplySettingsButton.Name = "ApplySettingsButton";
            this.ApplySettingsButton.Size = new System.Drawing.Size(178, 37);
            this.ApplySettingsButton.TabIndex = 1;
            this.ApplySettingsButton.Text = "Apply Settings";
            this.ApplySettingsButton.UseVisualStyleBackColor = true;
            this.ApplySettingsButton.Click += new System.EventHandler(this.ApplySettingsButton_Click);
            // 
            // CityLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(671, 752);
            this.Controls.Add(this.ApplySettingsButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CityLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batman: Arkham City - Advanced Launcher";
            this.tabControl1.ResumeLayout(false);
            this.DisplayTab.ResumeLayout(false);
            this.DisplayTab.PerformLayout();
            this.AdvancedDisplayGroupBox.ResumeLayout(false);
            this.AdvancedDisplayGroupBox.PerformLayout();
            this.BasicDisplayGroupBox.ResumeLayout(false);
            this.BasicDisplayGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage DisplayTab;
        private TabPage ControlTab;
        private TabPage AboutTab;
        private Label ResolutionLabel;
        private Label FullscreenLabel;
        private Label DetailModeLabel;
        private Label VsyncLabel;
        private Label FrameCapLabel;
        private Label LanguageLabel;
        public ComboBox FullscreenBox;
        public ComboBox ResolutionBox;
        public ComboBox VsyncBox;
        public ComboBox DetailModeBox;
        public MaskedTextBox FrameCapTextBox;
        private GroupBox BasicDisplayGroupBox;
        public ComboBox LanguageBox;
        private GroupBox AdvancedDisplayGroupBox;
        public ComboBox HbaoBox;
        public ComboBox AntiAliasingBox;
        public ComboBox AnisoBox;
        public ComboBox TessellationBox;
        private Label TessellationLabel;
        private Label HBAOLabel;
        private Label AntiAliasingLabel;
        private Label MaxShadowLabel;
        private Label AnisotropyLabel;
        private Label MVSSLabel;
        public ComboBox ShadowQualityBox;
        public ComboBox MVSSBox;
        public ComboBox ShadowDrawDistBox;
        private Label ShadowDrawLabel;
        private Label PoolsizeLabel;
        public ComboBox PoolsizeBox;
        public CheckBox AmbientOcclusionBox;
        public CheckBox DOFBox;
        public CheckBox MotionBlurBox;
        public CheckBox DynLightBox;
        public CheckBox DynShadowBox;
        public CheckBox DistortionBox;
        public CheckBox BloomBox;
        public CheckBox LightRayBox;
        public CheckBox LensFlareBox;
        public ComboBox PhysXBox;
        private Label PhysXLabel;
        public CheckBox Dx11Box;
        private Button ApplySettingsButton;
    }
}