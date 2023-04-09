using System.Collections.Generic;
using Tse.Entities;
using System.Linq;
using System;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Tse.Common;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class StocksDeserializer : IDeserializer<IList<Stock>>
    {
        public IList<Stock> Get(string serverResponse)
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
                            Name = items[3],
                            Symbol = items[2],
                            TseCode = items[0],
                            OtherData = items,
                            Industry = new Industry() 
                            {
                                Id = Convert.ToInt32(items[18]),
                                Title = items[18].ParseEnum<IndustryType>().GetDescription()
                            }
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
