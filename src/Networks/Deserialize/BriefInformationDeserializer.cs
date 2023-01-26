using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class BriefInformationDeserializer : IDeserializer<BriefInformation>
    {
        public BriefInformation Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                var splitted = serverResponse.Split(',');
                var briefInfo = new BriefInformation()
                {
                    LastTransaction = splitted[2],
                    FinalPrice = splitted[3],
                    FirstPrice = splitted[4],
                    YesterdayPrice = splitted[5],
                    TransactionCount = splitted[8],
                    TransactionVolume = splitted[9],
                    TransactionValue = splitted[10],
                    MarketValue = "Error",
                    TodayRange = new Range { Low = splitted[7], High = splitted[6] },
                };

                return briefInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
