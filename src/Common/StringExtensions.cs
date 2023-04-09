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
    public static class StringExtensions
    {
        /// <summary>
        /// checking if string is null, whitespace, or empty
        /// </summary>
        /// <param name="str">input</param>
        /// <returns></returns>
        public static bool IsEmpty(this string str)
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
        public static string RemoveStyle(this string currency)
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
        public static decimal ToDecimal(this string currency)
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
        public static ulong ToUlong(this string currency)
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
        public static long ToLong(this string currency)
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
        public static double ToDouble(this string currency)
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
        public static int ToInt(this string currency)
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
        /// <param name="data">Persian number format</param>
        /// <returns></returns>
        public static string PersianToEnglish(this string data)
        {
            if (data is null)
            {
                return string.Empty;
            }

            var dataChars = data.ToCharArray();
            for (var i = 0; i < dataChars.Length; i++)
            {
                switch (dataChars[i])
                {
                    case '\u06F0':
                    case '\u0660':
                        dataChars[i] = '0';
                        break;

                    case '\u06F1':
                    case '\u0661':
                        dataChars[i] = '1';
                        break;

                    case '\u06F2':
                    case '\u0662':
                        dataChars[i] = '2';
                        break;

                    case '\u06F3':
                    case '\u0663':
                        dataChars[i] = '3';
                        break;

                    case '\u06F4':
                    case '\u0664':
                        dataChars[i] = '4';
                        break;

                    case '\u06F5':
                    case '\u0665':
                        dataChars[i] = '5';
                        break;

                    case '\u06F6':
                    case '\u0666':
                        dataChars[i] = '6';
                        break;

                    case '\u06F7':
                    case '\u0667':
                        dataChars[i] = '7';
                        break;

                    case '\u06F8':
                    case '\u0668':
                        dataChars[i] = '8';
                        break;

                    case '\u06F9':
                    case '\u0669':
                        dataChars[i] = '9';
                        break;
                }
            }

            return new string(dataChars);
        }

        /// <summary>
        /// Checking if number is negetive number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsNegetive(this string number)
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
