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
    internal class ChosenIndexesController : IMarketController<IList<ChosenIndexes>>
    {
        public IList<ChosenIndexes> Get()
        {
            try
            {
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(Networks.Address.Bourse);

                if (request.ResponseStatus != "OK")
                {
                    return new List<ChosenIndexes>();
                }
                return new ChosenIndexesDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
