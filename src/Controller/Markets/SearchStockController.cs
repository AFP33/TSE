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

namespace Tse.Controller.Markets
{
    internal class SearchStockController : IMarketController<IList<Stock>>
    {
        private string name { get; set; }
        public SearchStockController(string name)
        {
            this.name = name;
        }
        public IList<Stock> Get()
        {
            try
            {
                if (this.name.IsEmpty())
                    throw new ArgumentNullException(nameof(this.name));

                string url = string.Format(Networks.Address.SearchStocks, this.name);

                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);

                if (request.ResponseStatus != "OK")
                {
                    return new List<Stock>();
                }
                return new SearchStockDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
