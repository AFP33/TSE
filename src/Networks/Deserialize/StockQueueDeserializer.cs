using System.Collections.Generic;
using Tse.Entities;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class StockQueueDeserializer : IDeserializer<StockQueue>
    {
        private QueueStatus queueStatus { get; set; }
        private BriefInformation briefInformation { get; set; }

        public StockQueueDeserializer(BriefInformation briefInformation, QueueStatus queueStatus)
        {
            this.queueStatus = queueStatus;
            this.briefInformation = briefInformation;
        }

        public StockQueue Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var tableValues = serverResponse.Split(';')[2];
                if (tableValues.IsEmpty())
                    return new StockQueue();

                var buyes = new List<RowStockQueue>();
                var selles = new List<RowStockQueue>();
                var rows = tableValues.Split(',');
                foreach (var row in rows)
                {
                    if (row.IsEmpty())
                        continue;
                    try
                    {
                        var t = row.Split('@');
                        buyes.Add(new RowStockQueue()
                        {
                            Count = t[0].ToInt(),
                            Volume = t[1].ToUlong(),
                            Price = t[2].ToDecimal()
                        });
                        selles.Add(new RowStockQueue
                        {
                            Count = t[5].ToInt(),
                            Volume = t[4].ToUlong(),
                            Price = t[3].ToDecimal()
                        });
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                if (queueStatus != QueueStatus.Full)
                    (buyes, selles) = CleaningQueue(buyes, selles);

                return new StockQueue()
                {
                    BuyStockQueue = buyes,
                    SellStockQueue = selles
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        private (List<RowStockQueue>, List<RowStockQueue>) CleaningQueue(List<RowStockQueue> buyes, List<RowStockQueue> selles)
        {
            var todayRange = briefInformation.TodayRange;

            for (int i = buyes.Count - 1; i >= 0; i--)
            {
                if (buyes[i].Price < todayRange.Low || buyes[i].Price > todayRange.High)
                    buyes.RemoveAt(i);
            }

            for (int i = selles.Count - 1; i >= 0; i--)
            {
                if (selles[i].Price < todayRange.Low || selles[i].Price > todayRange.High)
                    selles.RemoveAt(i);
            }

            return (buyes, selles);
        }
    }
}
