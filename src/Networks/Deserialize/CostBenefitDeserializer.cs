using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Tse.Entities;
using System.Linq;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class CostBenefitDeserializer : IDeserializer<List<CostBenefit>>
    {
        public List<CostBenefit> Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                var costBenefits = new List<CostBenefit>();
                var json = JArray.Parse(serverResponse).Children();

                foreach (var item in json)
                {
                    var costBenefit = new CostBenefit();
                    costBenefit.Title = item[0].Value<string>();
                    costBenefit.Date = item[1].Value<string>();
                    costBenefit.ReportName = item[4]["Root"]["Type"]["_ReportName"].Value<string>();
                    costBenefit.YearEndToDate = item[4]["Root"]["YearEndToDate"].Value<string>();
                    costBenefit.Period = item[4]["Root"]["Period"].Value<string>();
                    costBenefit.IsAudited = item[4]["Root"]["IsAudited"].Value<string>();
                    costBenefit.PeriodEndToDate = item[4]["Root"]["PeriodEndToDate"].Value<string>();

                    // Get items
                    var record = new List<List<string>>();
                    for (int i = 0; i < item[4]["Root"]["table"]["tr"].Count(); i++)
                    {
                        List<string> eachFields = new List<string>();
                        foreach (var c in item[4]["Root"]["table"]["tr"][i]["td"])
                            if (c.HasValues)
                                eachFields.Add(c.Value<string>("_text"));

                        record.Add(eachFields);
                    }
                    costBenefit.Data = record;

                    costBenefits.Add(costBenefit);
                }

                return costBenefits;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
