﻿using System.Collections.Generic;
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
    internal class DPSController : IStockController<IList<DPS>>
    {
        public IList<DPS> Get(Stock stock)
        {
            try
            {
                if (stock.Symbol.IsEmpty())
                    throw new System.ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.DPS, stock.Symbol);
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                {
                    return new List<DPS>();
                }
                return new DPSDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
