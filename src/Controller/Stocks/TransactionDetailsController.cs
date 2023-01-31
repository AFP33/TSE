using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Stocks
{
    internal class TransactionDetailsController : IStockController<IList<TransactionDetails>>
    {
        private DateTime? date { get; set; }

        public TransactionDetailsController(DateTime date)
        {
            this.date = date;
        }

        public TransactionDetailsController(string persianDate)
        {
            this.date = Useful.GetDateTimeFromPersianDate(persianDate);
        }

        public TransactionDetailsController(TransactionHistory transactionHistory)
        {
            this.date = transactionHistory.Date;
        }

        public IList<TransactionDetails> Get(Stock stock)
        {
            try
            {
                if (stock.TseCode.IsEmpty())
                    throw new ArgumentNullException(nameof(stock));

                if (this.date == null || !this.date.HasValue)
                    throw new ArgumentNullException(nameof(this.date));

                string url = string.Format(Networks.Address.TransactionDetails, stock.TseCode, this.date.Value.ToString("yyyyMMdd"));
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                    return new List<TransactionDetails>();

                return new TransactionDetailsDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
