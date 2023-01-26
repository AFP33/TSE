using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Common
{
    internal class Useful
    {/// <summary>
     /// Changging grogorian date to Persian date
     /// </summary>
     /// <param name="grogorianDate">grogorian date, it's has 'yyyymmdd' format</param>
     /// <returns>string of persian date</returns>
        internal static string GregorianDateToPersianDate(string grogorianDate)
        {
            if (IsNullString(grogorianDate))
                return "";

            var parsedDate = DateTime.Parse(grogorianDate.Substring(0, 4) + "-" + grogorianDate.Substring(4, 2) + "-" + grogorianDate.Substring(6, 2));
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            string year = persianCalendar.GetYear(parsedDate).ToString();
            string month = persianCalendar.GetMonth(parsedDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(parsedDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }

        internal static bool IsNullString(string str)
        {
            if (str == string.Empty || string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return true;
            return false;
        }
    }
}
