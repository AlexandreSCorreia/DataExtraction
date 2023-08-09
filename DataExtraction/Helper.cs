using System;
using System.Globalization;

namespace DataExtraction
{
    public static class Helper
    {
        public static string VerificaSeEData(string value)
        {
            if (IsDate(value))
            {
                return ConvertToCorrectDateFormat(value).ToString("yyyy-MM-dd");
            }

            return value;
        }

        public static bool IsDate(string input)
        {
            string[] dateFormats = { "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "MM/dd/yyyy", "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy" };

            if (DateTime.TryParseExact(input, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }

            return false;
        }

        public static DateTime ConvertToCorrectDateFormat(string inputDate)
        {
            string[] dateFormats = { "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };

            if (!DateTime.TryParseExact(inputDate, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                if (!DateTime.TryParse(inputDate, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                {
                    throw new ArgumentException("Invalid date");
                }
            }

            return result;
        }
    }
}
