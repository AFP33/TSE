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
    internal class RealLegalDeserializer : IDeserializer<IList<RealLegal>>
    {
        public IList<RealLegal> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var realLegals = new List<RealLegal>();

                var realLegalItems = serverResponse.Split(';');

                foreach (var realLegalItem in realLegalItems)
                {
                    var items = realLegalItem.Split(',');
                    RealLegal realLegal = new RealLegal()
                    {
                        Date = Useful.GregorianDateToPersianDate(items[0]),
                        Buyes = new Buy()
                        {
                            Legal = GetItems(items[2], items[6], items[10]),
                            Real = GetItems(items[1], items[5], items[9])
                        },
                        Sellers = new Sell()
                        {
                            Legal = GetItems(items[4], items[8], items[12]),
                            Real = GetItems(items[3], items[7], items[11]),
                        },
                        OwnershipLegalToReal = CalculateChangeOwnershipToReal(items[8].ToUlong(), items[6].ToUlong())
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

        private decimal CalculateAveragePrice(decimal value, ulong volume)
        {
            if (value == 0 || volume == 0)
                return 0;
            try
            {
                return Math.Round(value / volume, 2);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private long CalculateChangeOwnershipToReal(ulong sellLegal, ulong buyLegal)
        {
            try
            {
                return (long)(sellLegal - buyLegal);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private Items GetItems(string count, string volume, string value)
        {
            try
            {
                return new Items()
                {
                    Count = count.ToInt(),
                    Volume = volume.ToUlong(),
                    Value = value.ToDecimal(),
                    AveragePrice = CalculateAveragePrice(value.ToDecimal(), volume.ToUlong()),
                };
            }
            catch (Exception)
            {
                return new Items();
            }
        }
    }
}
