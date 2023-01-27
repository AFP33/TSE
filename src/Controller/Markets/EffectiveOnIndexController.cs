using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Markets
{
    internal class EffectiveOnIndexController : IMarketController<IList<EffectiveOnIndex>>
    {
        private string _market { get; set; }

        public EffectiveOnIndexController(string market = "Bourse")
        {
            _market = market;
        }

        public IList<EffectiveOnIndex> Get()
        {
            try
            {
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(Networks.Address.Bourse);

                if (request.ResponseStatus != "OK")
                {
                    return new List<EffectiveOnIndex>();
                }
                return new EffectiveOnIndexDeserializer(_market).Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
