namespace CityLauncher
{
    internal class InputReader
    {
        private string[] UserInputLines;
        private string[] BmInputLines = { "", "" };

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
            // Backward
            Program.MainWindow.BwButton1.Text = TrimLine(UserInputLines[6]);
            // Left
            Program.MainWindow.LeftButton1.Text = TrimLine(UserInputLines[7]);
            // Right
            Program.MainWindow.RightButton1.Text = TrimLine(UserInputLines[8]);
            // Run/Glide/Use
            Program.MainWindow.RGUButton1.Text = TrimLine(UserInputLines[9]);
            // Crouch
            Program.MainWindow.CrouchButton1.Text = TrimLine(UserInputLines[10]);
            // Zoom
            Program.MainWindow.ZoomButton1.Text = TrimLine(UserInputLines[11]);
            // Grapple
            Program.MainWindow.GrappleButton1.Text = TrimLine(UserInputLines[12]);
            // Toggle Crouch
            Program.MainWindow.ToggleCrouchButton1.Text = TrimLine(UserInputLines[13]);
            // Detective Mode
            Program.MainWindow.DetectiveModeButton1.Text = TrimLine(UserInputLines[14]);
            // Gadget/Strike
            Program.MainWindow.UseGadgetStrikeButton1.Text = TrimLine(UserInputLines[15]);
            // Aim Gadget/Counter/Takedown
            Program.MainWindow.ACTButton1.Text = TrimLine(UserInputLines[18]);
            // Gadget Secondary/Cape Stun
            Program.MainWindow.GadgetSecButton1.Text = TrimLine(UserInputLines[21]);
            // Previous Gadget
            Program.MainWindow.PrevGadgetButton1.Text = TrimLine(UserInputLines[24]);
            // Next Gadget
            Program.MainWindow.NextGadgetButton1.Text = TrimLine(UserInputLines[25]);
            // Special Combo Takedown
            Program.MainWindow.SCTButton1.Text = TrimLine(UserInputLines[26]);
            // Special Combo Bat Swarm
            Program.MainWindow.SCBSButton1.Text = TrimLine(UserInputLines[27]);
            // Special Combo Multi Ground Takedown
            Program.MainWindow.MultiGroundTDButton1.Text = TrimLine(UserInputLines[28]);
            // Special Combo Disarm and Destroy
            Program.MainWindow.DisarmDestroyButton1.Text = TrimLine(UserInputLines[29]);
            // Gadget 1
            Program.MainWindow.Gadget1Button1.Text = TrimLine(UserInputLines[30]);
            // Gadget 2
            Program.MainWindow.Gadget2Button1.Text = TrimLine(UserInputLines[31]);
            // Gadget 3
            Program.MainWindow.Gadget3Button1.Text = TrimLine(UserInputLines[32]);
            // Gadget 4
            Program.MainWindow.Gadget4Button1.Text = TrimLine(UserInputLines[33]);
            // Gadget 5
            Program.MainWindow.Gadget5Button1.Text = TrimLine(UserInputLines[34]);
            // Gadget 6
            Program.MainWindow.Gadget6Button1.Text = TrimLine(UserInputLines[35]);
            // Gadget 7
            Program.MainWindow.Gadget7Button1.Text = TrimLine(UserInputLines[36]);
            // Gadget 8
            Program.MainWindow.Gadget8Button1.Text = TrimLine(UserInputLines[37]);
            // Gadget 9
            Program.MainWindow.Gadget9Button1.Text = TrimLine(UserInputLines[38]);
            // Gadget 10
            Program.MainWindow.Gadget10Button1.Text = TrimLine(UserInputLines[39]);
            // Gadget 11
            Program.MainWindow.Gadget11Button1.Text = TrimLine(UserInputLines[40]);
            // Gadget 12
            Program.MainWindow.Gadget12Button1.Text = TrimLine(UserInputLines[41]);
            // Quickfire Gadget 1
            Program.MainWindow.QFireGadget1Button1.Text = TrimLine(UserInputLines[42]);
            // Quickfire Gadget 2
            Program.MainWindow.QFireGadget2Button1.Text = TrimLine(UserInputLines[43]);
            // Quickfire Gadget 3
            Program.MainWindow.QFireGadget3Button1.Text = TrimLine(UserInputLines[44]);
            // Quickfire Gadget 4
            Program.MainWindow.QFireGadget4Button1.Text = TrimLine(UserInputLines[45]);
            // Quickfire Gadget 5
            Program.MainWindow.QFireGadget5Button1.Text = TrimLine(UserInputLines[46]);
            // Catwoman Disarm Fix
            Program.MainWindow.CWDisarmFixButton1.Text = TrimLine(UserInputLines[91]);
            // Speedrun Setting
            Program.MainWindow.SpeedRunButton.Text = TrimLine(UserInputLines[94]);
            // Open Console
            Program.MainWindow.OpenConsoleButton.Text = TrimLine(UserInputLines[97]);
            // Toggle HUD
            Program.MainWindow.ToggleHudButton.Text = TrimLine(UserInputLines[98]);
            // Reset FoV
            Program.MainWindow.ResetFoVButton.Text = TrimLine(UserInputLines[99]);
            // Custom FoV 1
            Program.MainWindow.CustomFoV1Button.Text = TrimLine(UserInputLines[100]);
            // Custom FoV 1 Slider
            Program.MainWindow.CustomFoV1Trackbar.Value = Int16.Parse(TrimLine(UserInputLines[100].Substring(39)));
            Program.MainWindow.CustomFoV1ValueLabel.Text = Program.MainWindow.CustomFoV1Trackbar.Value.ToString();
            // Custom FoV 2
            Program.MainWindow.CustomFoV2Button.Text = TrimLine(UserInputLines[101]);
            // Custom FoV 2 Slider
            Program.MainWindow.CustomFoV2Trackbar.Value = Int16.Parse(TrimLine(UserInputLines[101].Substring(39)));
            Program.MainWindow.CustomFoV2ValueLabel.Text = Program.MainWindow.CustomFoV2Trackbar.Value.ToString();
            // Custom Command
            Program.MainWindow.CustomCommandButton.Text = TrimLine(UserInputLines[101]);
            // Centre Camera
            Program.MainWindow.CentreCameraButton.Text = TrimLine(UserInputLines[102]);
            // Mouse Sensitivity
            Program.MainWindow.MouseSensitivityTrackbar.Value = Int16.Parse(BmInputLines[0].Substring(0, BmInputLines[0].LastIndexOf(".")));
            Program.MainWindow.MouseSensitivityValueLabel.Text = BmInputLines[0].Substring(0, BmInputLines[0].LastIndexOf("."));
            // Mouse Smoothing
            if (UserInputLines[1].Equals("true"))
            {
                Program.MainWindow.MouseSmoothingBox.Checked = true;
            } else
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
                return "Shift + " + NewLine.Substring(0, NewLine.IndexOf("\""));
            }
            if (Line.Contains("Control=true"))
            {
                return "CTRL + " + NewLine.Substring(0, NewLine.IndexOf("\""));

            }
            if (Line.Contains("Alt=true"))
            {
                return "ALT + " + NewLine.Substring(0, NewLine.IndexOf("\""));
            }
            return NewLine.Substring(0, NewLine.IndexOf("\""));
        }
    }
}
