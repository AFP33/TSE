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
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                List<DPS> dPs = new List<DPS>();

                var dpsRecords = serverResponse.Split(';');

                foreach (var item in dpsRecords)
                {
                    DPS dPS = new DPS();
                    var dpsRecordItems = item.Split('@');
                    dPS.PublishDate = Useful.IsNullString(dpsRecordItems[0]) ? "" : dpsRecordItems[0];
                    dPS.CouncilDate = Useful.IsNullString(dpsRecordItems[1]) ? "" : dpsRecordItems[1];
                    dPS.FiscalYear = Useful.IsNullString(dpsRecordItems[2]) ? "" : dpsRecordItems[2];
                    dPS.ProfitOrLoss = Useful.IsNullString(dpsRecordItems[3]) ? "" : dpsRecordItems[3];
                    dPS.DistributableProfit = Useful.IsNullString(dpsRecordItems[4]) ? "" : dpsRecordItems[4];
                    dPS.AccumulatedProfit = Useful.IsNullString(dpsRecordItems[5]) ? "" : dpsRecordItems[5];
                    dPS.CashProfit = Useful.IsNullString(dpsRecordItems[6]) ? "" : dpsRecordItems[6];

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
