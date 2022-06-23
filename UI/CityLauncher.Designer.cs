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
            this.ResolutionBox = new System.Windows.Forms.ComboBox();
            this.Dx11FeatureLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.DetailModeLabel = new System.Windows.Forms.Label();
            this.VsyncLabel = new System.Windows.Forms.Label();
            this.FrameCapLabel = new System.Windows.Forms.Label();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.FullscreenLabel = new System.Windows.Forms.Label();
            this.ControlTab = new System.Windows.Forms.TabPage();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.DisplayTab.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // DisplayTab
            // 
            this.DisplayTab.Controls.Add(this.ResolutionBox);
            this.DisplayTab.Controls.Add(this.Dx11FeatureLabel);
            this.DisplayTab.Controls.Add(this.LanguageLabel);
            this.DisplayTab.Controls.Add(this.DetailModeLabel);
            this.DisplayTab.Controls.Add(this.VsyncLabel);
            this.DisplayTab.Controls.Add(this.FrameCapLabel);
            this.DisplayTab.Controls.Add(this.ResolutionLabel);
            this.DisplayTab.Controls.Add(this.FullscreenLabel);
            this.DisplayTab.Location = new System.Drawing.Point(4, 38);
            this.DisplayTab.Name = "DisplayTab";
            this.DisplayTab.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayTab.Size = new System.Drawing.Size(649, 490);
            this.DisplayTab.TabIndex = 0;
            this.DisplayTab.Text = "Display";
            this.DisplayTab.UseVisualStyleBackColor = true;
            // 
            // ResolutionBox
            // 
            this.ResolutionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionBox.FormattingEnabled = true;
            this.ResolutionBox.Location = new System.Drawing.Point(149, 15);
            this.ResolutionBox.Name = "ResolutionBox";
            this.ResolutionBox.Size = new System.Drawing.Size(152, 34);
            this.ResolutionBox.TabIndex = 7;
            // 
            // Dx11FeatureLabel
            // 
            this.Dx11FeatureLabel.AutoSize = true;
            this.Dx11FeatureLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dx11FeatureLabel.Location = new System.Drawing.Point(127, 134);
            this.Dx11FeatureLabel.Name = "Dx11FeatureLabel";
            this.Dx11FeatureLabel.Size = new System.Drawing.Size(161, 23);
            this.Dx11FeatureLabel.TabIndex = 6;
            this.Dx11FeatureLabel.Text = "DirectX 11 Features";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageLabel.Location = new System.Drawing.Point(345, 88);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(83, 23);
            this.LanguageLabel.TabIndex = 5;
            this.LanguageLabel.Text = "Language";
            // 
            // DetailModeLabel
            // 
            this.DetailModeLabel.AutoSize = true;
            this.DetailModeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailModeLabel.Location = new System.Drawing.Point(328, 53);
            this.DetailModeLabel.Name = "DetailModeLabel";
            this.DetailModeLabel.Size = new System.Drawing.Size(103, 23);
            this.DetailModeLabel.TabIndex = 4;
            this.DetailModeLabel.Text = "Detail Mode";
            // 
            // VsyncLabel
            // 
            this.VsyncLabel.AutoSize = true;
            this.VsyncLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VsyncLabel.Location = new System.Drawing.Point(25, 88);
            this.VsyncLabel.Name = "VsyncLabel";
            this.VsyncLabel.Size = new System.Drawing.Size(108, 23);
            this.VsyncLabel.TabIndex = 3;
            this.VsyncLabel.Text = "Vertical Sync";
            // 
            // FrameCapLabel
            // 
            this.FrameCapLabel.AutoSize = true;
            this.FrameCapLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrameCapLabel.Location = new System.Drawing.Point(12, 53);
            this.FrameCapLabel.Name = "FrameCapLabel";
            this.FrameCapLabel.Size = new System.Drawing.Size(123, 23);
            this.FrameCapLabel.TabIndex = 2;
            this.FrameCapLabel.Text = "Framerate Cap";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionLabel.Location = new System.Drawing.Point(38, 20);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(92, 23);
            this.ResolutionLabel.TabIndex = 1;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // FullscreenLabel
            // 
            this.FullscreenLabel.AutoSize = true;
            this.FullscreenLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullscreenLabel.Location = new System.Drawing.Point(342, 20);
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
            this.ControlTab.Size = new System.Drawing.Size(649, 490);
            this.ControlTab.TabIndex = 1;
            this.ControlTab.Text = "Controls";
            this.ControlTab.UseVisualStyleBackColor = true;
            // 
            // AboutTab
            // 
            this.AboutTab.Location = new System.Drawing.Point(4, 38);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(649, 490);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CityLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batman: Arkham City - Advanced Launcher";
            this.tabControl1.ResumeLayout(false);
            this.DisplayTab.ResumeLayout(false);
            this.DisplayTab.PerformLayout();
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
        private ComboBox ResolutionBox;
    }
}