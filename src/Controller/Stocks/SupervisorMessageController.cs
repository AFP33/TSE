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
    internal class SupervisorMessageController : IStockController<IList<SupervisorMessage>>
    {
        public IList<SupervisorMessage> Get(Stock stock)
        {
            try
            {
                if (stock.TseCode.IsEmpty())
                    throw new System.ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.SupervisorMessage, stock.TseCode);
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                {
                    return new List<SupervisorMessage>();
                }
                return new SupervisorMessageDeserializer().Get(request.ResponseResult);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
