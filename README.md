# Batman: Arkham City - Advanced Launcher

This is a replacement application for the original BmLauncher.exe of the game. Alongside vastly superior configuration options, this Launcher also offers:

- Tooltips for every configuration option
- Option to toggle Startup Movies
- Very high customizability
- Color settings (Including color palette presets)
- Two pre-made color profiles for HDR injection
- Keybind option for [Catwoman's "Quickfire Disarm"](https://www.pcgamingwiki.com/wiki/Batman:_Arkham_City#Fix_for_Catwoman.27s_Quickfire_Disarm_key_missing_on_keyboard)
- Automatic DirectX11 Lighting Bug Fix (No actions needed. It happens in the background!)
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

Drag the contents of the .zip file into the 'Batman Arkham City GOTY\Binaries\Win32' folder.

To find this folder for the *Steam* version, just right-click the game in Steam, select Properties->Local Files->Browse Local Files and navigate from there.

To find it for the *EGS* version, right-click the game and select "Manage". Then click the folder icon in the "Installation" tab and navigate from there.

For the *GOG* version, click the icon next to the PLAY button and select "Manage installation->Show folder" and navigate from there.

## Guide for Linux users

There seems to be an issue executing the program using Wine, as their .NET 6 implementation isn't complete yet and there are some bugs with Mono.
To bypass these issues and run the launcher anyway, a small workaround is required.

Firstly, make sure you have **[`Wine-Staging`](https://wiki.winehq.org/Wine-Staging)** installed.

### Install Wine-Staging

**Debian/Ubuntu 64-Bit Setup**:
- If you run 64-Bit Debian or Ubuntu, execute `sudo dpkg --add-architecture i386` before proceeding.

**Ubuntu/Debian/Fedora/PopOS/Linux Mint/etc.**:
- Use [Lutris](https://lutris.net/) or [PlayOnLinux](https://www.playonlinux.com/). Make sure to install `Wine-Gecko` and `Wine-Mono` through either of these programs as well.
- Install `Winetricks` if it does not exist already. Either via your package manager or [manually](https://github.com/Winetricks/winetricks).
**SteamOS/Arch Linux\***: 
- Simply run: `sudo pacman -Syu wine-staging wine-mono wine-gecko winetricks`

*SteamOS and Arch Linux can also use Lutris.

### Configure Winetricks

After installing Wine-Staging, run the following Winetricks commands in this exact order:

`winetricks -q dotnet48 calibri impact`

`winetricks renderer=vulkan`

`wine reg.exe COPY "HKLM\SYSTEM\CurrentControlSet" "HKLM\SYSTEM\ControlSet001" /s /f`

Lastly, make sure you are using the **standalone, dependency free** executable.

## Bug Reports

To file a bug report, or if you have suggestions for the Launcher in general, please file an [issue](https://github.com/neatodev/CityLauncher/issues/new). I read these regularly and should normally be able to respond within a day. Please also include the most recent citylauncher_report in the issue (if available). You can find the reports in the 'Batman Arkham City GOTY\Binaries\Win32\logs' folder.

#### License

[![CC BY 4.0][cc-by-shield]][cc-by]

[cc-by]: https://creativecommons.org/licenses/by-nc-sa/4.0/
[cc-by-shield]: https://licensebuttons.net/l/by-nc-sa/4.0/80x15.png
