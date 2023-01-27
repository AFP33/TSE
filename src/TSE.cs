using Tse.Entities;
using Tse.Handlers;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse
{
    public class TSE
    {
        public TSE()
        {
        }

        /// <summary>
        /// دریافت یک دستگیره برای کار با یک نماد خاص
        /// </summary>
        /// <param name="stock">سهم مد نظر</param>
        /// <returns>دستگیره ای برای دریافت اطلاعات آن نماد</returns>
        public StockHandler GetStockHandler(Stock stock)
        {
            try
            {
                return new StockHandler(stock);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// دریافت یک دستگیره برای کار با اطلاعات مارکت
        /// </summary>
        /// <returns></returns>
        public MarketHandler GetMarketHandler()
        {
            try
            {
                return new MarketHandler();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// دریافت یک دستگیره برای کار با اطلاعات مارکت بورس و اوراق بهادار تهران
        /// </summary>
        /// <returns></returns>
        public BourseHandler GetBourseHandler()
        {
            try
            {
                return new BourseHandler();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// دریافت یک دستگیره برای کار با اطلاعات مارکت فرابورس ایران
        /// </summary>
        /// <returns></returns>
        public FarabourseHandler GetFaraourseHandler()
        {
            try
            {
                return new FarabourseHandler();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
