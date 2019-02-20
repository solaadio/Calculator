using System;

namespace Calculator.Library.Extensions
{
    public static class StringExtensions
    {
        public static string FormatWithThousandsSeparator(this string myNumber)
        {
            if (string.IsNullOrEmpty(myNumber))
            {
                return myNumber;
            }

            string strNumberWithoutDecimals;
            string strNumberDecimals;
            string strNegativeSign = "";

            if (myNumber.Contains("."))
            {
                if (myNumber.Substring(0, 1) == "-")
                {
                    strNegativeSign = "-";
                    strNumberWithoutDecimals = myNumber.Substring(1, myNumber.IndexOf(".", StringComparison.Ordinal)-1);
                }
                else
                {
                    strNumberWithoutDecimals = myNumber.Substring(0, myNumber.IndexOf(".", StringComparison.Ordinal));
                }
                strNumberDecimals = myNumber.Substring(myNumber.IndexOf(".", StringComparison.Ordinal));

            }
            else
            {
                strNumberWithoutDecimals = myNumber;
                strNumberDecimals = "";
            }

            strNumberWithoutDecimals = Convert.ToInt64(strNumberWithoutDecimals.Replace(",","")).ToString("#,##0");
            return strNegativeSign + strNumberWithoutDecimals + strNumberDecimals;
        }
    }
}
