using System.Text.RegularExpressions;

namespace CityLauncher
{
    internal class InputWriter
    {
        private string[] UserInputLines;
        private string[] BmInputLines = { "", "" };

        public InputWriter()
        {
            UserInputLines = File.ReadAllLines(Program.FileHandler.UserInputPath);
            BmInputLines[0] = IniHandler.BmInputData["Engine.PlayerInput"]["MouseSensitivity"];
            BmInputLines[1] = IniHandler.BmInputData["Engine.PlayerInput"]["bEnableMouseSmoothing"];
        }

        public void WriteControls()
        {
            // Forward
            UserInputLines[5] = ConvertToConfigStyle(Program.MainWindow.FwButton1.Text, 5);
        }

        private string ConvertToConfigStyle(string Text, int i)
        {
            Text = Text.Replace(" ", "");
            string ConfigLine = UserInputLines[i];
            string ConfigLineTrimmed = ConfigLine.Substring(17);
            int Count = ConfigLineTrimmed.Substring(0, ConfigLineTrimmed.IndexOf("\"")).Length;
            string Modifier = "None";
            try
            {
                Modifier = Text.Substring(0, Text.IndexOf('+'));
                Text = ConvertLine(Text.Substring(Text.IndexOf('+') + 1));
            }
            catch (ArgumentOutOfRangeException)
            {
                Text = ConvertLine(Text);
            }
            ConfigLine = ConfigLine.Remove(17, Count).Insert(17, Text);
            ConfigLine = SetModifier(ConfigLine, Modifier);
            MessageBox.Show(ConfigLine);
            return ConfigLine;
        }

        private string SetModifier(string Input, string Modifier)
        {
            if (!Input.Contains("Shift=") && !Input.Contains("Control=") && !Input.Contains("Alt="))
            {
                return Input;
            }

            TimeSpan Time = new TimeSpan(0, 0, 0, 0, 3);

            switch (Modifier)
            {
                case "None":
                    Input = Regex.Replace(Input, @"\bAlt=true\b", "Alt=false", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bShift=true\b", "Shift=false", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bControl=true\b", "Control=false", RegexOptions.Compiled, Time);
                    break;
                case "Shift":
                    Input = Regex.Replace(Input, @"\bAlt=true\b", "Alt=false", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bShift=false\b", "Shift=true", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bControl=true\b", "Control=false", RegexOptions.Compiled, Time);
                    break;
                case "Ctrl":
                    Input = Regex.Replace(Input, @"\bAlt=true\b", "Alt=false", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bShift=true\b", "Shift=false", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bControl=false\b", "Control=true", RegexOptions.Compiled, Time);
                    break;
                case "Alt":
                    Input = Regex.Replace(Input, @"\bAlt=false\b", "Alt=true", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bShift=true\b", "Shift=false", RegexOptions.Compiled, Time);
                    Input = Regex.Replace(Input, @"\bControl=true\b", "Control=false", RegexOptions.Compiled, Time);
                    break;
            }

            return Input;
        }

        private string ConvertLine(string Input)
        {
            for (int i = 0; i < Program.InputHandler.LinesHumanReadable.Length; i++)
            {
                if (Input == Program.InputHandler.LinesHumanReadable[i])
                {
                    return Program.InputHandler.LinesConfigStyle[i];
                }
            }
            return Input;
        }
    }
}
