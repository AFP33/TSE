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
    internal class TransactionHistoryDeserializer : IDeserializer<List<TransactionHistory>>
    {
        public List<TransactionHistory> Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                List<TransactionHistory> transactionHistories = new List<TransactionHistory>();
                var records = serverResponse.Split(';');
                foreach (var record in records)
                {
                    try
                    {
                        var fields = record.Split('@');
                        var transactionHistory = new TransactionHistory()
                        {
                            Date = Useful.GregorianDateToPersianDate(fields[0]),
                            Count = fields[9],
                            Volume = fields[8],
                            Value = fields[7],
                            YesterdayPrice = fields[6],
                            FirstPrice = fields[5],
                            LastTransactionPrice = fields[4],
                            FinalTransactionPrice = fields[3],
                            MinimumPrice = fields[2],
                            MaximumPrice = fields[1],
                        };
                        transactionHistories.Add(transactionHistory);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return transactionHistories;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
