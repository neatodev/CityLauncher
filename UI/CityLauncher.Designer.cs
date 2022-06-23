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
            this.PhysXLabel = new System.Windows.Forms.Label();
            this.MVSSLabel = new System.Windows.Forms.Label();
            this.LensFlareLabel = new System.Windows.Forms.Label();
            this.DistortionLabel = new System.Windows.Forms.Label();
            this.BloomLabel = new System.Windows.Forms.Label();
            this.LightRayLabel = new System.Windows.Forms.Label();
            this.MotionBlurLabel = new System.Windows.Forms.Label();
            this.DOFLabel = new System.Windows.Forms.Label();
            this.DynLightLabel = new System.Windows.Forms.Label();
            this.DynShadowLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AmbientOcclusionBox = new System.Windows.Forms.MaskedTextBox();
            this.AntiAliasingBox = new System.Windows.Forms.ComboBox();
            this.AnisoBox = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.TessellationLabel = new System.Windows.Forms.Label();
            this.AmbientOcclusionLabel = new System.Windows.Forms.Label();
            this.HBAOLabel = new System.Windows.Forms.Label();
            this.AntiAliasingLabel = new System.Windows.Forms.Label();
            this.MaxShadowLabel = new System.Windows.Forms.Label();
            this.AnisotropyLabel = new System.Windows.Forms.Label();
            this.Dx11Box = new System.Windows.Forms.ComboBox();
            this.ResolutionBox = new System.Windows.Forms.ComboBox();
            this.Dx11FeatureLabel = new System.Windows.Forms.Label();
            this.BasicDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.LanguageBox = new System.Windows.Forms.ComboBox();
            this.FrameCapTextBox = new System.Windows.Forms.MaskedTextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // DisplayTab
            // 
            this.DisplayTab.Controls.Add(this.AdvancedDisplayGroupBox);
            this.DisplayTab.Controls.Add(this.Dx11Box);
            this.DisplayTab.Controls.Add(this.ResolutionBox);
            this.DisplayTab.Controls.Add(this.Dx11FeatureLabel);
            this.DisplayTab.Controls.Add(this.BasicDisplayGroupBox);
            this.DisplayTab.Location = new System.Drawing.Point(4, 38);
            this.DisplayTab.Name = "DisplayTab";
            this.DisplayTab.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayTab.Size = new System.Drawing.Size(655, 581);
            this.DisplayTab.TabIndex = 0;
            this.DisplayTab.Text = "Display";
            this.DisplayTab.UseVisualStyleBackColor = true;
            // 
            // AdvancedDisplayGroupBox
            // 
            this.AdvancedDisplayGroupBox.AutoSize = true;
            this.AdvancedDisplayGroupBox.Controls.Add(this.PhysXLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.MVSSLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.LensFlareLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DistortionLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.BloomLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.LightRayLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.MotionBlurLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DOFLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DynLightLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.DynShadowLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.comboBox1);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AmbientOcclusionBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AntiAliasingBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AnisoBox);
            this.AdvancedDisplayGroupBox.Controls.Add(this.comboBox4);
            this.AdvancedDisplayGroupBox.Controls.Add(this.TessellationLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AmbientOcclusionLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.HBAOLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AntiAliasingLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.MaxShadowLabel);
            this.AdvancedDisplayGroupBox.Controls.Add(this.AnisotropyLabel);
            this.AdvancedDisplayGroupBox.Location = new System.Drawing.Point(9, 200);
            this.AdvancedDisplayGroupBox.Name = "AdvancedDisplayGroupBox";
            this.AdvancedDisplayGroupBox.Size = new System.Drawing.Size(644, 378);
            this.AdvancedDisplayGroupBox.TabIndex = 15;
            this.AdvancedDisplayGroupBox.TabStop = false;
            this.AdvancedDisplayGroupBox.Text = "Advanced";
            // 
            // PhysXLabel
            // 
            this.PhysXLabel.AutoSize = true;
            this.PhysXLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhysXLabel.Location = new System.Drawing.Point(307, 314);
            this.PhysXLabel.Name = "PhysXLabel";
            this.PhysXLabel.Size = new System.Drawing.Size(109, 23);
            this.PhysXLabel.TabIndex = 24;
            this.PhysXLabel.Text = "Nvidia PhysX";
            // 
            // MVSSLabel
            // 
            this.MVSSLabel.AutoSize = true;
            this.MVSSLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MVSSLabel.Location = new System.Drawing.Point(31, 314);
            this.MVSSLabel.Name = "MVSSLabel";
            this.MVSSLabel.Size = new System.Drawing.Size(131, 23);
            this.MVSSLabel.TabIndex = 23;
            this.MVSSLabel.Text = "MVSS Coverage";
            // 
            // LensFlareLabel
            // 
            this.LensFlareLabel.AutoSize = true;
            this.LensFlareLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LensFlareLabel.Location = new System.Drawing.Point(343, 229);
            this.LensFlareLabel.Name = "LensFlareLabel";
            this.LensFlareLabel.Size = new System.Drawing.Size(95, 23);
            this.LensFlareLabel.TabIndex = 21;
            this.LensFlareLabel.Text = "Lens Flares";
            // 
            // DistortionLabel
            // 
            this.DistortionLabel.AutoSize = true;
            this.DistortionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DistortionLabel.Location = new System.Drawing.Point(31, 229);
            this.DistortionLabel.Name = "DistortionLabel";
            this.DistortionLabel.Size = new System.Drawing.Size(88, 23);
            this.DistortionLabel.TabIndex = 20;
            this.DistortionLabel.Text = "Distortion";
            // 
            // BloomLabel
            // 
            this.BloomLabel.AutoSize = true;
            this.BloomLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloomLabel.Location = new System.Drawing.Point(16, 266);
            this.BloomLabel.Name = "BloomLabel";
            this.BloomLabel.Size = new System.Drawing.Size(59, 23);
            this.BloomLabel.TabIndex = 19;
            this.BloomLabel.Text = "Bloom";
            // 
            // LightRayLabel
            // 
            this.LightRayLabel.AutoSize = true;
            this.LightRayLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LightRayLabel.Location = new System.Drawing.Point(363, 266);
            this.LightRayLabel.Name = "LightRayLabel";
            this.LightRayLabel.Size = new System.Drawing.Size(87, 23);
            this.LightRayLabel.TabIndex = 22;
            this.LightRayLabel.Text = "Light Rays";
            // 
            // MotionBlurLabel
            // 
            this.MotionBlurLabel.AutoSize = true;
            this.MotionBlurLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MotionBlurLabel.Location = new System.Drawing.Point(328, 150);
            this.MotionBlurLabel.Name = "MotionBlurLabel";
            this.MotionBlurLabel.Size = new System.Drawing.Size(102, 23);
            this.MotionBlurLabel.TabIndex = 17;
            this.MotionBlurLabel.Text = "Motion Blur";
            // 
            // DOFLabel
            // 
            this.DOFLabel.AutoSize = true;
            this.DOFLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOFLabel.Location = new System.Drawing.Point(16, 150);
            this.DOFLabel.Name = "DOFLabel";
            this.DOFLabel.Size = new System.Drawing.Size(117, 23);
            this.DOFLabel.TabIndex = 16;
            this.DOFLabel.Text = "Depth of Field";
            // 
            // DynLightLabel
            // 
            this.DynLightLabel.AutoSize = true;
            this.DynLightLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DynLightLabel.Location = new System.Drawing.Point(1, 187);
            this.DynLightLabel.Name = "DynLightLabel";
            this.DynLightLabel.Size = new System.Drawing.Size(142, 23);
            this.DynLightLabel.TabIndex = 15;
            this.DynLightLabel.Text = "Dynamic Lighting";
            // 
            // DynShadowLabel
            // 
            this.DynShadowLabel.AutoSize = true;
            this.DynShadowLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DynShadowLabel.Location = new System.Drawing.Point(348, 187);
            this.DynShadowLabel.Name = "DynShadowLabel";
            this.DynShadowLabel.Size = new System.Drawing.Size(151, 23);
            this.DynShadowLabel.TabIndex = 18;
            this.DynShadowLabel.Text = "Dynamic Shadows";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(456, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 34);
            this.comboBox1.TabIndex = 14;
            // 
            // AmbientOcclusionBox
            // 
            this.AmbientOcclusionBox.Location = new System.Drawing.Point(131, 64);
            this.AmbientOcclusionBox.Mask = "000";
            this.AmbientOcclusionBox.Name = "AmbientOcclusionBox";
            this.AmbientOcclusionBox.PromptChar = ' ';
            this.AmbientOcclusionBox.Size = new System.Drawing.Size(152, 33);
            this.AmbientOcclusionBox.TabIndex = 11;
            this.AmbientOcclusionBox.ValidatingType = typeof(int);
            // 
            // AntiAliasingBox
            // 
            this.AntiAliasingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AntiAliasingBox.FormattingEnabled = true;
            this.AntiAliasingBox.Items.AddRange(new object[] {
            "Off",
            "FXAA Low",
            "FXAA Medium",
            "FXAA High",
            "2x MSAA",
            "4x MSAA",
            "8x MSAA"});
            this.AntiAliasingBox.Location = new System.Drawing.Point(129, 24);
            this.AntiAliasingBox.Name = "AntiAliasingBox";
            this.AntiAliasingBox.Size = new System.Drawing.Size(152, 34);
            this.AntiAliasingBox.TabIndex = 9;
            // 
            // AnisoBox
            // 
            this.AnisoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnisoBox.FormattingEnabled = true;
            this.AnisoBox.Items.AddRange(new object[] {
            "4x",
            "8x",
            "16x"});
            this.AnisoBox.Location = new System.Drawing.Point(456, 24);
            this.AnisoBox.Name = "AnisoBox";
            this.AnisoBox.Size = new System.Drawing.Size(152, 34);
            this.AnisoBox.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBox4.Location = new System.Drawing.Point(456, 68);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(152, 34);
            this.comboBox4.TabIndex = 10;
            // 
            // TessellationLabel
            // 
            this.TessellationLabel.AutoSize = true;
            this.TessellationLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TessellationLabel.Location = new System.Drawing.Point(333, 73);
            this.TessellationLabel.Name = "TessellationLabel";
            this.TessellationLabel.Size = new System.Drawing.Size(158, 23);
            this.TessellationLabel.TabIndex = 4;
            this.TessellationLabel.Text = "Tessellation Quality";
            // 
            // AmbientOcclusionLabel
            // 
            this.AmbientOcclusionLabel.AutoSize = true;
            this.AmbientOcclusionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmbientOcclusionLabel.Location = new System.Drawing.Point(21, 73);
            this.AmbientOcclusionLabel.Name = "AmbientOcclusionLabel";
            this.AmbientOcclusionLabel.Size = new System.Drawing.Size(154, 23);
            this.AmbientOcclusionLabel.TabIndex = 3;
            this.AmbientOcclusionLabel.Text = "Ambient Occlusion";
            // 
            // HBAOLabel
            // 
            this.HBAOLabel.AutoSize = true;
            this.HBAOLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HBAOLabel.Location = new System.Drawing.Point(6, 110);
            this.HBAOLabel.Name = "HBAOLabel";
            this.HBAOLabel.Size = new System.Drawing.Size(128, 23);
            this.HBAOLabel.TabIndex = 2;
            this.HBAOLabel.Text = "HBAO Intensity";
            // 
            // AntiAliasingLabel
            // 
            this.AntiAliasingLabel.AutoSize = true;
            this.AntiAliasingLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AntiAliasingLabel.Location = new System.Drawing.Point(16, 29);
            this.AntiAliasingLabel.Name = "AntiAliasingLabel";
            this.AntiAliasingLabel.Size = new System.Drawing.Size(107, 23);
            this.AntiAliasingLabel.TabIndex = 1;
            this.AntiAliasingLabel.Text = "Anti-Aliasing";
            // 
            // MaxShadowLabel
            // 
            this.MaxShadowLabel.AutoSize = true;
            this.MaxShadowLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxShadowLabel.Location = new System.Drawing.Point(353, 110);
            this.MaxShadowLabel.Name = "MaxShadowLabel";
            this.MaxShadowLabel.Size = new System.Drawing.Size(131, 23);
            this.MaxShadowLabel.TabIndex = 5;
            this.MaxShadowLabel.Text = "Shadow Quality";
            // 
            // AnisotropyLabel
            // 
            this.AnisotropyLabel.AutoSize = true;
            this.AnisotropyLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnisotropyLabel.Location = new System.Drawing.Point(266, 29);
            this.AnisotropyLabel.Name = "AnisotropyLabel";
            this.AnisotropyLabel.Size = new System.Drawing.Size(164, 23);
            this.AnisotropyLabel.TabIndex = 0;
            this.AnisotropyLabel.Text = "Anisotropic Filtering";
            // 
            // Dx11Box
            // 
            this.Dx11Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dx11Box.FormattingEnabled = true;
            this.Dx11Box.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Dx11Box.Location = new System.Drawing.Point(328, 149);
            this.Dx11Box.Name = "Dx11Box";
            this.Dx11Box.Size = new System.Drawing.Size(152, 34);
            this.Dx11Box.TabIndex = 12;
            // 
            // ResolutionBox
            // 
            this.ResolutionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionBox.FormattingEnabled = true;
            this.ResolutionBox.Location = new System.Drawing.Point(149, 33);
            this.ResolutionBox.Name = "ResolutionBox";
            this.ResolutionBox.Size = new System.Drawing.Size(152, 34);
            this.ResolutionBox.TabIndex = 7;
            // 
            // Dx11FeatureLabel
            // 
            this.Dx11FeatureLabel.AutoSize = true;
            this.Dx11FeatureLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dx11FeatureLabel.Location = new System.Drawing.Point(140, 154);
            this.Dx11FeatureLabel.Name = "Dx11FeatureLabel";
            this.Dx11FeatureLabel.Size = new System.Drawing.Size(161, 23);
            this.Dx11FeatureLabel.TabIndex = 6;
            this.Dx11FeatureLabel.Text = "DirectX 11 Features";
            // 
            // BasicDisplayGroupBox
            // 
            this.BasicDisplayGroupBox.AutoSize = true;
            this.BasicDisplayGroupBox.Controls.Add(this.LanguageBox);
            this.BasicDisplayGroupBox.Controls.Add(this.FrameCapTextBox);
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
            this.BasicDisplayGroupBox.Size = new System.Drawing.Size(650, 191);
            this.BasicDisplayGroupBox.TabIndex = 13;
            this.BasicDisplayGroupBox.TabStop = false;
            this.BasicDisplayGroupBox.Text = "Basic";
            // 
            // LanguageBox
            // 
            this.LanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.LanguageBox.Location = new System.Drawing.Point(456, 105);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(152, 34);
            this.LanguageBox.TabIndex = 14;
            // 
            // FrameCapTextBox
            // 
            this.FrameCapTextBox.Location = new System.Drawing.Point(146, 105);
            this.FrameCapTextBox.Mask = "000";
            this.FrameCapTextBox.Name = "FrameCapTextBox";
            this.FrameCapTextBox.PromptChar = ' ';
            this.FrameCapTextBox.Size = new System.Drawing.Size(152, 33);
            this.FrameCapTextBox.TabIndex = 11;
            this.FrameCapTextBox.ValidatingType = typeof(int);
            // 
            // VsyncBox
            // 
            this.VsyncBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VsyncBox.FormattingEnabled = true;
            this.VsyncBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.VsyncBox.Location = new System.Drawing.Point(146, 68);
            this.VsyncBox.Name = "VsyncBox";
            this.VsyncBox.Size = new System.Drawing.Size(152, 34);
            this.VsyncBox.TabIndex = 9;
            // 
            // FullscreenBox
            // 
            this.FullscreenBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FullscreenBox.FormattingEnabled = true;
            this.FullscreenBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.FullscreenBox.Location = new System.Drawing.Point(456, 30);
            this.FullscreenBox.Name = "FullscreenBox";
            this.FullscreenBox.Size = new System.Drawing.Size(152, 34);
            this.FullscreenBox.TabIndex = 8;
            // 
            // DetailModeBox
            // 
            this.DetailModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DetailModeBox.FormattingEnabled = true;
            this.DetailModeBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.DetailModeBox.Location = new System.Drawing.Point(456, 68);
            this.DetailModeBox.Name = "DetailModeBox";
            this.DetailModeBox.Size = new System.Drawing.Size(152, 34);
            this.DetailModeBox.TabIndex = 10;
            // 
            // DetailModeLabel
            // 
            this.DetailModeLabel.AutoSize = true;
            this.DetailModeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailModeLabel.Location = new System.Drawing.Point(333, 73);
            this.DetailModeLabel.Name = "DetailModeLabel";
            this.DetailModeLabel.Size = new System.Drawing.Size(103, 23);
            this.DetailModeLabel.TabIndex = 4;
            this.DetailModeLabel.Text = "Detail Mode";
            // 
            // VsyncLabel
            // 
            this.VsyncLabel.AutoSize = true;
            this.VsyncLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VsyncLabel.Location = new System.Drawing.Point(21, 73);
            this.VsyncLabel.Name = "VsyncLabel";
            this.VsyncLabel.Size = new System.Drawing.Size(108, 23);
            this.VsyncLabel.TabIndex = 3;
            this.VsyncLabel.Text = "Vertical Sync";
            // 
            // FrameCapLabel
            // 
            this.FrameCapLabel.AutoSize = true;
            this.FrameCapLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrameCapLabel.Location = new System.Drawing.Point(6, 110);
            this.FrameCapLabel.Name = "FrameCapLabel";
            this.FrameCapLabel.Size = new System.Drawing.Size(123, 23);
            this.FrameCapLabel.TabIndex = 2;
            this.FrameCapLabel.Text = "Framerate Cap";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionLabel.Location = new System.Drawing.Point(37, 35);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(92, 23);
            this.ResolutionLabel.TabIndex = 1;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageLabel.Location = new System.Drawing.Point(353, 110);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(83, 23);
            this.LanguageLabel.TabIndex = 5;
            this.LanguageLabel.Text = "Language";
            // 
            // FullscreenLabel
            // 
            this.FullscreenLabel.AutoSize = true;
            this.FullscreenLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullscreenLabel.Location = new System.Drawing.Point(348, 35);
            this.FullscreenLabel.Name = "FullscreenLabel";
            this.FullscreenLabel.Size = new System.Drawing.Size(88, 23);
            this.FullscreenLabel.TabIndex = 0;
            this.FullscreenLabel.Text = "Fullscreen";
            // 
            // ControlTab
            // 
            this.ControlTab.Location = new System.Drawing.Point(4, 38);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.ControlTab.Size = new System.Drawing.Size(655, 581);
            this.ControlTab.TabIndex = 1;
            this.ControlTab.Text = "Controls";
            this.ControlTab.UseVisualStyleBackColor = true;
            // 
            // AboutTab
            // 
            this.AboutTab.Location = new System.Drawing.Point(4, 38);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(655, 581);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // CityLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(681, 752);
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
        private Label Dx11FeatureLabel;
        public ComboBox FullscreenBox;
        public ComboBox ResolutionBox;
        public ComboBox VsyncBox;
        public ComboBox DetailModeBox;
        public MaskedTextBox FrameCapTextBox;
        public ComboBox Dx11Box;
        private GroupBox BasicDisplayGroupBox;
        public ComboBox LanguageBox;
        private GroupBox AdvancedDisplayGroupBox;
        public ComboBox comboBox1;
        public MaskedTextBox AmbientOcclusionBox;
        public ComboBox AntiAliasingBox;
        public ComboBox AnisoBox;
        public ComboBox comboBox4;
        private Label TessellationLabel;
        private Label AmbientOcclusionLabel;
        private Label HBAOLabel;
        private Label AntiAliasingLabel;
        private Label MaxShadowLabel;
        private Label AnisotropyLabel;
        private Label MotionBlurLabel;
        private Label DOFLabel;
        private Label DynLightLabel;
        private Label DynShadowLabel;
        private Label LensFlareLabel;
        private Label DistortionLabel;
        private Label BloomLabel;
        private Label LightRayLabel;
        private Label MVSSLabel;
        private Label PhysXLabel;
    }
}