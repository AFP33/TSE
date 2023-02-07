using System.Collections.Generic;
using Newtonsoft.Json.Linq;
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
    internal class PortfoDeserializer : IDeserializer<Portfo>
    {
        public Portfo Get(string serverResponse)
        {
			try
			{
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var portfo = new Portfo();
                portfo.ByIndustryGroup = new List<ByIndustryGroup>();
                portfo.CompaniesInBourse = new List<CompaniesPortfo>();
                portfo.CompaniesOutBourse = new List<CompaniesPortfo>();
                portfo.ObtainingAllTransactions = new List<ObtainingAllTransactions>();
                portfo.AssignmentTransaction = new List<AssignmentTransaction>();
                var portfos = JArray.Parse(serverResponse).Children();
                foreach (var item in portfos)
                {
                    try
                    {
                        if (item == null || item[5] == null)
                            continue;

                        var type = item[5].Value<int>();
                        if (type == 3)
                        {
                            portfo.ByIndustryGroup.Add(GetByIndustryGroup(item));
                        }
                        else if (type == 4)
                        {
                            portfo.CompaniesInBourse.Add(GetCompaniesInBourse(item));
                        }
                        else if (type == 5)
                        {
                            portfo.CompaniesOutBourse.Add(GetCompaniesOutBourse(item));
                        }
                        else if (type == 6)
                        {
                            portfo.ObtainingAllTransactions.Add(GetObtainingAllTransactions(item));
                        }
                        else if (type == 7)
                        {
                            portfo.AssignmentTransaction.Add(GetAssignmentTransaction(item));
                        }
                    }
                    catch (Exception) { continue; }
                }

                return portfo;
            }
			catch (Exception)
			{
				throw;
			}
        }

        private AssignmentTransaction GetAssignmentTransaction(JToken item)
        {
            try
            {
                if (item == null)
                    return null;

                var assignmentTransaction = new AssignmentTransaction();
                assignmentTransaction.PortfoBasicInfo = GetPortfoBasicInfo(item);
                if (item[4]["Root"]["table"]["tr"] == null || !item[4]["Root"]["table"]["tr"].HasValues)
                    return null;

                assignmentTransaction.AssignmentTransactionFields = new List<AssignmentTransactionFields>();
                foreach (var row in item[4]["Root"]["table"]["tr"].Children())
                {
                    try
                    {
                        if (row["td"] == null || !row["td"].HasValues)
                            continue;

                        var assignmentTransactionField = new AssignmentTransactionFields();
                        assignmentTransactionField.ComapanyName = row["td"][0].Value<string>();
                        assignmentTransactionField.NumberOfStocks = row["td"][1].Value<string>().ToUlong();
                        assignmentTransactionField.StockActivityCost = row["td"][2].Value<string>().ToInt();
                        assignmentTransactionField.TotalAmountActivityConst = row["td"][3].Value<string>().ToInt();
                        assignmentTransactionField.PriceOfAssignmentPerStock = row["td"][4].Value<string>().ToInt();
                        assignmentTransactionField.TotalAmountOfAssignment = row["td"][5].Value<string>().ToInt();
                        assignmentTransactionField.ProfitOfAssignment = row["td"][6].Value<string>().ToInt();

                        assignmentTransaction.AssignmentTransactionFields.Add(assignmentTransactionField);
                    }
                    catch (Exception) { continue; }
                }

                return assignmentTransaction;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private ObtainingAllTransactions GetObtainingAllTransactions(JToken item)
        {
            try
            {
                if (item == null)
                    return null;

                var obtainingAllTransactions = new ObtainingAllTransactions();

                obtainingAllTransactions.PortfoBasicInfo = GetPortfoBasicInfo(item);
                if (item[4]["Root"]["table"]["tr"] == null || !item[4]["Root"]["table"]["tr"].HasValues)
                    return null;

                obtainingAllTransactions.ObtainingAllTransactionsFields = new List<ObtainingAllTransactionsFields>();
                foreach (var row in item[4]["Root"]["table"]["tr"].Children())
                {
                    try
                    {
                        if (row["td"] == null || !row["td"].HasValues)
                            continue;

                        var obtainingAllTransactionsField = new ObtainingAllTransactionsFields();
                        obtainingAllTransactionsField.ComapanyName = row["td"][0].Value<string>();
                        obtainingAllTransactionsField.NumberOfStocks = row["td"][1].Value<string>().ToUlong();
                        obtainingAllTransactionsField.StockActivityCost = row["td"][2].Value<string>().ToInt();
                        obtainingAllTransactionsField.TotalAmountActivityCostInBourse = row["td"][3].Value<string>().ToInt();
                        obtainingAllTransactionsField.TotalAmountActivityCostInOutBourse = row["td"][4].Value<string>().ToInt();

                        obtainingAllTransactions.ObtainingAllTransactionsFields.Add(obtainingAllTransactionsField);
                    }
                    catch (Exception) { continue; }
                }

                return obtainingAllTransactions;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private CompaniesPortfo GetCompaniesOutBourse(JToken item)
        {
            try
            {
                if (item == null)
                    return null;

                var comapniesPortfo = new CompaniesPortfo();

                comapniesPortfo.PortfoBasicInfo = GetPortfoBasicInfo(item);
                if (item[4]["Root"]["table"]["tr"] == null || !item[4]["Root"]["table"]["tr"].HasValues)
                    return null;

                comapniesPortfo.CompaniesPortfoFields = new List<CompaniesPortfoFields>();
                foreach (var row in item[4]["Root"]["table"]["tr"].Children())
                {
                    try
                    {
                        if (row["td"] == null || !row["td"].HasValues)
                            continue;

                        var CompaniesPortfoField = new CompaniesPortfoFields();
                        CompaniesPortfoField.Name = row["td"][0].Value<string>();
                        CompaniesPortfoField.Capital = row["td"][1].Value<string>().ToUlong();
                        CompaniesPortfoField.NominalValue = row["td"][2].Value<string>().ToInt();
                        CompaniesPortfoField.PeriodsValue = new Period()
                        {
                            OutsetPeriod = new PeriodItems()
                            {
                                NumberOfStocks = row["td"][3].Value<string>().ToLong(),
                                ActivityCost = row["td"][4].Value<string>().ToLong(),
                            },
                            Change = new PeriodItems()
                            {
                                NumberOfStocks = row["td"][5].Value<string>().ToLong(),
                                ActivityCost = row["td"][6].Value<string>().ToLong(),
                            },
                            OutrancePeriod = new PeriodItems()
                            {
                                OwnershipPercentage = row["td"][7].Value<string>().ToDecimal(),
                                ActivityCost = row["td"][8].Value<string>().ToLong(),
                                StockActivityCost = row["td"][9].Value<string>().ToInt(),
                            }
                        };
                        comapniesPortfo.CompaniesPortfoFields.Add(CompaniesPortfoField);
                    }
                    catch (Exception) { continue; }
                }

                return comapniesPortfo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private CompaniesPortfo GetCompaniesInBourse(JToken item)
        {
            try
            {
                if (item == null)
                    return null;

                var comapniesPortfo = new CompaniesPortfo();

                comapniesPortfo.PortfoBasicInfo = GetPortfoBasicInfo(item);
                if (item[4]["Root"]["table"]["tr"] == null || !item[4]["Root"]["table"]["tr"].HasValues)
                    return null;

                comapniesPortfo.CompaniesPortfoFields = new List<CompaniesPortfoFields>();
                foreach (var row in item[4]["Root"]["table"]["tr"].Children())
                {
                    try
                    {
                        if (row["td"] == null || !row["td"].HasValues)
                            continue;
                        var CompaniesPortfoField = new CompaniesPortfoFields();
                        CompaniesPortfoField.Name = row["td"][0].Value<string>();
                        CompaniesPortfoField.Capital = row["td"][1].Value<string>().ToUlong();
                        CompaniesPortfoField.NominalValue = row["td"][2].Value<string>().ToInt();
                        CompaniesPortfoField.PeriodsValue = new Period()
                        {
                            OutsetPeriod = new PeriodItems()
                            {
                                NumberOfStocks = row["td"][3].Value<string>().ToLong(),
                                ActivityCost = row["td"][4].Value<string>().ToLong(),
                                MarketValue = row["td"][5].Value<string>().ToLong(),
                            },
                            Change = new PeriodItems()
                            {
                                NumberOfStocks = row["td"][6].Value<string>().ToLong(),
                                ActivityCost = row["td"][7].Value<string>().ToLong(),
                                MarketValue = row["td"][8].Value<string>().ToLong(),
                            },
                            OutrancePeriod = new PeriodItems()
                            {
                                OwnershipPercentage = row["td"][9].Value<string>().ToDecimal(),
                                ActivityCost = row["td"][10].Value<string>().ToLong(),
                                MarketValue = row["td"][11].Value<string>().ToLong(),
                                StockActivityCost = row["td"][12].Value<string>().ToInt(),
                                StockValue = row["td"][13].Value<string>().ToInt(),
                                IncreaseDecrease = row["td"][14].Value<string>().ToInt()
                            }
                        };
                        comapniesPortfo.CompaniesPortfoFields.Add(CompaniesPortfoField);
                    }
                    catch (Exception) { continue; }
                }

                return comapniesPortfo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private ByIndustryGroup GetByIndustryGroup(JToken item)
        {
            try
            {
                if (item == null)
                    return null;

                var byIndustryGroup = new ByIndustryGroup();
                byIndustryGroup.PortfoBasicInfo = GetPortfoBasicInfo(item);
                if (item[4]["Root"]["table"]["tr"] == null || !item[4]["Root"]["table"]["tr"].HasValues)
                    return null;

                byIndustryGroup.ByIndustryGroupFields = new List<ByIndustryGroupFields>();
                foreach (var row in item[4]["Root"]["table"]["tr"].Children())
                {
                    try
                    {
                        if (row["td"] == null || !row["td"].HasValues)
                            continue;

                        var byIndustryGroupField = new ByIndustryGroupFields();
                        byIndustryGroupField.Item = row["td"][0].Value<string>();
                        byIndustryGroupField.AcceptedInMarket = new Period()
                        {
                            OutsetPeriod = new PeriodItems()
                            {
                                NumberOfCompany = row["td"][1].Value<string>().ToInt(),
                                ActivityCost = row["td"][2].Value<string>().ToLong(),
                                MarketValue = row["td"][3].Value<string>().ToLong(),
                            },
                            OutrancePeriod = new PeriodItems()
                            {
                                NumberOfCompany = row["td"][4].Value<string>().ToInt(),
                                ActivityCost = row["td"][5].Value<string>().ToLong(),
                                MarketValue = row["td"][6].Value<string>().ToLong(),
                            }
                        };
                        byIndustryGroupField.OutOffMarket = new Period()
                        {
                            OutsetPeriod = new PeriodItems()
                            {
                                NumberOfCompany = row["td"][7].Value<string>().ToInt(),
                                ActivityCost = row["td"][8].Value<string>().ToLong(),
                            },
                            OutrancePeriod = new PeriodItems()
                            {
                                NumberOfCompany = row["td"][9].Value<string>().ToInt(),
                                ActivityCost = row["td"][10].Value<string>().ToLong(),
                            }
                        };
                        byIndustryGroupField.TotalInvestment = new Period()
                        {
                            OutsetPeriod = new PeriodItems()
                            {
                                NumberOfCompany = row["td"][10].Value<string>().ToInt(),
                                ActivityCost = row["td"][11].Value<string>().ToLong(),
                                TotalPercentage = row["td"][12].Value<string>().ToLong(),
                            },
                            OutrancePeriod = new PeriodItems()
                            {
                                NumberOfCompany = row["td"][13].Value<string>().ToInt(),
                                ActivityCost = row["td"][14].Value<string>().ToLong(),
                                TotalPercentage = row["td"][15].Value<string>().ToLong(),
                            }
                        };

                        byIndustryGroup.ByIndustryGroupFields.Add(byIndustryGroupField);
                    }
                    catch (Exception) { continue; }
                }

                return byIndustryGroup;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private PortfoBasicInfo GetPortfoBasicInfo(JToken item)
        {
            try
            {
                if (item == null)
                    return null;

                var basicInfo = new PortfoBasicInfo();
                if (item[0] != null || item[0].HasValues)
                    basicInfo.Title = item[0].Value<string>();

                if (item[1] != null || item[1].HasValues)
                    basicInfo.Publish = Useful.GetDateTimeFromPersianDateTime(item[1].Value<string>());

                if (item[4] != null ||
                    item[4].HasValues ||
                    item[4]["Root"]["Type"]["_ReportName"] != null ||
                    item[4]["Root"]["Type"]["_ReportName"].HasValues)
                    basicInfo.ReportName = item[4]["Root"]["Type"]["_ReportName"].Value<string>();

                if (item[4]["Root"]["YearEndToDate"] != null || item[4]["Root"]["YearEndToDate"].HasValues)
                    basicInfo.YearEndToDate = Useful.GetDateTimeFromPersianDate(item[4]["Root"]["YearEndToDate"].Value<string>());

                if (item[4]["Root"]["Period"] != null || item[4]["Root"]["Period"].HasValues)
                    basicInfo.Period = item[4]["Root"]["Period"].Value<string>();

                if (item[4]["Root"]["IsAudited"] != null || item[4]["Root"]["IsAudited"].HasValues)
                    basicInfo.IsAudited = Useful.GetAuditStatus(item[4]["Root"]["IsAudited"].Value<string>());

                if (item[4]["Root"]["PeriodEndToDate"] != null || item[4]["Root"]["PeriodEndToDate"].HasValues)
                    basicInfo.PeriodEndToDate = Useful.GetDateTimeFromPersianDate(item[4]["Root"]["PeriodEndToDate"].Value<string>());

                return basicInfo;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
