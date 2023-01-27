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
        internal static string RemoveCurrencyStyle(this string currency)
        {
            try
            {
                return currency.Replace(",", string.Empty);
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
                currency = currency.RemoveCurrencyStyle();
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
                currency = currency.RemoveCurrencyStyle();
                return Convert.ToUInt64(currency);
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
                currency = currency.RemoveCurrencyStyle();
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
                currency = currency.RemoveCurrencyStyle();
                return Convert.ToInt32(currency);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
