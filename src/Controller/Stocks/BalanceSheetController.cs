using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;
using Tse.Common;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Stocks
{
    internal class BalanceSheetController : IStockController<IList<BalanceSheet>>
    {
        public IList<BalanceSheet> Get(Stock stock)
        {
            try
            {
                if (stock.Symbol.IsEmpty())
                    throw new System.ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.BalaneSheet, stock.Symbol);
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                {
                    return new List<BalanceSheet>();
                }
                return new BalanceSheetDeserializer().Get(request.ResponseResult);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
