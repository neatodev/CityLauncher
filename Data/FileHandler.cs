﻿using CityLauncher.Properties;
using NLog;

namespace CityLauncher
{
    internal class FileHandler
    {
        private bool IntroFilesRenamed;
        private readonly string CustomDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Custom");
        private readonly string Startup = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf");
        private readonly string StartupNV = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf");
        private readonly string StartupRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\Startup.swf.bak");
        private readonly string StartupNVRenamed = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\Movies\\StartupNV.swf.bak");
        public readonly string ConfigDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config");

        public string BmEnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini");
        public string UserEnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserEngine.ini");
        public string BmInputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmInput.ini");
        public string UserInputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserInput.ini");
        private string BmGamePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmGame.ini");
        public FileInfo BmEngine = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmEngine.ini"));
        public FileInfo UserEngine = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\UserEngine.ini"));
        public FileInfo BmInput = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WB Games\\Batman Arkham City GOTY\\BmGame\\Config\\BmInput.ini"));

        private static readonly string ExeChecksumMD5_STEAM = "F18E985B0BE14210C9726C4A4EC8F5ED";
        private static readonly string ExeChecksumMD5_EPIC = "96830C0F0026C06D548A9F57ADEE8E32";
        private static readonly string ExeChecksumMD5_GOG = "6E8F9DE533738451F5166427CB378E0F";

        private static readonly Logger Nlog = LogManager.GetCurrentClassLogger();


        public FileHandler()
        {
            CheckConfigFilesExist();
            CheckCustomFilesExist();
            CheckIntroVideoFilesRenamed();
            InitCatwomanDLC();
            Nlog.Info("Constructor - Successfully initialized FileHandler.");
            CheckLightingFix();
        }

        private void CheckLightingFix()
        {
            if (DetectGameExe())
            {
                try
                {
                    FileInfo SM5File = new(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\CookedPCConsole\\GlobalShaderCache-PC-D3D-SM5.bin"));
                    if (SM5File.Length != Resources.GlobalShaderCache_PC_D3D_SM5.Length)
                    {
                        ReplaceLightingFiles();
                    }
                    else
                    {
                        Nlog.Info("CheckLightingFix - DX11 lighting bug is already fixed in your game!");
                    }

                }
                catch (FileNotFoundException)
                {
                    return;
                }
            }
        }

        private static void ReplaceLightingFiles()
        {
            File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\CookedPCConsole\\GlobalShaderCache-PC-D3D-SM3.bin"));
            File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\CookedPCConsole\\GlobalShaderCache-PC-D3D-SM5.bin"));
            File.WriteAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\CookedPCConsole\\GlobalShaderCache-PC-D3D-SM3.bin"), Resources.GlobalShaderCache_PC_D3D_SM3);
            File.WriteAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\BmGame\\CookedPCConsole\\GlobalShaderCache-PC-D3D-SM5.bin"), Resources.GlobalShaderCache_PC_D3D_SM5);
            Nlog.Info("ReplaceLightingFiles - Replaced files that caused a lighting bug in DX11 with working versions.");
        }

        private void CheckCustomFilesExist()
        {
            if (!Directory.Exists(CustomDirectoryPath))
            {
                Directory.CreateDirectory(CustomDirectoryPath);
                Nlog.Warn("CheckCustomFilesExist - Can't find the 'Custom' directory. Creating it now.");
            }

            if (!File.Exists(Path.Combine(CustomDirectoryPath, "centre_camera.txt")))
            {
                CreateConfigFile(Path.Combine(CustomDirectoryPath, "centre_camera.txt"), Resources.centre_camera);
                Nlog.Warn("CheckCustomFilesExist - Can't find the 'centre_camera.txt' file. Creating it now.");
            }

            if (!File.Exists(Path.Combine(CustomDirectoryPath, "custom_commands.txt")))
            {
                CreateConfigFile(Path.Combine(CustomDirectoryPath, "custom_commands.txt"), Resources.custom_commands);
                Nlog.Warn("CheckCustomFilesExist - Can't find the 'custom_commands.txt' file. Creating it now.");
            }
        }

        private void CheckConfigFilesExist()
        {
            if (!Directory.Exists(ConfigDirectoryPath))
            {
                Directory.CreateDirectory(ConfigDirectoryPath);
                Nlog.Warn("CheckConfigFilesExist - Can't find configuration directory. Creating it now. Please make sure you have installed the game.");
            }

            if (!File.Exists(BmEnginePath))
            {
                CreateConfigFile(BmEnginePath, Resources.BmEngine);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'BmEngine.ini'. Creating it now.");
            }

            if (!File.Exists(UserEnginePath))
            {
                CreateConfigFile(UserEnginePath, Resources.UserEngine);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'UserEngine.ini'. Creating it now.");
            }

            if (File.Exists(UserInputPath))
            {
                string[] UserLines = File.ReadAllLines(UserInputPath);
                if (UserLines.Length < 110)
                {
                    File.Delete(UserInputPath);
                    CreateConfigFile(UserInputPath, Resources.UserInput);
                    Nlog.Info("CheckConfigFilesExist - Overwriting the default 'UserInput.ini' file with a custom-made one.");
                }
            }
            else if (!File.Exists(UserInputPath))
            {
                CreateConfigFile(UserInputPath, Resources.UserInput);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'UserInput.ini'. Creating it now.");
            }
            if (File.Exists(BmInputPath))
            {
                BmInput.IsReadOnly = false;
                string[] BMLines = File.ReadAllLines(BmInputPath);
                if (BMLines.Length < 717)
                {
                    File.Delete(BmInputPath);
                    CreateConfigFile(BmInputPath, Resources.BmInput);
                    BmInput.IsReadOnly = true;
                    Nlog.Info("CheckConfigFilesExist - Overwriting the default 'BmInput.ini' file with a custom-made one.");
                }
            }
            else if (!File.Exists(BmInputPath))
            {
                CreateConfigFile(BmInputPath, Resources.BmInput);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'BmInput.ini'. Creating it now.");
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmCamera.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmCamera.ini"), Resources.BmCamera);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'BmCamera.ini'. Creating it now.");
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmCompat.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmCompat.ini"), Resources.BmCompat);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'BmCompat.ini'. Creating it now.");
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmGame.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmGame.ini"), Resources.BmGame);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'BmGame.ini'. Creating it now.");
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmLightmass.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmLightmass.ini"), Resources.BmLightmass);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'BmLightmass.ini'. Creating it now.");
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "BmUI.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "BmUI.ini"), Resources.BmUI);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'BmUI.ini'. Creating it now.");
            }

            if (!File.Exists(Path.Combine(ConfigDirectoryPath, "UserGame.ini")))
            {
                CreateConfigFile(Path.Combine(ConfigDirectoryPath, "UserGame.ini"), Resources.UserGame);
                Nlog.Warn("CheckConfigFilesExist - Can't find 'UserGame.ini'. Creating it now.");
            }
        }

        public void CreateConfigFile(string Path, string Resource)
        {
            File.Create(Path).Dispose();
            var FileWriter = new StreamWriter(Path);
            FileWriter.Write(Resource);
            FileWriter.Close();
        }

        public static bool DetectGameExe()
        {
            string GameExe = Path.Combine(Directory.GetCurrentDirectory(), "BatmanAC.exe");
            if (File.Exists(GameExe))
            {
                //string ExeChecksum = SetMD5(GameExe);
                //if (ExeChecksum == ExeChecksumMD5_STEAM || ExeChecksum == ExeChecksumMD5_EPIC || ExeChecksum == ExeChecksumMD5_GOG)
                //{
                //    return true;
                //}
                return true;
            }
            return false;
        }

        private void CheckIntroVideoFilesRenamed()
        {
            if (!DetectGameExe())
            {
                Program.MainWindow.SkipIntroBox.Enabled = false;
                return;
            }

            if (File.Exists(Startup) && File.Exists(StartupNV) && File.Exists(StartupRenamed) && File.Exists(StartupNVRenamed))
            {
                File.Delete(StartupRenamed);
                File.Delete(StartupNVRenamed);
                Program.MainWindow.SkipIntroBox.Enabled = true;
                Program.MainWindow.SkipIntroBox.Checked = false;
                IntroFilesRenamed = false;
            }

            if (File.Exists(Startup) && File.Exists(StartupNV))
            {
                Program.MainWindow.SkipIntroBox.Enabled = true;
                Program.MainWindow.SkipIntroBox.Checked = false;
                IntroFilesRenamed = false;
            }

            if (File.Exists(StartupRenamed) && File.Exists(StartupNVRenamed))
            {
                Program.MainWindow.SkipIntroBox.Enabled = true;
                Program.MainWindow.SkipIntroBox.Checked = true;
                IntroFilesRenamed = true;
            }
        }

        private void InitCatwomanDLC()
        {
            string[] BmGameLines = File.ReadAllLines(BmGamePath);
            foreach (string line in BmGameLines)
            {
                if (line.Equals("DLCBundlesInstalled=Catwoman")) 
                {
                    Program.MainWindow.CatwomanCheckbox.Checked = true;
                }
            }
        }

        public void ToggleCatwomanDLC(bool ShouldActivate)
        {
            string[] BmGameLines = File.ReadAllLines(BmGamePath);
            using (StreamWriter BmGameFile = new(BmGamePath))
            {
                if (ShouldActivate)
                {
                    foreach (string line in BmGameLines)
                    {
                        if (line.Contains("DLCBundlesInstalled=Catwoman"))
                        {
                            BmGameFile.WriteLine("DLCBundlesInstalled=Catwoman");
                        } else
                        {
                            BmGameFile.WriteLine(line);
                        }
                    }
                } 
                else
                {
                    foreach (string line in BmGameLines)
                    {
                        if (line.Contains("DLCBundlesInstalled=Catwoman"))
                        {
                            BmGameFile.WriteLine("\\\\DLCBundlesInstalled=Catwoman");
                        }
                        else
                        {
                            BmGameFile.WriteLine(line);
                        }
                    }
                }
                BmGameFile.Close();
            }
        }

        public void RenameIntroVideoFiles()
        {
            if (!Program.MainWindow.SkipIntroBox.Enabled || !Program.MainWindow.DisplaySettingChanged)
            {
                return;
            }

            if (!IntroFilesRenamed && Program.MainWindow.SkipIntroBox.Checked)
            {
                File.Move(Startup, StartupRenamed);
                File.Move(StartupNV, StartupNVRenamed);
                IntroFilesRenamed = !IntroFilesRenamed;
                Nlog.Info("RenameIntroVideoFiles - Disabling Startup Movies.");
            }
            else if (IntroFilesRenamed && !Program.MainWindow.SkipIntroBox.Checked)
            {
                File.Move(StartupRenamed, Startup);
                File.Move(StartupNVRenamed, StartupNV);
                IntroFilesRenamed = !IntroFilesRenamed;
                Nlog.Info("RenameIntroVideoFiles - Enabling Startup Movies.");
            }
        }

        private static string SetMD5(string ExeFile)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(ExeFile))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }
    }
}
