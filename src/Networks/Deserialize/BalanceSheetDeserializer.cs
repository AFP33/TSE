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
    public class BalanceSheetDeserializer : IDeserializer<List<BalanceSheet>>
    {
        public List<BalanceSheet> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var listOfBalanceSheet = new List<BalanceSheet>();
                var sheets = JArray.Parse(serverResponse).Children();

                /// for each Balance Sheet 
                foreach (var sheet in sheets)
                {
                    BalanceSheet balanceSheet = new BalanceSheet();
                    balanceSheet.Title = sheet[0].Value<string>();
                    balanceSheet.PublishDate = sheet[1].Value<string>();
                    balanceSheet.ReportName = sheet[4]["Root"].Children().Children().FirstOrDefault()["_ReportName"].Value<string>();
                    balanceSheet.YearEndToDate = sheet[4]["Root"].Children().Children().ToList()[1].Value<string>();
                    balanceSheet.Period = sheet[4]["Root"].Children().Children().ToList()[2].Value<string>();
                    balanceSheet.Status = sheet[4]["Root"].Children().Children().ToList()[3].Value<string>() == "(حسابرسی شده)" ? BalanceSheetStatus.AUDITE : BalanceSheetStatus.NOTAUDITE;
                    balanceSheet.PeriodEndToDate = sheet[4]["Root"].Children().Children().ToList()[4].Value<string>();

                    /// Create Balance Sheet Data Table
                    List<List<string>> data = new List<List<string>>();

                    /// Get all Record of Table
                    var tableRecord = sheet[4]["Root"]["table"]["tr"];

                    /// then, we get table's data
                    for (int i = 0; i < tableRecord.Count(); i++)
                    {
                        List<string> record = new List<string>();
                        foreach (var item in tableRecord[i]["td"].Values<JToken>())
                        {
                            record.Add(item.Value<string>("_text"));
                        }
                        data.Add(record);
                    }
                    /// add to container
                    balanceSheet.Data = data;
                    listOfBalanceSheet.Add(balanceSheet);
                }
                return listOfBalanceSheet;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
