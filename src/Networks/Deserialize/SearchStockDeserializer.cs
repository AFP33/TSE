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
    internal class SearchStockDeserializer : IDeserializer<List<Stock>>
    {
        public List<Stock> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var firstSplit = serverResponse.Split(';');
                List<Stock> stocks = new List<Stock>();
                int counter = 0;
                foreach (var item in firstSplit)
                {
                    if (item == "") continue;
                    var splited = item.Split(',');
                    Stock stockFinded = new Stock();
                    if (splited[7] == "0") continue; // نماد غیرفعال شده
                    stockFinded.Symbol = splited[0];
                    stockFinded.Name = splited[1];
                    stockFinded.TseCode = splited[2].ToString();

                    // I don't know what is this data, but put these in list if you know and want to use them
                    stockFinded.OtherData = (new List<string> { splited[6], splited[7], splited[8], splited[9] }).ToArray();
                    stocks.Insert(counter, stockFinded);
                    counter++;
                }

                return stocks;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
