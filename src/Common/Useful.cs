using System.Globalization;
using Tse.Entities;
using System;

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
        internal static DateTime? GregorianDateToPersianDate(string grogorianDate)
        {
            try
            {
                if (grogorianDate.IsEmpty())
                    return null;

                return DateTime.Parse(grogorianDate.Substring(0, 4) + "-"
                    + grogorianDate.Substring(4, 2) + "-"
                    + grogorianDate.Substring(6, 2));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// get DateTime from persian date
        /// </summary>
        /// <param name="persianDate">must has format like 1401/11/30</param>
        /// <returns></returns>
        internal static DateTime? GetDateTimeFromPersianDate(string persianDate)
        {
            try
            {
                if (persianDate.IsEmpty())
                    return null;

                persianDate = persianDate.RemoveStyle();
                CultureInfo persianCulture = new CultureInfo("fa-IR");
                return DateTime.ParseExact(persianDate,
                    "yyyy/MM/dd", persianCulture);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// convert persian date time to DateTime
        /// </summary>
        /// <param name="persianDate">persian date has format like: "96/09/10 12:12"</param>
        /// <returns></returns>
        internal static DateTime? GetDateTimeFromPersianDateTime(string persianDate)
        {
            try
            {
                if (persianDate.IsEmpty())
                    return null;

                return Convert.ToDateTime(persianDate, new CultureInfo("fa-IR"));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// string time span to TimeSpan
        /// </summary>
        /// <param name="timeSpan">should be like: 08:00</param>
        /// <returns></returns>
        internal static TimeSpan? ToTimeSpan(string timeSpan)
        {
            try
            {
                return TimeSpan.Parse(timeSpan.RemoveStyle());
            }
            catch (Exception)
            {
                return null;
            }
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

        /// <summary>
        /// Get Audit string value to boolean
        /// </summary>
        /// <param name="audit">audit string value</param>
        /// <returns></returns>
        internal static bool GetAuditStatus(string audit)
        {
            if (audit == "(حسابرسی نشده)")
                return false;
            else if (audit == "(حسابرسی شده)")
                return true;

            return false;
        }
    }
}
