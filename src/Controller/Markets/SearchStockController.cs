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
    internal class SearchStockController : IMarketController<List<Stock>>
    {
        private string name { get; set; }
        public SearchStockController(string name)
        {
            this.name = name;
        }
        public List<Stock> Get()
        {
            try
            {
                if (Common.Useful.IsNullString(this.name))
                    throw new System.ArgumentNullException(nameof(this.name));

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
