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
    internal class StatusChangeController : IStockController<List<StatusChange>>
    {
        public List<StatusChange> Get(Stock stock)
        {
            try
            {
                if (stock.TseCode.IsEmpty())
                    throw new ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.StatusChange, stock.TseCode);
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                {
                    return new List<StatusChange>();
                }
                return new StatusChangeDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
