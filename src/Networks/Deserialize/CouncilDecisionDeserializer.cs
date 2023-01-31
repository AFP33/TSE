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
    internal class CouncilDecisionDeserializer : IDeserializer<IList<CouncilDecision>>
    {
        public IList<CouncilDecision> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var listOfCouncilDicisions = new List<CouncilDecision>();
                var councilDicisions = JArray.Parse(serverResponse).Children();

                foreach (var councilDicision in councilDicisions)
                {
                    try
                    {
                        listOfCouncilDicisions.Add(new CouncilDecision()
                        {
                            Title = councilDicision[0].Value<string>(),
                            Date = councilDicision[1].Value<string>(),
                            YearEndToDate = GetYearEndToDate(councilDicision[4]["Root"]),
                            PlaceAndDateTime = GetPlaceAndDateTime(councilDicision[4]["Root"]),
                            Stockholder = GetStockholder(councilDicision[4]["Root"]),
                            Presidium = GetPresidium(councilDicision[4]["Root"]),
                            DirectorManager = GetDirectorManager(councilDicision[4]["Root"]),
                            IncomeStatements = GetIncomeStatements(councilDicision[4]["Root"]),
                            DividedRetainedEarning = GetDividedRetainedEarning(councilDicision[4]["Root"]),
                            Inspector = GetInspector(councilDicision[4]["Root"]),
                            Newspaper = GetNewspapers(councilDicision[4]["Root"]),
                            BoardMemberWage = GetBoardMemberWage(councilDicision[4]["Root"]),
                            BoardMemberGift = GetBoardMemberGift(councilDicision[4]["Root"]),
                            Other = GetOther(councilDicision[4]["Root"])
                        });
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return listOfCouncilDicisions;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string GetOther(JToken jToken)
        {
            try
            {
                if (jToken == null
                    || jToken["Other"] == null)
                    return string.Empty;

                return jToken["Other"].Value<string>();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private string GetBoardMemberGift(JToken jToken)
        {
            try
            {
                if (jToken == null
                    || jToken["BoardMemberGift"] == null)
                    return string.Empty;

                return jToken["BoardMemberGift"].Value<string>();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private string GetBoardMemberWage(JToken jToken)
        {
            try
            {
                if (jToken == null
                    || jToken["BoardMemberWage"] == null)
                    return string.Empty;

                return jToken["BoardMemberWage"].Value<string>();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private IList<string> GetNewspapers(JToken jToken)
        {
            try
            {
                if (jToken == null
                    || jToken["NewsPapers"] == null
                    || jToken["NewsPapers"]["NewsPaper"] == null)
                    return new List<string>();

                var newspapers = new List<string>();
                foreach (var item in jToken["NewsPapers"]["NewsPaper"])
                {
                    newspapers.Add(item.Value<string>());
                }

                return newspapers;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }

        private Inspector GetInspector(JToken jToken)
        {
            try
            {
                if (jToken == null
                    || jToken["Inspector"] == null)
                    return new Inspector();

                var inspector = new Inspector();
                inspector.Text = jToken["Inspector"]["PureText"] != null 
                    ? jToken["Inspector"]["PureText"].Value<string>()
                    : string.Empty;
                inspector.Auditor = jToken["Inspector"]["Auditor"] != null 
                    ? jToken["Inspector"]["Auditor"].Value<string>()
                    : string.Empty;
                inspector.AlternativeAuditor = jToken["Inspector"]["AlternativeAuditor"] != null 
                    ? jToken["Inspector"]["AlternativeAuditor"].Value<string>()
                    : string.Empty;

                return inspector;
            }
            catch (Exception)
            {
                return new Inspector();
            }
        }

        private IList<DividedRetainedEarning> GetDividedRetainedEarning(JToken jToken)
        {
            try
            {
                if (jToken == null
                    || jToken["DividedRetainedEarning"] == null
                    || jToken["DividedRetainedEarning"]["tr"] == null)
                    return new List<DividedRetainedEarning>();

                var dividedRetainedEarnings = new List<DividedRetainedEarning>();
                var rows = jToken["DividedRetainedEarning"]["tr"].Children();
                foreach (var row in rows)
                {
                    try
                    {
                        var dividedRetainedEarning = new DividedRetainedEarning();
                        dividedRetainedEarning.Statement = GetValueFromField(row["td"][0]);
                        dividedRetainedEarning.Value = GetValueFromField(row["td"][1]);

                        dividedRetainedEarnings.Add(dividedRetainedEarning);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                return dividedRetainedEarnings;
            }
            catch (Exception)
            {
                return new List<DividedRetainedEarning>();
            }
        }

        private IList<IncomeStatement> GetIncomeStatements(JToken jToken)
        {
            try
            {
                if (jToken == null 
                    || jToken["IncomeStatement"] == null 
                    || jToken["IncomeStatement"]["tr"]== null )
                    return new List<IncomeStatement>();

                var incomeStatements = new List<IncomeStatement>();
                var rows = jToken["IncomeStatement"]["tr"].Children();
                foreach (var row in rows)
                {
                    try
                    {
                        var incomeStatement = new IncomeStatement();
                        List<string> strings = new List<string>();
                        foreach ((var item, bool isFirst) in row["td"].Children().Select((item, index) => (item, index == 0)))
                        {
                            if (isFirst)
                            {
                                incomeStatement.Title = GetValueFromField(item);
                            }
                            else
                            {
                                strings.Add(GetValueFromField(item));
                            }
                        }
                        incomeStatement.Values = strings;
                        incomeStatements.Add(incomeStatement);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                return incomeStatements;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private DirectorManager GetDirectorManager(JToken jToken)
        {
            try
            {
                if (jToken == null || jToken["DirectorManager"] == null)
                    return new DirectorManager();

                return new DirectorManager()
                {
                    Name = jToken["DirectorManager"]["Name"] != null ? jToken["DirectorManager"]["Name"].Value<string>() : null,
                    NationalCode = jToken["DirectorManager"]["NationalCode"] != null ? jToken["DirectorManager"]["NationalCode"].Value<string>() : null,
                    EducationDegree = jToken["DirectorManager"]["Degree"] != null ? jToken["DirectorManager"]["Degree"].Value<string>() : null
                };
            }
            catch (Exception)
            {
                return new DirectorManager();
            }
        }

        private IList<string> GetPresidium(JToken jToken)
        {
            try
            {
                if (jToken == null || jToken["Presidium"]["PresidiumMember"] == null)
                    return new List<string>();

                var stringList = new List<string>();
                var members = jToken["Presidium"]["PresidiumMember"].Children();
                foreach (var member in members)
                {
                    stringList.Add(member.Value<string>());
                }

                return stringList;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }

        private IList<Stockholder> GetStockholder(JToken jToken)
        {
            try
            {
                if (jToken == null || jToken["AssemblyShareHolder"] == null)
                    return new List<Stockholder>();

                var field = jToken["AssemblyShareHolder"];
                var stockHolders = new List<Stockholder>();
                var holders = field["tr"].Children();
                foreach (var item in holders)
                {
                    try
                    {
                        if (item["td"] == null)
                            continue;
                        var cd = new Stockholder();
                        cd.Holder = item["td"][0].Value<string>();
                        cd.Share = item["td"][1].Value<string>();
                        cd.Percent = item["td"][2].Value<string>();
                        stockHolders.Add(cd);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return stockHolders;
            }
            catch (Exception)
            {
                return new List<Stockholder>();
            }
        }

        private PlaceAndDateTime GetPlaceAndDateTime(JToken jToken)
        {
            try
            {
                if (jToken == null)
                    return new PlaceAndDateTime();

                var field = jToken["PlaceAndDateTime"];
                if (field == null)
                    return new PlaceAndDateTime();

                return new PlaceAndDateTime()
                {
                    Date = field["Date"] != null 
                    ? Useful.GetDateTimeFromPersianDate(field["Date"].Value<string>()) 
                    : null,

                    Time = field["Time"] != null 
                    ? Useful.ToTimeSpan(field["Time"].Value<string>()) 
                    : null,

                    Place = field["Place"] != null 
                    ? field["Place"].Value<string>()
                    : string.Empty
                };
            }
            catch (Exception)
            {
                return new PlaceAndDateTime();
            }
        }

        private DateTime? GetYearEndToDate(JToken jToken)
        {
            try
            {
                if (jToken == null)
                    return null;

                return Useful.GetDateTimeFromPersianDate
                (
                    jToken["YearEndToDate"] != null 
                    ? jToken["YearEndToDate"].Value<string>() 
                    : null
                );
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GetValueFromField(JToken jToken, string key = "_text")
        {
            try
            {
                if (jToken == null)
                    return string.Empty;

                if (jToken.Children().Count() == 0)
                    return jToken.Value<string>();

                return jToken.Value<string>(key);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
