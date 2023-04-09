using System.Collections.Generic;
using Tse.Controller.Markets;
using Tse.Entities;
using System;
using System.Linq;
using Tse.Common;
using System.Threading.Tasks;
using System.Collections;

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
            catch (Exception) { throw; }
        }

        /// <summary>
        /// دریافت لیست همه نمادهای بازار
        /// </summary>
        /// <returns></returns>
        public IList<Stock> Stocks(BondType bondType = BondType.All)
        {
            try
            {
                var stocks = new StocksController().Get();
                switch (bondType)
                {
                    case BondType.All:
                        return stocks;
                    case BondType.Saham:
                        return stocks
                            .Where(x => x.OtherData[17] == "1")
                            .ToList();
                    case BondType.Farabourse_Payeh:
                        return stocks
                            .Where(x => x.OtherData[17] == "4")
                            .ToList();
                    case BondType.Farabourse_First_Second:
                        return stocks
                            .Where(x => x.OtherData[17] == "2")
                            .Where(x => x.Industry.Id != 69)
                            .Where(x => x.Industry.Id != 68)
                            .Where(x => x.Industry.Id != 59)
                            .ToList();
                    case BondType.TshilatMaskan:
                        return stocks.Where(x => x.Industry.Id == 59).ToList();
                    case BondType.HaghTaghadom:
                        return stocks
                            .Where(x => x.Symbol.EndsWith("ح"))
                            .ToList();
                    case BondType.OraghBedehi:
                        return stocks.Where(x => x.Industry.Id == 69).ToList();
                    case BondType.EkhtiarMoameleh:
                        return stocks.Where(x => x.OtherData[17] == "3").ToList();
                    case BondType.Ati: // ERRRO
                        return null;
                    case BondType.SandoghSarmayegozari:
                        return stocks.Where(x => x.Industry.Id == 68).ToList();
                    case BondType.Kala:
                        return stocks.Where(x => x.OtherData[17] == "7").ToList();
                    default:
                        return stocks;
                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// دریافت لیست همه صنایع موجود
        /// </summary>
        /// <returns>کلید آی آن صنعت، و مقدار نام آن صنعت می باشد</returns>
        public IDictionary<string, string> Industries()
        {
            try
            {
                return new IndustryController().Get();
            }
            catch (Exception) { throw; }
        }
    }
}