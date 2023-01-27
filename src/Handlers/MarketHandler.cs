using System.Collections.Generic;
using Tse.Controller.Markets;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Handlers
{
    /// <summary>
    /// دستگیره ای برای دریافت اطلاعات مارکت
    /// </summary>
    public class MarketHandler : IHandler
    {

        /// <summary>
        /// جستجوی نماد
        /// </summary>
        /// <param name="name">نام شرکت، نماد یا بخشی از هر کدام</param>
        /// <returns>لیستی از نمادهای پیدا شده براساس ورودی</returns>
        public IList<Stock> FindStock(string name)
        {
            try
            {
                return new SearchStockController(name).Get();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// دریافت لیست همه نمادهای بازار
        /// </summary>
        /// <returns></returns>
        public IList<Stock> Stocks
        {
            get
            {
                try
                {
                    return new StocksController().Get();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت لیست همه صنایع موجود
        /// </summary>
        /// <returns>کلید آی آن صنعت، و مقدار نام آن صنعت می باشد</returns>
        public IDictionary<string, string> Industries 
        { 
            get 
            {
                try
                {
                    return new IndustryController().Get();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}