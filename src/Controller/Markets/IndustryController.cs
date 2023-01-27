using System.Collections.Generic;
using Tse.Networks.Deserialize;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Markets
{
    internal class IndustryController : IMarketController<IDictionary<string, string>>
    {
        public IDictionary<string, string> Get()
        {
            try
            {
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url: Networks.Address.Industry);

                if (request.ResponseStatus != "OK")
                {
                    return new Dictionary<string, string>();
                }
                return new IndustryDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
