using System;
using Xamarin.Forms;
namespace Calculator.Libraries
{
    public static class SharedResources
    {
        public static Color OpButtonBkColor
        {
            get { return Color.FromRgb(0xff, 0xa5, 0); }
        }

        public static String AndroidButtonFontSize
        {
            get { return "42"; }
        }

        public static String IOSButtonFontSize
        {
            get { return "42"; }
        }

        public static String UWPButtonFontSize
        {
            get { return "42"; }
        }

        public static String AndroidLabelFontSize
        {
            get { return "64"; }
        }

        public static String IOSLabelFontSize
        {
            get { return "64"; }
        }

        public static String UWPLabelFontSize
        {
            get { return "64"; }
        }
    }
}
