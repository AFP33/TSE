using System.Collections.Generic;
using System.Linq;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Common
{
    internal static class StringExtensions
    {
        /// <summary>
        /// checking if string is null, whitespace, or empty
        /// </summary>
        /// <param name="str">input</param>
        /// <returns></returns>
        internal static bool IsEmpty(this string str)
        {
            if (str == string.Empty || string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return true;
            return false;
        }

        /// <summary>
        /// remove currency style
        /// </summary>
        /// <param name="currency">currency in style like: 999,999,999</param>
        /// <returns>return like 999999999</returns>
        internal static string RemoveStyle(this string currency)
        {
            try
            {
                return currency
                    .Replace(",", string.Empty)
                    .Replace(" ", string.Empty)
                    .Replace("(", string.Empty)
                    .Replace(")", string.Empty);
            }
            catch (Exception)
            {
                return "0";
            }
        }

        /// <summary>
        /// convert string to decimal number
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        internal static decimal ToDecimal(this string currency)
        {
            try
            {
                if (currency.IsEmpty())
                    return 0;
                currency = currency.RemoveStyle();
                currency = currency.PersianToEnglish();
                return Convert.ToDecimal(currency);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// converte string to unsigned long
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        internal static ulong ToUlong(this string currency)
        {
            try
            {
                if (currency.IsEmpty())
                    return 0;
                currency = currency.RemoveStyle();
                currency = currency.PersianToEnglish();
                return Convert.ToUInt64(currency);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// converte string to long
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        internal static long ToLong(this string currency)
        {
            try
            {
                if (currency.IsEmpty())
                    return 0;
                var negetiveStatus = currency.IsNegetive();
                currency = currency.RemoveStyle();
                currency = currency.PersianToEnglish();
                if (negetiveStatus)
                    return Convert.ToInt64(currency) * -1;
                return Convert.ToInt64(currency);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// convert string to double
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        internal static double ToDouble(this string currency)
        {
            try
            {
                if (currency.IsEmpty())
                    return 0;
                currency = currency.RemoveStyle();
                currency = currency.PersianToEnglish();
                return Convert.ToDouble(currency);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// convert string to int
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        internal static int ToInt(this string currency)
        {
            try
            {
                if (currency.IsEmpty())
                    return 0;
                var negetiveStatus = currency.IsNegetive();
                currency = currency.RemoveStyle();
                currency = currency.PersianToEnglish();
                if (negetiveStatus)
                    return Convert.ToInt32(currency) * -1;
                return Convert.ToInt32(currency);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Persian number format to english number format
        /// </summary>
        /// <param name="persianStr">Persian number format</param>
        /// <returns></returns>
        internal static string PersianToEnglish(this string persianStr)
        {
            try
            {
                Dictionary<char, char> LettersDictionary = new Dictionary<char, char>
                {
                    ['۰'] = '0',
                    ['۱'] = '1',
                    ['۲'] = '2',
                    ['۳'] = '3',
                    ['۴'] = '4',
                    ['۵'] = '5',
                    ['۶'] = '6',
                    ['۷'] = '7',
                    ['۸'] = '8',
                    ['۹'] = '9'
                };
                foreach (var item in persianStr)
                    persianStr = persianStr.Replace(item, LettersDictionary[item]);
                return persianStr;
            }
            catch (Exception)
            {
                return persianStr;
            }
        }

        /// <summary>
        /// Checking if number is negetive number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        internal static bool IsNegetive(this string number)
        {
            try
            {
                if (number.Contains('(') && number.Contains(')'))
                    return true;

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
