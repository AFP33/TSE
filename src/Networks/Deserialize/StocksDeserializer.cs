using System.Collections.Generic;
using Tse.Entities;
using System.Linq;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class StocksDeserializer : IDeserializer<List<Stock>>
    {
        public List<Stock> Get(string serverResponse)
        {
            try
            {
                var stocksRecords = serverResponse.Split('@')[2].Split(';');
                List<Stock> stocks = new List<Stock>();

                for (int i = 1; i < stocksRecords.Count(); i++)
                {
                    try
                    {
                        var items = stocksRecords[i].Split(',');
                        var stock = new Stock()
                        {
                            Id = Convert.ToInt32(items[18]),
                            Name = items[3],
                            Symbol = items[2],
                            TseCode = items[0],
                            OtherData = items,

                        };
                        stocks.Add(stock);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return stocks;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
