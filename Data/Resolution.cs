using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using NLog;

namespace CityLauncher
{
    internal class Resolution
    {

        private static Logger Nlog = LogManager.GetCurrentClassLogger();


        // string list to store resolution values
        public static List<string>? ResolutionList
        {
            get { return new List<string>(); }
            private set { ResolutionList = value; }
        }

        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(
            string deviceName, int modeNum, ref DEVMODE devMode);

        /// <summary>
        ///     Getter for user resolutions.
        ///     Called by Program upon application start.
        /// </summary>
        public void getResolutions()
        {
            List<string> TempList = new List<string>();
            DEVMODE vDevMode = new DEVMODE();
            int i = 0;
            while (EnumDisplaySettings(null, i, ref vDevMode))
            {
                TempList.Add(vDevMode.dmPelsWidth + "x" + vDevMode.dmPelsHeight);
                i++;
            }

            int MaxLength = TempList.Max(x => x.Length);
            IOrderedEnumerable<string> orderedList = TempList.OrderBy(x => x.PadLeft(MaxLength, '0'));
            ResolutionList = orderedList.Distinct().ToList();
            Nlog.Debug("getResolutions - found a total of {0} available resolutions.", ResolutionList.Count);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            private const int Cchdevicename = 0x20;
            private const int Cchformname = 0x20;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;

            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;

            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }
    }

}
