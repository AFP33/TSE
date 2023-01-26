using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Stocks
{
    internal class TransactionHistoryController : IStockController<List<TransactionHistory>>
    {
        TransactionHistoryType transactionHistoryType { get; set; }

        public TransactionHistoryController(TransactionHistoryType transactionHistoryType)
        {
            this.transactionHistoryType = transactionHistoryType;
        }

        public List<TransactionHistory> Get(Stock stock)
        {
            try
            {
                if (Common.Useful.IsNullString(stock.TseCode))
                    throw new System.ArgumentNullException(nameof(stock));

                string url = GetUrl(stock.TseCode);
                
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                {
                    return new List<TransactionHistory>();
                }
                return new TransactionHistoryDeserializer().Get(request.ResponseResult);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private string GetUrl(string tseCode)
        {
            switch (this.transactionHistoryType)
            {
                case TransactionHistoryType.AllDay:
                    return string.Format(Networks.Address.TransactionHistoryAllDays, tseCode);
                case TransactionHistoryType.TradedDay:
                    return string.Format(Networks.Address.TransactionHistory, tseCode);
                default:
                    return string.Format(Networks.Address.TransactionHistory, tseCode);
            }
        }
    }
}
