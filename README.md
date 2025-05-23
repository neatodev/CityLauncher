# Batman: Arkham City - Advanced Launcher

This is a replacement application for the original BmLauncher.exe of the game. Alongside vastly superior configuration options, this Launcher also offers:

- Tooltips for every configuration option
- Option to toggle Startup Movies
- Very high customizability
- Color settings (Including color palette presets)
- Two pre-made color profiles for HDR injection
- Keybind option for [Catwoman's "Quickfire Disarm"](https://www.pcgamingwiki.com/wiki/Batman:_Arkham_City#Fix_for_Catwoman.27s_Quickfire_Disarm_key_missing_on_keyboard)
- Option to boot directly into the game, skipping launcher screen
- Automatic DirectX11 Lighting Bug Fix (No action needed. It happens automatically!)
- Customizable Field of View Hotkeys
- Compatibility Fixes for [HD Texture Packs](https://www.nexusmods.com/batmanarkhamcity/mods/407)
- Extensive Logging Functionality (Powered by [NLog](https://github.com/NLog/NLog))
- ... and more!

Supports the GOTY version on STEAM, GOG and EPIC GAMES.

**This Application is built with .NET 8**. If you are using Windows 10 and above you shouldn't have any issues simply running the program. Some users might need to install [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) manually.

A standalone, dependency free executable is also available.

## Preview

![CityLauncher Preview](https://github.com/user-attachments/assets/67fb3906-6c47-4d63-a81e-5b5261c0f2f9)

## Download

**[Download the latest version on Nexusmods](https://www.nexusmods.com/batmanarkhamcity/mods/406)**

If you like this application, please consider [donating](https://ko-fi.com/neatodev).

[![Donate](https://shields.io/badge/Kofi-Donate!-ff5f5f?logo=ko-fi&style=for-the-badgeKofi)](https://ko-fi.com/neatodev)


## Installation

Drag the contents of the .zip file into the **'Batman Arkham City GOTY\Binaries\Win32'** folder.

To find this folder for the ***Steam*** version, just right-click the game in Steam, select Properties->Local Files->Browse Local Files and navigate from there.

To find it for the ***EGS*** version, right-click the game and select "Manage". Then click the folder icon in the "Installation" tab and navigate from there.

For the ***GOG*** version, click the icon next to the PLAY button and select "Manage installation->Show folder" and navigate from there.

## Usage

You can just launch your game via Steam, GOG or EGS as you normally would, though in some cases you might need to unblock the BmLauncher application for it to work properly.

Once you're happy with your settings, **you can skip the launcher entirely by using the `-nolauncher` launch option.**

- On ***EGS*** you can do this by going into Settings->Arkham City>Additional Command Line Arguments. 
- On ***GOG GALAXY*** you have to select Customize->Manage Installation->Configure, enable Launch parameters, select Duplicate. It should be added under Additional executables.
- If you use a shortcut in Windows, right click->Properties->Shortcut and add it at the end of Target.
- ***Not necessary for Steam***, which already has built-in launcher skipping for this game. 


## Info for Linux users

Install the **Calibri** and **Impact** fonts for your Wine environment so you don't encounter any display issues.

`winetricks -q calibri impact`


## Bug Reports

To file a bug report, or if you have suggestions for the Launcher in general, please file an [issue](https://github.com/neatodev/CityLauncher/issues/new). I read these regularly and should normally be able to respond within a reasonable amount of time. Please also include the most recent citylauncher_report in the issue (if available). You can find the reports in the 'Batman Arkham City GOTY\Binaries\Win32\logs' folder.

##### License: [![CC BY 4.0][cc-by-shield]][cc-by]

[cc-by]: https://creativecommons.org/licenses/by-nc-sa/4.0/
[cc-by-shield]: https://licensebuttons.net/l/by-nc-sa/4.0/80x15.png
