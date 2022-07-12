using CityLauncher.Properties;
using NLog;

namespace CityLauncher
{
    internal class InputHandler
    {
        public string UserInputFile;

        public string[] LinesConfigStyle;

        public string[] LinesHumanReadable;

        private readonly string[] BannedKeys = { "OEM8", "OEM6", "OEM5", "LWIN", "RWIN", "OEM7", "SCROLL", "OEM1", "OEMTILDE", "OEM7", "NUMLOCK", "MULTIPLY",
                                        "DIVIDE", "SUBTRACT", "ADD", "DECIMAL", "PAUSE", "NUMPAD0", "NUMPAD1", "NUMPAD2", "NUMPAD3", "NUMPAD4", "NUMPAD5",
                                        "NUMPAD6", "NUMPAD7", "NUMPAD8", "NUMPAD9", "CLEAR" };


        public List<Button> ButtonList = new();

        private static Logger Nlog = LogManager.GetCurrentClassLogger();

        public InputHandler()
        {
            UserInputFile = Program.FileHandler.UserInputPath;
            LinesConfigStyle = FillConfigStyle();
            LinesHumanReadable = FillHumanReadable();
            Nlog.Info("Constructor - Sucessfully initialized InputHandler.");
        }

        private string[] FillConfigStyle()
        {
            string[] style =
            {
                "LeftMouseButton",
                "RightMouseButton",
                "MouseScrollUp",
                "MouseScrollDown",
                "LeftControl",
                "MiddleMouseButton",
                "ThumbMouseButton",
                "ThumbMouseButton2",
                "SpaceBar",
                "CapsLock",
                "Backslash",
                "RightAlt",
                "Underscore",
                "Equals",
                "LeftBracket",
                "RightBracket",
                "Semicolon",
                "Comma",
                "Period",
                "Slash",
                "PageUp",
                "PageDown",
                "Divide",
                "Multiply",
                "NumpadZero",
                "NumpadOne",
                "NumpadTwo",
                "NumpadThree",
                "NumpadFour",
                "NumpadFive",
                "NumpadSix",
                "NumpadSeven",
                "NumpadEight",
                "NumpadNine",
                "Add",
                "Decimal",
                "Zero",
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
                "Nine",
                "Underscore",
                "TAB"
            };
            return style;
        }

        private string[] FillHumanReadable()
        {
            string[] style =
            {
                "Left Mouse",
                "Right Mouse",
                "Mousewheel Up",
                "Mousewheel Down",
                "Ctrl",
                "Middle Mouse",
                "Mouse Thumb 1",
                "Mouse Thumb 2",
                "Space",
                "Caps",
                "\\",
                "Right Alt",
                "_",
                "=",
                "[",
                "]",
                ";",
                ",",
                ".",
                "/",
                "Page Up",
                "Page Down",
                "Num /",
                "Num *",
                "Num 0",
                "Num 1",
                "Num 2",
                "Num 3",
                "Num 4",
                "Num 5",
                "Num 6",
                "Num 7",
                "Num 8",
                "Num 9",
                "Num +",
                "Num .",
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "-",
                "Tab"
            };
            return style;
        }

        public void SetButton(Button Bt, string Text)
        {
            foreach (Button KeyButton in ButtonList)
            {
                if (KeyButton.Text == Text)
                {
                    KeyButton.Text = "Unbound";
                }
            }

            foreach (Button KeyButton in ButtonList)
            {
                if (Bt.Name == KeyButton.Name)
                {
                    KeyButton.Text = Text;
                    break;
                }
            }
        }

        public bool KeyIsBanned(KeyEventArgs e)
        {
            foreach (string Banned in BannedKeys)
            {
                if (e.KeyCode.ToString().ToLower() == Banned.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public void ResetControls()
        {
            File.Delete(UserInputFile);
            Program.FileHandler.CreateConfigFile(UserInputFile, Resources.UserInput);
            new InputReader().InitControls();
        }
    }
}
