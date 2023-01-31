using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Tse.Entities;
using System.Linq;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class TransactionDetailsDeserializer : IDeserializer<IList<TransactionDetails>>
    {
        public IList<TransactionDetails> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                JObject transactions = JObject.Parse(serverResponse);
                if (transactions["tradeHistory"] == null || 
                    transactions["tradeHistory"].Children().Count() <= 0)
                    return new List<TransactionDetails>();

                List<TransactionDetails> transactionDetails = new List<TransactionDetails>();
                foreach (var item in transactions["tradeHistory"].Children())
                {
                    try
                    {
                        var time = ReadTimeSpan(item["hEven"].Value<string>());
                        transactionDetails.Add(new TransactionDetails()
                        {
                            TransactionId = item["nTran"].Value<int>(),
                            Time = time != null ? time.Value : TimeSpan.Zero,
                            Volume = (item["qTitTran"].Value<string>()).ToUlong(),
                            Price = (item["pTran"].Value<string>()).ToDecimal(),
                            Canceled = item["canceled"].Value<int>() == 0 ? false : true,
                        });
                    }
                    catch (Exception)
                    {
                        transactionDetails.Add(new TransactionDetails());
                    }
                }

                return transactionDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TimeSpan? ReadTimeSpan(string timespan)
        {
            try
            {
                if (timespan.IsEmpty())
                    return TimeSpan.Zero;

                timespan = timespan.Insert(timespan.Length - 2, ":")
                    .Insert(timespan.Length - 4, ":");

                return Useful.ToTimeSpan(timespan);
            }
            catch (Exception)
            {
                return TimeSpan.Zero;
            }
        }
    }
}
