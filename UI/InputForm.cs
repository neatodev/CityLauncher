using NLog;

namespace CityLauncher
{
    public partial class InputForm : Form
    {
        private string ModifierString = "";
        private string KeyString = "";

        private string[] ToSanitize = { "OemBackslash", "Oemcomma", "OemPeriod", "OemQuestion", "OemOpenBrackets", "Capital", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "OemMinus", "Oemplus", "PageUp", "Next", "Equals" };
        private string[] Sanitized = { "\\", ",", ".", "/", "[", "Caps", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "Page Up", "Page Down", "=" };

        private Button Input;

        private static Logger Nlog = LogManager.GetCurrentClassLogger();

        public InputForm(Button InputButton)
        {
            InitializeComponent();
            Input = InputButton;
            this.KeyDown += InputForm_KeyDown;
            this.MouseClick += InputForm_MouseClick;
            this.MouseWheel += InputForm_MouseWheel;
            Program.MainWindow.ControlSettingChanged = true;
            CenterMouseCursor();
            Nlog.Info("Constructor - Created a new instance of InputForm for '{0}'.", InputButton.Name);
        }

        private void CenterMouseCursor()
        {
            Screen ActiveScreen = Screen.FromControl(this);
            Cursor.Position = new Point(ActiveScreen.Bounds.Width / 2, ActiveScreen.Bounds.Height / 2);
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

            if (e.KeyCode is Keys.Shift or Keys.ShiftKey or Keys.LShiftKey)
            {
                ModifierString = "Shift + ";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
            else if (e.KeyCode is Keys.Control or Keys.ControlKey or Keys.LControlKey)
            {
                ModifierString = "Ctrl + ";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
            else if (e.KeyCode is Keys.Alt or Keys.Menu or Keys.LMenu)
            {
                ModifierString = "Alt + ";
                KeybindValueLabel.Text = ModifierString + KeyString;
            }
            else if (e.KeyCode != Keys.Enter)
            {
                KeyString = SanitizeInput(e.KeyCode.ToString());
                switch (e.KeyCode)
                {
                    case Keys.NumPad0:
                        KeyString = "Num 0";
                        break;
                    case Keys.NumPad1:
                        KeyString = "Num 1";
                        break;
                    case Keys.NumPad2:
                        KeyString = "Num 2";
                        break;
                    case Keys.NumPad3:
                        KeyString = "Num 3";
                        break;
                    case Keys.NumPad4:
                        KeyString = "Num 4";
                        break;
                    case Keys.NumPad5:
                        KeyString = "Num 5";
                        break;
                    case Keys.NumPad6:
                        KeyString = "Num 6";
                        break;
                    case Keys.NumPad7:
                        KeyString = "Num 7";
                        break;
                    case Keys.NumPad8:
                        KeyString = "Num 8";
                        break;
                    case Keys.NumPad9:
                        KeyString = "Num 9";
                        break;
                }
            }

            KeybindValueLabel.Text = ModifierString + KeyString;

            switch (e.KeyCode) { 
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
            this.Focus();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            InputForm_MouseClick(sender, e);
            this.Focus();
        }

        private void InputForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), this.DisplayRectangle);
        }
    }
}
