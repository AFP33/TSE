using Tse.Networks.Deserialize;
using Tse.Entities;
using System;

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
                if (Common.Useful.IsNullString(stock.TseCode))
                    throw new System.ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.BriefInformation, stock.TseCode);
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                    return new BriefInformation();

                return new BriefInformationDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
