using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Markets
{
    internal class TopTransactionSymbolController : IMarketController<IList<TopTransactionSymbol>>
    {
        private string _market { get; set; }

        public TopTransactionSymbolController(string market = "Bourse")
        {
            _market = market;
        }

        public IList<TopTransactionSymbol> Get()
        {
            try
            {
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(Networks.Address.Bourse);

                if (request.ResponseStatus != "OK")
                {
                    return new List<TopTransactionSymbol>();
                }
                return new TopTransactionSymbolDeserializer(_market).Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
