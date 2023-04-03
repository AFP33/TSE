using Tse.Networks.Deserialize;
using Tse.Entities;
using Tse.Common;
using System;
using System.Security.Policy;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Stocks
{
    internal class BriefInformationController : IStockController<BriefInformation>
    {
        public BriefInformation Get(Stock stock)
        {
            try
            {
                if (stock.TseCode.IsEmpty())
                    throw new ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.BriefInformation, stock.TseCode);
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                    return new BriefInformation();

                var briefInfo = new BriefInformationDeserializer().Get(request.ResponseResult);
                var transactionDetails = GetCurrentDayTransactionDetails(stock);
                if (transactionDetails == null)
                    return briefInfo;

                if (transactionDetails.Item1 != null)
                    briefInfo.RealsTransaction =  transactionDetails.Item1;
                if (transactionDetails.Item2 != null)
                    briefInfo.LegalTransaction = transactionDetails.Item2;

                return briefInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Tuple<CurrentDayTransactionDetails, CurrentDayTransactionDetails> GetCurrentDayTransactionDetails(Stock stock)
        {
            try
            {
                var request = new Networks.Request();
                request.SendRequest(Networks.Address.RealLegalLive);
                if (request.ResponseStatus != "OK")
                    return null;

                return new CurrentDayTransactionDetailsDeserializer(stock).Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
