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
    internal class AnnouncementController : IStockController<IList<Announcement>>
    {
        public IList<Announcement> Get(Stock stock)
        {
            try
            {
                if (stock.TseCode.IsEmpty())
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
