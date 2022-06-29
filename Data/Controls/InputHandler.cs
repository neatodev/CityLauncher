namespace CityLauncher
{
    internal class InputHandler
    {
        public string UserInputFile;

        public string[] LinesConfigStyle;

        public string[] LinesHumanReadable;

        public InputHandler()
        {
            UserInputFile = Program.FileHandler.UserInputPath;
            LinesConfigStyle = FillConfigStyle();
            LinesHumanReadable = FillHumanReadable();
        }

        private string[] FillConfigStyle()
        {
            string[] style = { "LeftMouseButton", "RightMouseButton","MouseScrollUp","MouseScrollDown", "LeftControl", "MiddleMouseButton", "ThumbMouseButton", "ThumbMouseButton2","SpaceBar", "CapsLock", "Backslash", "RightAlt", "Underscore", "Equals",
                                "LeftBracket", "RightBracket", "Semicolon", "Comma", "Period", "Slash","PageUp","PageDown","Divide","Multiply",
                                "NumpadZero","NumpadOne","NumpadTwo","NumpadThree","NumpadFour","NumpadFive","NumpadSix","NumpadSeven","NumpadEight","NumpadNine",
                                "Add", "Decimal", "Zero", "One" ,"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
            return style;
        }

        private string[] FillHumanReadable()
        {
            string[] style = { "Left Mouse", "Right Mouse","Mousewheel Up", "Mousewheel Down", "Ctrl", "Middle Mouse", "Mouse Thumb 1", "Mouse Thumb 2","Space", "Caps", "Backslash", "Right Alt", "_", "=",
                                "[", "]", ";", ",", ".", "/","Page Up","Page Down","Num /","Num *",
                                "Num 0","Num 1","Num 2","Num 3","Num 4","Num 5","Num 6","Num 7","Num 8","Num 9",
                                "Num +", "Num .", "0", "1" ,"2", "3", "4", "5", "6", "7", "8", "9"};
            return style;
        }
    }
}
