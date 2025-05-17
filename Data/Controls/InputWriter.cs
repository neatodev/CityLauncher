﻿using CityLauncher.Properties;
using NLog;
using System.Text.RegularExpressions;

namespace CityLauncher
{
    internal class InputWriter
    {
        private string[] UserInputLines;
        private string[] BmInputLines = { "", "" };
        private bool CustomBinds = false;

        private static Logger Nlog = LogManager.GetCurrentClassLogger();

        public InputWriter()
        {
            UserInputLines = File.ReadAllLines(Program.FileHandler.UserInputPath);
            BmInputLines[0] = IniHandler.BmInputData["Engine.PlayerInput"]["MouseSensitivity"];
            BmInputLines[1] = IniHandler.BmInputData["Engine.PlayerInput"]["bEnableMouseSmoothing"];
            Nlog.Info("Constructor - Successfully initialized InputWriter.");
        }

        public void WriteAll()
        {
            WriteControls();
            WriteBmInput();
            Nlog.Info("WriteAll - Successfully wrote settings to 'BmInput.ini' and 'UserInput.ini'.");
        }

        public void WriteControls()
        {
            // Forward
            UserInputLines[5] = ConvertToConfigStyle(Program.MainWindow.FwButton1.Text, 5);
            // Backward
            UserInputLines[6] = ConvertToConfigStyle(Program.MainWindow.BwButton1.Text, 6);
            // Left
            UserInputLines[7] = ConvertToConfigStyle(Program.MainWindow.LeftButton1.Text, 7);
            // Right
            UserInputLines[8] = ConvertToConfigStyle(Program.MainWindow.RightButton1.Text, 8);
            // Run/Glide/Use
            UserInputLines[9] = ConvertToConfigStyle(Program.MainWindow.RGUButton1.Text, 9);
            // Crouch
            UserInputLines[10] = ConvertToConfigStyle(Program.MainWindow.CrouchButton1.Text, 10);
            // Zoom
            UserInputLines[11] = ConvertToConfigStyle(Program.MainWindow.ZoomButton1.Text, 11);
            // Grapple
            UserInputLines[12] = ConvertToConfigStyle(Program.MainWindow.GrappleButton1.Text, 12);
            // Toggle Crouch
            UserInputLines[13] = ConvertToConfigStyle(Program.MainWindow.ToggleCrouchButton1.Text, 13);
            // Detective Mode
            UserInputLines[14] = ConvertToConfigStyle(Program.MainWindow.DetectiveModeButton1.Text, 14);
            // Gadget/Strike
            UserInputLines[15] = ConvertToConfigStyle(Program.MainWindow.UseGadgetStrikeButton1.Text, 15);
            // Aim Gadget/Counter/Takedown
            UserInputLines[18] = ConvertToConfigStyle(Program.MainWindow.ACTButton1.Text, 18);
            // Gadget Secondary/Cape Stun
            UserInputLines[21] = ConvertToConfigStyle(Program.MainWindow.GadgetSecButton1.Text, 21);
            // Previous Gadget
            UserInputLines[24] = ConvertToConfigStyle(Program.MainWindow.PrevGadgetButton1.Text, 24);
            // Next Gadget
            UserInputLines[25] = ConvertToConfigStyle(Program.MainWindow.NextGadgetButton1.Text, 25);
            // Special Combo Takedown
            UserInputLines[26] = ConvertToConfigStyle(Program.MainWindow.SCTButton1.Text, 26);
            // Special Combo Bat Swarm
            UserInputLines[27] = ConvertToConfigStyle(Program.MainWindow.SCBSButton1.Text, 27);
            // Special Combo Multi Ground Takedown
            UserInputLines[28] = ConvertToConfigStyle(Program.MainWindow.MultiGroundTDButton1.Text, 28);
            // Special Combo Disarm and Destroy
            UserInputLines[29] = ConvertToConfigStyle(Program.MainWindow.DisarmDestroyButton1.Text, 29);
            // Gadget 1
            UserInputLines[30] = ConvertToConfigStyle(Program.MainWindow.Gadget1Button1.Text, 30);
            // Gadget 2
            UserInputLines[31] = ConvertToConfigStyle(Program.MainWindow.Gadget2Button1.Text, 31);
            // Gadget 3
            UserInputLines[32] = ConvertToConfigStyle(Program.MainWindow.Gadget3Button1.Text, 32);
            // Gadget 4
            UserInputLines[33] = ConvertToConfigStyle(Program.MainWindow.Gadget4Button1.Text, 33);
            // Gadget 5
            UserInputLines[34] = ConvertToConfigStyle(Program.MainWindow.Gadget5Button1.Text, 34);
            // Gadget 6
            UserInputLines[35] = ConvertToConfigStyle(Program.MainWindow.Gadget6Button1.Text, 35);
            // Gadget 7
            UserInputLines[36] = ConvertToConfigStyle(Program.MainWindow.Gadget7Button1.Text, 36);
            // Gadget 8
            UserInputLines[37] = ConvertToConfigStyle(Program.MainWindow.Gadget8Button1.Text, 37);
            // Gadget 9
            UserInputLines[38] = ConvertToConfigStyle(Program.MainWindow.Gadget9Button1.Text, 38);
            // Gadget 10
            UserInputLines[39] = ConvertToConfigStyle(Program.MainWindow.Gadget10Button1.Text, 39);
            // Gadget 11
            UserInputLines[40] = ConvertToConfigStyle(Program.MainWindow.Gadget11Button1.Text, 40);
            // Gadget 12
            UserInputLines[41] = ConvertToConfigStyle(Program.MainWindow.Gadget12Button1.Text, 41);
            // Quickfire Gadget 1
            UserInputLines[42] = ConvertToConfigStyle(Program.MainWindow.QFireGadget1Button1.Text, 42);
            UserInputLines[84] = ConvertToConfigStyle(Program.MainWindow.QFireGadget1Button1.Text, 42);
            // Quickfire Gadget 2
            UserInputLines[43] = ConvertToConfigStyle(Program.MainWindow.QFireGadget2Button1.Text, 43);
            UserInputLines[85] = ConvertToConfigStyle(Program.MainWindow.QFireGadget2Button1.Text, 43);
            // Quickfire Gadget 3
            UserInputLines[44] = ConvertToConfigStyle(Program.MainWindow.QFireGadget3Button1.Text, 44);
            UserInputLines[86] = ConvertToConfigStyle(Program.MainWindow.QFireGadget3Button1.Text, 44);
            // Quickfire Gadget 4
            UserInputLines[45] = ConvertToConfigStyle(Program.MainWindow.QFireGadget4Button1.Text, 45);
            UserInputLines[87] = ConvertToConfigStyle(Program.MainWindow.QFireGadget4Button1.Text, 45);
            // Quickfire Gadget 5
            UserInputLines[46] = ConvertToConfigStyle(Program.MainWindow.QFireGadget5Button1.Text, 46);
            UserInputLines[88] = ConvertToConfigStyle(Program.MainWindow.QFireGadget5Button1.Text, 46);
            // Cape Stun
            UserInputLines[65] = ConvertToConfigStyle(Program.MainWindow.CapeStunButton.Text, 65);
            // Catwoman Disarm Fix
            UserInputLines[91] = ConvertToConfigStyle(Program.MainWindow.CWDisarmFixButton1.Text, 91);
            // Speedrun Setting
            UserInputLines[94] = ConvertToConfigStyle(Program.MainWindow.SpeedRunButton.Text, 94);
            // Open Console
            UserInputLines[97] = ConvertToConfigStyle(Program.MainWindow.OpenConsoleButton.Text, 97);
            UserInputLines[97] = SetTypeKey(UserInputLines[97]);
            // Toggle HUD
            UserInputLines[98] = ConvertToConfigStyle(Program.MainWindow.ToggleHudButton.Text, 98);
            // Reset FoV
            UserInputLines[99] = ConvertToConfigStyle(Program.MainWindow.ResetFoVButton.Text, 99);
            // Custom FoV 1
            UserInputLines[100] = ConvertToConfigStyle(Program.MainWindow.CustomFoV1Button.Text, 100);
            UserInputLines[100] = UpdateFoVValue(UserInputLines[100], Program.MainWindow.CustomFoV1Trackbar.Value);
            // Custom FoV 2
            UserInputLines[101] = ConvertToConfigStyle(Program.MainWindow.CustomFoV2Button.Text, 101);
            UserInputLines[101] = UpdateFoVValue(UserInputLines[101], Program.MainWindow.CustomFoV2Trackbar.Value);
            // Custom Command
            UserInputLines[102] = ConvertToConfigStyle(Program.MainWindow.CustomCommandButton.Text, 102);
            // Centre Camera
            UserInputLines[103] = ConvertToConfigStyle(Program.MainWindow.CentreCameraButton.Text, 103);
            // View Map
            UserInputLines[104] = ConvertToConfigStyle(Program.MainWindow.MapButton.Text, 104);
            // Debug Menu
            UserInputLines[105] = ConvertToConfigStyle(Program.MainWindow.DebugMenuButton.Text, 105);

            using (StreamWriter UserInputFile = new(Program.FileHandler.UserInputPath))
            {
                foreach (string Line in UserInputLines)
                {
                    UserInputFile.WriteLine(Line);
                }
                UserInputFile.Close();
            }

            foreach (Button KeyButton in Program.InputHandler.ButtonList)
            {
                if (!KeyButton.Text.Contains("Unbound"))
                {
                    KeyButton.ForeColor = Color.Black;
                }
                else
                {
                    KeyButton.ForeColor = Color.Maroon;
                }
            }
        }

        public void WriteBmInput()
        {
            Program.FileHandler.BmInput.IsReadOnly = false;
            File.Delete(Program.FileHandler.BmInputPath);
            Program.FileHandler.CreateConfigFile(Program.FileHandler.BmInputPath, Resources.BmInput);
            // Mouse Sensitivity
            BmInputLines[0] = Program.MainWindow.MouseSensitivityValueLabel.Text + ".0";

            // Mouse Smoothing
            if (Program.MainWindow.MouseSmoothingBox.Checked)
            {
                BmInputLines[1] = "true";
            }
            else
            {
                BmInputLines[1] = "false";
            }

            List<string> BmInputFileLines = new();
            foreach (string Line in File.ReadAllLines(Program.FileHandler.BmInputPath))
            {
                BmInputFileLines.Add(Line);
            }

            BmInputFileLines[5] = "MouseSensitivity=" + BmInputLines[0];
            BmInputFileLines[7] = "bEnableMouseSmoothing=" + BmInputLines[1];
            using (StreamWriter BmInputFile = new(Program.FileHandler.BmInputPath))
            {
                for (int i = 0; i < BmInputFileLines.Count; i++)
                {
                    if (i == 224)
                    {
                        for (int j = 5; j < UserInputLines.Length; j++)
                        {
                            try
                            {
                                if (UserInputLines[j].Contains("; Add your own custom keybinds below this line."))
                                {
                                    BmInputFile.WriteLine("; Add your own custom keybinds below this line. (Automatically carried over from UserInput.ini, DO NOT MODIFY!)");
                                    CustomBinds = true;
                                }
                                else if (!UserInputLines[j].Contains(";"))
                                {
                                    if (CustomBinds == true)
                                    {
                                        if (UserInputLines[j].Substring(0, 1).Contains("."))
                                        {
                                            BmInputFile.WriteLine(UserInputLines[j].Substring(1));
                                        }
                                        else
                                        {
                                            BmInputFile.WriteLine(UserInputLines[j]);
                                        }
                                    }
                                    else
                                    {
                                        BmInputFile.WriteLine(UserInputLines[j].Substring(1));
                                    }
                                }
                                else
                                {
                                    BmInputFile.WriteLine(UserInputLines[j]);
                                }
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                BmInputFile.WriteLine(UserInputLines[j]);
                            }
                            BmInputFileLines.Insert(i + j - 5, UserInputLines[j]);
                        }
                        i = BmInputFileLines.IndexOf("[Engine.DebugCameraInput]") - 1;
                    }
                    BmInputFile.WriteLine(BmInputFileLines[i]);
                }
                BmInputFile.Close();
            }
            Program.FileHandler.BmInput.IsReadOnly = true;
            CustomBinds = false;
        }

        private string ConvertToConfigStyle(string Text, int i)
        {
            Nlog.Info("ConvertToConfigStyle - Binding {0} to UserInput on line {1}.", Text, (i + 1).ToString());
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
            return ConfigLine;
        }

        private string SetModifier(string Input, string Modifier)
        {
            if (!Input.Contains("Shift=") && !Input.Contains("Control=") && !Input.Contains("Alt="))
            {
                return Input;
            }

            TimeSpan Time = new(0, 0, 0, 0, 30);

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

        private string SetTypeKey(string ConsoleLine)
        {
            var TrimmedLine = ConsoleLine.Substring(ConsoleLine.IndexOf(","));
            TrimmedLine = TrimmedLine.Substring(TrimmedLine.IndexOf("\"") + 1);
            TrimmedLine = TrimmedLine.Substring(0, TrimmedLine.IndexOf("\""));
            var TypeKeyValue = ConsoleLine.Substring(17);
            TypeKeyValue = TypeKeyValue.Substring(0, TypeKeyValue.IndexOf("\""));
            var NewTypeKey = "set console TypeKey " + TypeKeyValue;

            TimeSpan Time = new(0, 0, 0, 0, 9);

            ConsoleLine = Regex.Replace(ConsoleLine, TrimmedLine, NewTypeKey, RegexOptions.Compiled, Time);
            return ConsoleLine;
        }

        private string UpdateFoVValue(string ConfigLine, int FoVValue)
        {
            var FoVSection = ConfigLine.Substring(ConfigLine.IndexOf(","));
            FoVSection = FoVSection.Substring(FoVSection.IndexOf("\"") + 1);
            FoVSection = FoVSection.Substring(0, FoVSection.IndexOf("\""));
            var UpdatedValue = "fov " + FoVValue;

            TimeSpan Time = new(0, 0, 0, 0, 9);

            ConfigLine = Regex.Replace(ConfigLine, FoVSection, UpdatedValue, RegexOptions.Compiled, Time);
            return ConfigLine;
        }

        private string ConvertLine(string Input)
        {
            for (int i = 0; i < Program.InputHandler.LinesHumanReadable.Length; i++)
            {
                if (Input == Program.InputHandler.LinesHumanReadable[i].Replace(" ", ""))
                {
                    return Program.InputHandler.LinesConfigStyle[i];
                }
            }
            return Input;
        }
    }
}
