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
    internal class DPSDeserializer : IDeserializer<List<DPS>>
    {
        public List<DPS> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                List<DPS> dPs = new List<DPS>();

                var dpsRecords = serverResponse.Split(';');

                foreach (var item in dpsRecords)
                {
                    DPS dPS = new DPS();
                    var dpsRecordItems = item.Split('@');
                    dPS.PublishDate = dpsRecordItems[0].IsEmpty() ? "" : dpsRecordItems[0];
                    dPS.CouncilDate = dpsRecordItems[1].IsEmpty() ? "" : dpsRecordItems[1];
                    dPS.FiscalYear = dpsRecordItems[2].IsEmpty() ? "" : dpsRecordItems[2];
                    dPS.ProfitOrLoss = dpsRecordItems[3].IsEmpty() ? "" : dpsRecordItems[3];
                    dPS.DistributableProfit = dpsRecordItems[4].IsEmpty() ? "" : dpsRecordItems[4];
                    dPS.AccumulatedProfit = dpsRecordItems[5].IsEmpty() ? "" : dpsRecordItems[5];
                    dPS.CashProfit = dpsRecordItems[6].IsEmpty() ? "" : dpsRecordItems[6];

                    dPs.Add(dPS);
                }
                return dPs;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
