using System;
using Tse.Entities;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Common
{
    internal class Useful
    {
        /// <summary>
        /// Changging grogorian date to Persian date
        /// </summary>
        /// <param name="grogorianDate">grogorian date, it's has 'yyyymmdd' format</param>
        /// <returns>string of persian date</returns>
        internal static string GregorianDateToPersianDate(string grogorianDate)
        {
            if (grogorianDate.IsEmpty())
                return "";

            var parsedDate = DateTime.Parse(grogorianDate.Substring(0, 4) + "-" + grogorianDate.Substring(4, 2) + "-" + grogorianDate.Substring(6, 2));
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            string year = persianCalendar.GetYear(parsedDate).ToString();
            string month = persianCalendar.GetMonth(parsedDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(parsedDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }

        /// <summary>
        /// Get market status (open or close)
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        internal static MarketStatus GetMarketStatus(string status)
        {
            try
            {
                if (status.Contains("بسته"))
                    return MarketStatus.Close;
                else if (status.Contains("باز"))
                    return MarketStatus.Open;

                throw new ArgumentOutOfRangeException(nameof(status));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
