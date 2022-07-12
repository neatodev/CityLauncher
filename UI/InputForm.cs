namespace CityLauncher
{
    public partial class InputForm : Form
    {
        private string ModifierString = "";
        private string KeyString = "";

        private string[] ToSanitize = { "OemBackslash", "Oemcomma", "OemPeriod", "OemQuestion", "OemOpenBrackets", "Capital", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "OemMinus", "Oemplus", "PageUp", "Next", "Equals" };
        private string[] Sanitized = { "\\", ",", ".", "/", "[", "Caps", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "Page Up", "Page Down", "=" };

        private Button Input;

        public InputForm(Button InputButton)
        {
            InitializeComponent();
            Input = InputButton;
            this.KeyDown += InputForm_KeyDown;
            this.MouseClick += InputForm_MouseClick;
            this.MouseWheel += InputForm_MouseWheel;
        }

        private void InputForm_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                KeyString = "Mousewheel Up";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
            else
            {
                KeyString = "Mousewheel Down";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
        }

        private void InputForm_MouseClick(object? sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    KeyString = "Left Mouse";
                    KeybindValueLabel.Text = ModifierString + KeyString;
                    break;
                case MouseButtons.Right:
                    KeyString = "Right Mouse";
                    KeybindValueLabel.Text = ModifierString + KeyString;
                    break;
                case MouseButtons.Middle:
                    KeyString = "Middle Mouse";
                    KeybindValueLabel.Text = ModifierString + KeyString;
                    break;
                case MouseButtons.XButton1:
                    KeyString = "Mouse Thumb 1";
                    KeybindValueLabel.Text = ModifierString + KeyString;
                    break;
                case MouseButtons.XButton2:
                    KeyString = "Mouse Thumb 2";
                    KeybindValueLabel.Text = ModifierString + KeyString;
                    break;
            }
        }

        private void InputForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (Program.InputHandler.KeyIsBanned(e))
            {
                return;
            }

            if (e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.LShiftKey)
            {
                ModifierString = "Shift + ";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
            else if (e.KeyCode == Keys.Control || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.LControlKey)
            {
                ModifierString = "Ctrl + ";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
            else if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.Menu || e.KeyCode == Keys.LMenu)
            {
                ModifierString = "Alt + ";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
            else if (e.KeyCode != Keys.Enter)
            {
                KeyString = SanitizeInput(e.KeyCode.ToString());
            }

            KeybindValueLabel.Text = ModifierString + KeyString;

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    if (KeyString.Length > 0)
                    {
                        Program.InputHandler.SetButton(Input, KeybindValueLabel.Text);
                        this.Close();
                    }
                    break;
                case Keys.Back:
                    Program.InputHandler.SetButton(Input, "Unbound");
                    this.Close();
                    break;
            }
        }

        private string SanitizeInput(string Input)
        {
            for (int i = 0; i < ToSanitize.Length; i++)
            {
                if (Input == ToSanitize[i])
                {
                    Input = Sanitized[i];
                }
            }
            return Input;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
