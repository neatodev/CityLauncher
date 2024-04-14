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
- Compatibility Fixes for [HD Texture Packs](https://steamcommunity.com/sharedfiles/filedetails/?id=1188257825)
- Extensive Logging Functionality (Powered by [NLog](https://github.com/NLog/NLog))
- ... and more!

Supports the GOTY version on STEAM, GOG and EPIC GAMES.

**This Application is built with .NET 6**. If you are using Windows 10 and above you shouldn't have any issues simply running the program. Some users might need to install [.NET 6 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) manually.

A standalone, dependency free executable is also available.

## Preview

![CityLauncher Preview](https://user-images.githubusercontent.com/49599979/201522680-351ff4fb-92b9-4ce5-8193-f30a68c36d06.png)

## Download

**Download: [Current Release](https://github.com/neatodev/CityLauncher/releases/latest)** or **[visit Nexusmods](https://www.nexusmods.com/batmanarkhamcity/mods/406)**

If you like this application, please consider donating.

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/donate/?hosted_button_id=LG7YTKP4JYN5S)

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
