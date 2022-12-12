using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDesktop.Colours
{
    internal static class ZooBazaarColors
    {

        #region Nested classes
        internal static class ZoneColors
        {
            public static Color Arctic => Color.Aqua;
            public static Color Savannah => Color.FromArgb(255, 121, 0);
            public static Color Jungle => Color.Green;
            public static Color Desert => Color.LightGoldenrodYellow;
            public static Color Taiga => Color.RosyBrown;
        }

        internal class StatusColors
        {
            public static Color InZoo => Color.LightGreen;
            public static Color Deceased => Color.Gainsboro;
            public static Color Transferred => Color.LightBlue;
            public static Color Released => Color.LightYellow;
        }

        internal class ContractColors
        {
            public static Color PartTime => Color.Cyan;
            public static Color FullTime => Color.LightGreen;
            public static Color ZeroTime => Color.Goldenrod;
        }

        internal class ShiftColors
        {
            public static Color NoEmployees => Color.IndianRed;
            public static Color NotEnough => Color.Yellow;
            public static Color ExactlyEnough => Color.Green;
            public static Color MoreThanEnough => Color.LightBlue;
        }

        #endregion
    }
}
