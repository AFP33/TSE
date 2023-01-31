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
    internal class StockQueueController : IStockController<StockQueue>
    {
        private QueueStatus queueStatus { get; set; }

        public StockQueueController(QueueStatus queueStatus)
        {
            this.queueStatus = queueStatus;
        }

        public StockQueue Get(Stock stock)
        {
            try
            {
                if (stock.TseCode.IsEmpty())
                    throw new ArgumentNullException(nameof(stock));

                string url = string.Format(Networks.Address.BriefInformation, stock.TseCode);
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                    return new StockQueue();

                var briefInfo = new BriefInformationController().Get(stock);
                return new StockQueueDeserializer(briefInfo, queueStatus).Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
