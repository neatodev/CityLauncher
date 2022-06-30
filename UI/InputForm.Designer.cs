namespace CityLauncher
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeybindValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please press your desired key. If you want to use Shift/Alt/Ctrl Modifer,\r\nplease" +
    " press the modifier key before your desired keybind.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keybind:";
            // 
            // KeybindValueLabel
            // 
            this.KeybindValueLabel.AutoSize = true;
            this.KeybindValueLabel.Location = new System.Drawing.Point(190, 115);
            this.KeybindValueLabel.Name = "KeybindValueLabel";
            this.KeybindValueLabel.Size = new System.Drawing.Size(0, 15);
            this.KeybindValueLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Press ESCAPE (ESC) to close this window and abort.";
            // 
            // InputForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(563, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeybindValueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label KeybindValueLabel;
        private Label label3;
    }
}