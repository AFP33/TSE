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
    internal class CurrentDayTransactionDetailsDeserializer : IDeserializer<Tuple<CurrentDayTransactionDetails, CurrentDayTransactionDetails>>
    {
		private Stock Stock { get; set; }

		public CurrentDayTransactionDetailsDeserializer(Stock stock)
		{
			this.Stock = stock;
		}

        public Tuple<CurrentDayTransactionDetails, CurrentDayTransactionDetails> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var splitted = serverResponse.Split(';');
                foreach (var item in splitted)
                {
                    var eachStock = item.Split(',');
                    if (eachStock[0] == Stock.TseCode)
                    {
                        var real = new CurrentDayTransactionDetails()
                        {
                            BuyerCount = eachStock[1].ToInt(),
                            BuyerVolume = eachStock[3].ToLong(),
                            SellerCount = eachStock[5].ToInt(),
                            SellerVolume = eachStock[7].ToLong()
                        };
                        var legal = new CurrentDayTransactionDetails()
                        {
                            BuyerCount = eachStock[2].ToInt(),
                            BuyerVolume = eachStock[4].ToLong(),
                            SellerCount = eachStock[6].ToInt(),
                            SellerVolume = eachStock[8].ToLong()
                        };

                        return Tuple.Create(real, legal);
                    }
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
