using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Stocks
{
    internal class AnnouncementController : IStockController<List<Announcement>>
    {
        public List<Announcement> Get(Stock stock)
        {
            try
            {
                if (Common.Useful.IsNullString(stock.TseCode))
                    throw new ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.Announcement, stock.TseCode);
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                    return new List<Announcement>();

                return new AnnouncementDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
