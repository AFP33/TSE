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
    internal class FaraBourseController : IMarketController<FaraBourse>
    {
        public FaraBourse Get()
        {
            try
            {
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(Networks.Address.Bourse);

                if (request.ResponseStatus != "OK")
                {
                    return new FaraBourse();
                }
                return new FaraBourseDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
