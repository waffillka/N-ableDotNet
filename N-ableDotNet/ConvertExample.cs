using System;

namespace N_ableDotNet
{
    public static class ConvertExample
    {
        public const decimal USDRate = 2.589m;

        public static int ConvertDoubleToInt(double dNumber)
        {
            return Convert.ToInt32(dNumber);
        }

        public static int? ConvertStringToInt(string sNumber)
        {
            int numer = 0;

            if (int.TryParse(sNumber, out numer))
            {
                return numer;
            }

            return null;
        }

        public static int ConvertFloatToInt(float fNumber)
        {
            return Convert.ToInt32(fNumber);
        }

        public static string ConvertDataTimeToString(DateTime data, string format = "d")
        {
            return data.ToString(format);
        }

        public static decimal ConvertBYNtoUSD(decimal byn)
        {
            return byn / USDRate;
        }
    }
}
