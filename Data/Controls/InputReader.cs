namespace CityLauncher
{
    internal class InputReader
    {
        private readonly string[] UserInputLines;
        private readonly string[] BmInputLines = { "", "" };

        public InputReader()
        {
            UserInputLines = File.ReadAllLines(Program.FileHandler.UserInputPath);
            BmInputLines[0] = IniHandler.BmInputData["Engine.PlayerInput"]["MouseSensitivity"];
            BmInputLines[1] = IniHandler.BmInputData["Engine.PlayerInput"]["bEnableMouseSmoothing"];

        }

        public void InitControls()
        {
            // Forward
            Program.MainWindow.FwButton1.Text = TrimLine(UserInputLines[5]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.FwButton1);
            // Backward
            Program.MainWindow.BwButton1.Text = TrimLine(UserInputLines[6]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.BwButton1);
            // Left
            Program.MainWindow.LeftButton1.Text = TrimLine(UserInputLines[7]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.LeftButton1);
            // Right
            Program.MainWindow.RightButton1.Text = TrimLine(UserInputLines[8]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.RightButton1);
            // Run/Glide/Use
            Program.MainWindow.RGUButton1.Text = TrimLine(UserInputLines[9]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.RGUButton1);
            // Crouch
            Program.MainWindow.CrouchButton1.Text = TrimLine(UserInputLines[10]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.CrouchButton1);
            // Zoom
            Program.MainWindow.ZoomButton1.Text = TrimLine(UserInputLines[11]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.ZoomButton1);
            // Grapple
            Program.MainWindow.GrappleButton1.Text = TrimLine(UserInputLines[12]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.GrappleButton1);
            // Toggle Crouch
            Program.MainWindow.ToggleCrouchButton1.Text = TrimLine(UserInputLines[13]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.ToggleCrouchButton1);
            // Detective Mode
            Program.MainWindow.DetectiveModeButton1.Text = TrimLine(UserInputLines[14]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.DetectiveModeButton1);
            // Gadget/Strike
            Program.MainWindow.UseGadgetStrikeButton1.Text = TrimLine(UserInputLines[15]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.UseGadgetStrikeButton1);
            // Aim Gadget/Counter/Takedown
            Program.MainWindow.ACTButton1.Text = TrimLine(UserInputLines[18]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.ACTButton1);
            // Gadget Secondary/Cape Stun
            Program.MainWindow.GadgetSecButton1.Text = TrimLine(UserInputLines[21]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.GadgetSecButton1);
            // Previous Gadget
            Program.MainWindow.PrevGadgetButton1.Text = TrimLine(UserInputLines[24]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.PrevGadgetButton1);
            // Next Gadget
            Program.MainWindow.NextGadgetButton1.Text = TrimLine(UserInputLines[25]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.NextGadgetButton1);
            // Special Combo Takedown
            Program.MainWindow.SCTButton1.Text = TrimLine(UserInputLines[26]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.SCTButton1);
            // Special Combo Bat Swarm
            Program.MainWindow.SCBSButton1.Text = TrimLine(UserInputLines[27]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.SCBSButton1);
            // Special Combo Multi Ground Takedown
            Program.MainWindow.MultiGroundTDButton1.Text = TrimLine(UserInputLines[28]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.MultiGroundTDButton1);
            // Special Combo Disarm and Destroy
            Program.MainWindow.DisarmDestroyButton1.Text = TrimLine(UserInputLines[29]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.DisarmDestroyButton1);
            // Gadget 1
            Program.MainWindow.Gadget1Button1.Text = TrimLine(UserInputLines[30]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget1Button1);
            // Gadget 2
            Program.MainWindow.Gadget2Button1.Text = TrimLine(UserInputLines[31]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget2Button1);
            // Gadget 3
            Program.MainWindow.Gadget3Button1.Text = TrimLine(UserInputLines[32]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget3Button1);
            // Gadget 4
            Program.MainWindow.Gadget4Button1.Text = TrimLine(UserInputLines[33]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget4Button1);
            // Gadget 5
            Program.MainWindow.Gadget5Button1.Text = TrimLine(UserInputLines[34]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget5Button1);
            // Gadget 6
            Program.MainWindow.Gadget6Button1.Text = TrimLine(UserInputLines[35]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget6Button1);
            // Gadget 7
            Program.MainWindow.Gadget7Button1.Text = TrimLine(UserInputLines[36]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget7Button1);
            // Gadget 8
            Program.MainWindow.Gadget8Button1.Text = TrimLine(UserInputLines[37]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget8Button1);
            // Gadget 9
            Program.MainWindow.Gadget9Button1.Text = TrimLine(UserInputLines[38]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget9Button1);
            // Gadget 10
            Program.MainWindow.Gadget10Button1.Text = TrimLine(UserInputLines[39]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget10Button1);
            // Gadget 11
            Program.MainWindow.Gadget11Button1.Text = TrimLine(UserInputLines[40]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget11Button1);
            // Gadget 12
            Program.MainWindow.Gadget12Button1.Text = TrimLine(UserInputLines[41]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.Gadget12Button1);
            // Quickfire Gadget 1
            Program.MainWindow.QFireGadget1Button1.Text = TrimLine(UserInputLines[42]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.QFireGadget1Button1);
            // Quickfire Gadget 2
            Program.MainWindow.QFireGadget2Button1.Text = TrimLine(UserInputLines[43]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.QFireGadget2Button1);
            // Quickfire Gadget 3
            Program.MainWindow.QFireGadget3Button1.Text = TrimLine(UserInputLines[44]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.QFireGadget3Button1);
            // Quickfire Gadget 4
            Program.MainWindow.QFireGadget4Button1.Text = TrimLine(UserInputLines[45]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.QFireGadget4Button1);
            // Quickfire Gadget 5
            Program.MainWindow.QFireGadget5Button1.Text = TrimLine(UserInputLines[46]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.QFireGadget5Button1);
            // Cape Stun
            Program.MainWindow.CapeStunButton.Text = TrimLine(UserInputLines[65]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.CapeStunButton);
            // Catwoman Disarm Fix
            Program.MainWindow.CWDisarmFixButton1.Text = TrimLine(UserInputLines[91]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.CWDisarmFixButton1);
            // Speedrun Setting
            Program.MainWindow.SpeedRunButton.Text = TrimLine(UserInputLines[94]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.SpeedRunButton);
            // Open Console
            Program.MainWindow.OpenConsoleButton.Text = TrimLine(UserInputLines[97]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.OpenConsoleButton);
            // Toggle HUD
            Program.MainWindow.ToggleHudButton.Text = TrimLine(UserInputLines[98]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.ToggleHudButton);
            // Reset FoV
            Program.MainWindow.ResetFoVButton.Text = TrimLine(UserInputLines[99]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.ResetFoVButton);
            // Custom FoV 1
            Program.MainWindow.CustomFoV1Button.Text = TrimLine(UserInputLines[100]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.CustomFoV1Button);
            // Custom FoV 1 Slider
            var TrackbarValue = UserInputLines[100].Substring(UserInputLines[100].IndexOf(","));
            TrackbarValue = TrackbarValue.Substring(TrackbarValue.IndexOf("\"") + 5);
            Program.MainWindow.CustomFoV1Trackbar.Value = Int16.Parse(TrackbarValue.Substring(0, TrackbarValue.IndexOf("\"")));
            Program.MainWindow.CustomFoV1ValueLabel.Text = Program.MainWindow.CustomFoV1Trackbar.Value.ToString();
            // Custom FoV 2
            Program.MainWindow.CustomFoV2Button.Text = TrimLine(UserInputLines[101]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.CustomFoV2Button);
            // Custom FoV 2 Slider
            TrackbarValue = UserInputLines[101].Substring(UserInputLines[101].IndexOf(","));
            TrackbarValue = TrackbarValue.Substring(TrackbarValue.IndexOf("\"") + 5);
            Program.MainWindow.CustomFoV2Trackbar.Value = Int16.Parse(TrackbarValue.Substring(0, TrackbarValue.IndexOf("\"")));
            Program.MainWindow.CustomFoV2ValueLabel.Text = Program.MainWindow.CustomFoV2Trackbar.Value.ToString();
            // Custom Command
            Program.MainWindow.CustomCommandButton.Text = TrimLine(UserInputLines[102]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.CustomCommandButton);
            // Centre Camera
            Program.MainWindow.CentreCameraButton.Text = TrimLine(UserInputLines[103]);
            Program.InputHandler.ButtonList.Add(Program.MainWindow.CentreCameraButton);
            // Mouse Sensitivity
            Program.MainWindow.MouseSensitivityTrackbar.Value = Int16.Parse(BmInputLines[0].Substring(0, BmInputLines[0].LastIndexOf(".")));
            Program.MainWindow.MouseSensitivityValueLabel.Text = BmInputLines[0].Substring(0, BmInputLines[0].LastIndexOf("."));
            // Mouse Smoothing
            if (BmInputLines[1].Equals("true"))
            {
                Program.MainWindow.MouseSmoothingBox.Checked = true;
            }
            else
            {
                Program.MainWindow.MouseSmoothingBox.Checked = false;
            }
        }

        private string TrimLine(string Line)
        {
            string NewLine;
            try
            {
                NewLine = Line.Substring(17);
            }
            catch (ArgumentOutOfRangeException)
            {
                NewLine = Line;
            }

            if (Line.Contains("Shift=true") && !Line.Contains("bIgnoreShift=true"))
            {
                return "Shift + " + ConvertLine(NewLine.Substring(0, NewLine.IndexOf("\"")));
            }
            if (Line.Contains("Control=true"))
            {
                return "Ctrl + " + ConvertLine(NewLine.Substring(0, NewLine.IndexOf("\"")));
            }
            if (Line.Contains("Alt=true"))
            {
                return "Alt + " + ConvertLine(NewLine.Substring(0, NewLine.IndexOf("\"")));
            }
            return ConvertLine(NewLine.Substring(0, NewLine.IndexOf("\"")));
        }

        private string ConvertLine(string Input)
        {
            for (int i = 0; i < Program.InputHandler.LinesConfigStyle.Length; i++)
            {
                if (Input == Program.InputHandler.LinesConfigStyle[i])
                {
                    return Program.InputHandler.LinesHumanReadable[i];
                }
            }
            return Input;
        }
    }
}
