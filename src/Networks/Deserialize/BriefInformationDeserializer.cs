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
    internal class BriefInformationDeserializer : IDeserializer<BriefInformation>
    {
        public BriefInformation Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var splitted = serverResponse.Split(',');
                var briefInfo = new BriefInformation()
                {
                    LastTransaction = splitted[2].ToInt(),
                    FinalPrice = splitted[3].ToInt(),
                    FirstPrice = splitted[4].ToInt(),
                    YesterdayPrice = splitted[5].ToInt(),
                    TransactionCount = splitted[8].ToInt(),
                    TransactionVolume = splitted[9].ToUlong(),
                    TransactionValue = splitted[10].ToUlong(),
                    TodayRange = new Range { Low = splitted[7].ToInt(), High = splitted[6].ToInt() },
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
