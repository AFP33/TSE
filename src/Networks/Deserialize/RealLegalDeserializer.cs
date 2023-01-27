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
    internal class RealLegalDeserializer : IDeserializer<List<RealLegal>>
    {
        public List<RealLegal> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var realLegals = new List<RealLegal>();

                string[] realLegalItems = serverResponse.Split(';');

                foreach (var realLegalItem in realLegalItems)
                {
                    var items = realLegalItem.Split(',');
                    RealLegal realLegal = new RealLegal()
                    {
                        Date = Useful.GregorianDateToPersianDate(items[0]),
                        Buyes = new Buy()
                        {
                            Legal = new Items()
                            {
                                Count = items[2],
                                Volume = items[6],
                                Value = items[10],
                                AveragePrice = CalculateAveragePrice(items[10], items[6]),
                            },
                            Real = new Items()
                            {
                                Count = items[1],
                                Volume = items[5],
                                Value = items[9],
                                AveragePrice = CalculateAveragePrice(items[9], items[5]),
                            }
                        },
                        Sellers = new Sell()
                        {
                            Legal = new Items()
                            {
                                Count = items[4],
                                Volume = items[8],
                                Value = items[12],
                                AveragePrice = CalculateAveragePrice(items[12], items[8]),
                            },
                            Real = new Items()
                            {
                                Count = items[3],
                                Volume = items[7],
                                Value = items[11],
                                AveragePrice = CalculateAveragePrice(items[11], items[7]),
                            }
                        },
                        OwnershipLegalToReal = CalculateChangeOwnershipToReal(items[8], items[6])
                    };
                    realLegals.Add(realLegal);
                }


                return realLegals;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string CalculateAveragePrice(string value, string volume)
        {
            if (value.IsEmpty() || volume.IsEmpty() || value == "0" || volume == "0")
                return "";

            return Math.Round((decimal)Convert.ToInt64(value) / Convert.ToInt64(volume), 2).ToString();
        }

        private string CalculateChangeOwnershipToReal(string sellLegal, string buyLegal)
        {
            if (sellLegal.IsEmpty() || buyLegal.IsEmpty())
                return "";

            return (Convert.ToInt64(sellLegal) - Convert.ToInt64(buyLegal)).ToString();
        }
    }
}
