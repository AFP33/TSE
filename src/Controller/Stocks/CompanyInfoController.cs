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
    internal class CompanyInfoController : IStockController<CompanyInfo>
    {
        public CompanyInfo Get(Stock stock)
        {
            try
            {
                if (stock.Symbol.IsEmpty())
                    throw new ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.CompanyInfo, stock.Symbol);
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                    return new CompanyInfo();

                return new CompanyInfoDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
