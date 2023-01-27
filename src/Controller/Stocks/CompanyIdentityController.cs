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
    internal class CompanyIdentityController : IStockController<CompanyIdentity>
    {
        public CompanyIdentity Get(Stock stock)
        {
            try
            {
                if (stock.TseCode.IsEmpty())
                    throw new ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.CompanyIdentity, stock.TseCode);
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                    return new CompanyIdentity();

                return new CompanyIdentityDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
