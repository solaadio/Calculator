using Xamarin.Forms;

namespace Calculator.Library
{
    /// <summary>
    /// SharedResources - a bunch of constants for the font sizes and color in the Xaml
    /// </summary>
    public static class SharedResources
    {
        public static Color OpButtonBkColor => Color.FromRgb(0xff, 0xa5, 0);

        public static string AndroidButtonFontSize => "42";

        public static string IosButtonFontSize => "42";

        public static string UwpButtonFontSize => "42";

        public static string AndroidLabelFontSize => "30";

        public static string IosLabelFontSize => "30";

        public static string UwpLabelFontSize => "30";

        public static string AndroidHistoryLabelFontSize => "20";

        public static string IosHistoryLabelFontSize => "20";

        public static string UwpHistoryLabelFontSize => "20";

    }
}
