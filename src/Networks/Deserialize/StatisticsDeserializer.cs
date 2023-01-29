using System.Collections.Generic;
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
    internal class StatisticsDeserializer : IDeserializer<Statistics>
    {
        public Statistics Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var values = serverResponse.Split(';');
                var data = GetKeyValues(values);
                if (data.Count() == 0)
                    return new Statistics();

                return new Statistics()
                {
                    NegetiveDays = GetNegetiveDays(data),
                    PositiveDays = GetPositiveDays(data),
                    TradingDays = GetTradingDays(data),
                    TradingCounts = GetTradingCounts(data),
                    TradingValue = GetTradingValue(data),
                    CompanyValue = GetCompanyValue(data),
                    TradingVolume = GetTradingVolume(data),
                    Prices = GetPrices(data),
                    SymbolStatus = GetSymbolStatus(data),
                    BuyersSellers = GetBuyersSellers(data),
                    LegalReal = GetLegalReal(data)
                };

            }
            catch (Exception)
            {
                throw;
            }
        }

        private NegetiveDays GetNegetiveDays(IDictionary<int, string> data)
        {
            try
            {
                return new NegetiveDays()
                {
                    NumberOfNegetiveDaysIn3PastMonth = GetValue(data, 18).ToInt(),
                    NumberOfNegetiveDaysIn12PastMonth = GetValue(data, 19).ToInt(),
                    PercentOfNegetiveDaysIn3PastMonth = GetValue(data, 20).ToDecimal(),
                    PercentOfNegetiveDaysIn12PastMonth = GetValue(data, 21).ToDecimal(),
                    RankOfNegetiveDaysIn3PastMonth = GetValue(data, 22).ToInt(),
                    RankOfNegetiveDaysIn12PastMonth = GetValue(data, 23).ToInt()
                };
            }
            catch (Exception)
            {
                return new NegetiveDays();
            }
        }

        private PositiveDays GetPositiveDays(IDictionary<int, string> data)
        {
            try
            {
                return new PositiveDays()
                {
                    NumberOfPositiveDaysIn3PastMonth = GetValue(data, 26).ToInt(),
                    NumberOfPositiveDaysIn12PastMonth = GetValue(data, 27).ToInt(),
                    PercentOfPositiveDaysIn3PastMonth = GetValue(data, 28).ToDecimal(),
                    PercentOfPositiveDaysIn12PastMonth = GetValue(data, 29).ToDecimal(),
                    RankOfPositiveDaysIn3PastMonth = GetValue(data, 30).ToInt(),
                    RankOfPositiveDaysIn12PastMonth = GetValue(data, 31).ToInt()
                };
            }
            catch (Exception)
            {
                return new PositiveDays();
            }
        }

        private TradingDays GetTradingDays(IDictionary<int, string> data)
        {
            try
            {
                return new TradingDays()
                {
                    DaysWithoutTradingIn3PastMonth = GetValue(data, 24).ToInt(),
                    DaysWithoutTradingIn12PastMonth = GetValue(data, 25).ToInt(),
                    DaysWithTradingIn3PastMonth = GetValue(data, 32).ToInt(),
                    DaysWithTradingIn12PastMonth = GetValue(data, 33).ToInt(),
                    RankOfTradingDaysIn3PastMonth = GetValue(data, 34).ToInt(),
                    RankOfTradingDaysIn12PastMonth = GetValue(data, 35).ToInt()
                };
            }
            catch (Exception)
            {
                return new TradingDays();
            }
        }

        private TradingCounts GetTradingCounts(IDictionary<int, string> data)
        {
            try
            {
                return new TradingCounts()
                {
                    AverageDailyTradingCountsIn3PastMonth = GetValue(data, 9).ToInt(),
                    AverageDailyTradingCountsIn12PastMonth = GetValue(data, 10).ToInt(),
                    RankOfDailyTradingCountsIn3PastMonth = GetValue(data, 11).ToInt(),
                    RankOfDailyTradingCountsIn12PastMonth = GetValue(data, 12).ToInt(),
                    TradingCountsInLastDay = GetValue(data, 17).ToInt(),
                };
            }
            catch (Exception)
            {
                return new TradingCounts();
            }
        }

        private TradingValue GetTradingValue(IDictionary<int, string> data)
        {
            try
            {
                return new TradingValue()
                {
                    AverageTradingValueIn3PastMonth = GetValue(data, 1).ToDecimal(),
                    AverageTradingValueIn12PastMonth = GetValue(data, 2).ToDecimal(),
                    RankTradingValueIn3PastMonth = GetValue(data, 3).ToInt(),
                    RankTradingValueIn12PastMonth = GetValue(data, 4).ToInt(),
                    TradingValueInLastDay = GetValue(data, 15).ToDecimal(),
                };
            }
            catch (Exception)
            {
                return new TradingValue();
            }
        }

        private CompanyValue GetCompanyValue(IDictionary<int, string> data)
        {
            try
            {
                return new CompanyValue()
                {
                    CompanyValueInLastDay = GetValue(data, 36).ToDecimal(),
                    RankOfCompanyValueInLastDay = GetValue(data, 37).ToInt()
                };
            }
            catch (Exception)
            {
                return new CompanyValue();
            }
        }

        private TradingVolume GetTradingVolume(IDictionary<int, string> data)
        {
            try
            {
                return new TradingVolume()
                {
                    AverageTradingVolumeIn3PastMonth = GetValue(data, 5).ToUlong(),
                    AverageTradingVolumeIn12PastMonth = GetValue(data, 6).ToUlong(),
                    RankOfTradingVolumeIn3PastMonth = GetValue(data, 7).ToInt(),
                    RankOfTradingVolumeIn12PastMonth = GetValue(data, 8).ToInt(),
                    TradingVolumeInLastDay = GetValue(data, 16).ToUlong(),
                };
            }
            catch (Exception)
            {
                return new TradingVolume();
            }
        }

        private Prices GetPrices(IDictionary<int, string> data)
        {
            try
            {
                return new Prices()
                {
                    WeightedAveragePriceInLastDayWithoutBaseVolume = GetValue(data, 13).ToDecimal(),
                    WeightedAveragePriceInLastDayWithBaseVolume = GetValue(data, 14).ToDecimal()
                };
            }
            catch (Exception)
            {
                return new Prices();
            }
        }

        private SymbolStatus GetSymbolStatus(IDictionary<int, string> data)
        {
            try
            {
                return new SymbolStatus()
                {
                    NumberOfOpenDaysIn3PastMonth = GetValue(data, 38).ToInt(),
                    NumberOfOpenDaysIn12PastMonth = GetValue(data, 39).ToInt(),
                    PercentOfOpenDaysIn3PastMonth = GetValue(data, 40).ToDecimal(),
                    PercentOfOpenDaysIn12PastMonth = GetValue(data, 41).ToDecimal(),
                    RankOfOpenDaysIn3PastMonth = GetValue(data, 42).ToInt(),
                    RankOfOpenDaysIn12PastMonth = GetValue(data, 43).ToDecimal(),
                    NumberOfCloseDaysIn3PastMonth = GetValue(data, 44).ToDecimal(),
                    NumberOfCloseDaysIn12PastMonth = GetValue(data, 45).ToDecimal(),
                    PercentOfCloseDaysIn3PastMonth = GetValue(data, 46).ToDecimal(),
                    PercentOfCloseDaysIn12PastMonth = GetValue(data, 47).ToDecimal(),
                    RankOfCloseDaysIn3PastMonth = GetValue(data, 48).ToInt(),
                    RankOfCloseDaysIn12PastMonth = GetValue(data, 49).ToInt()
                };
            }
            catch (Exception)
            {
                return new SymbolStatus();
            }
        }

        private BuyersSellers GetBuyersSellers(IDictionary<int, string> data)
        {
            try
            {
                return new BuyersSellers()
                {
                    AverageOfBuyersNumberIn3PastMonth = GetValue(data, 66).ToInt(),
                    AverageOfBuyersNumberIn12PastMonth = GetValue(data, 67).ToInt(),
                    RankOfBuyersNumberIn3PastMonth = GetValue(data, 68).ToInt(),
                    RankOfBuyersNumberIn12PastMonth = GetValue(data, 69).ToInt(),
                    AverageOfSellersNumberIn3PastMonth = GetValue(data, 86).ToInt(),
                    AverageOfSellersNumberIn12PastMonth = GetValue(data, 87).ToInt(),
                    RankOfSellersNumberIn3PastMonth = GetValue(data, 88).ToInt(),
                    RankOfSellersNumberIn12PastMonth = GetValue(data, 89).ToInt(),
                };
            }
            catch (Exception)
            {
                return new BuyersSellers();
            }
        }

        private LegalReal GetLegalReal(IDictionary<int, string> data)
        {
            try
            {
                return new LegalReal()
                {
                    AverageOfRealBuyVolumeIn3PastMonth = GetValue(data, 50).ToDecimal(),
                    AverageOfRealBuyVolumeIn12PastMonth = GetValue(data, 51).ToDecimal(),
                    RankOfRealBuyVolumeIn3PastMonth = GetValue(data, 52).ToInt(),
                    RankOfRealBuyVolumeIn12PastMonth = GetValue(data, 53).ToInt(),
                    AverageOfLegalBuyVolumeIn3PastMonth = GetValue(data, 54).ToDecimal(),
                    AverageOfLegalBuyVolumeIn12PastMonth = GetValue(data, 55).ToDecimal(),
                    RankOfLegalBuyVolumeIn3PastMonth = GetValue(data, 56).ToInt(),
                    RankOfLegalBuyVolumeIn12PastMonth = GetValue(data, 57).ToInt(),
                    AverageNumberOfRealBuyerIn3PastMonth = GetValue(data, 58).ToInt(),
                    AverageNumberOfRealBuyerIn12PastMonth = GetValue(data, 59).ToInt(),
                    RankOfNumberOfRealBuyerIn3PastMonth = GetValue(data, 60).ToInt(),
                    RankOfNumberOfRealBuyerIn12PastMonth = GetValue(data, 61).ToInt(),
                    AverageNumberOfLegalBuyerIn3PastMonth = GetValue(data, 62).ToInt(),
                    AverageNumberOfLegalBuyerIn12PastMonth = GetValue(data, 63).ToInt(),
                    RankOfNumberOfLegalBuyerIn3PastMonth = GetValue(data, 64).ToInt(),
                    RankOfNumberOfLegalBuyerIn12PastMonth = GetValue(data, 65).ToInt(),
                    AverageOfRealSellVolumeIn3PastMonth = GetValue(data, 70).ToDecimal(),
                    AverageOfRealSellVolumeIn12PastMonth = GetValue(data, 71).ToDecimal(),
                    RankOfRealSellVolumeIn3PastMonth = GetValue(data, 72).ToInt(),
                    RankOfRealSellVolumeIn12PastMonth = GetValue(data, 73).ToInt(),
                    AverageOfLegalSellVolumeIn3PastMonth = GetValue(data, 74).ToDecimal(),
                    AverageOfLegalSellVolumeIn12PastMonth = GetValue(data, 75).ToDecimal(),
                    RankOfLegalSellVolumeIn3PastMonth = GetValue(data, 76).ToInt(),
                    RankOfLegalSellVolumeIn12PastMonth = GetValue(data, 77).ToInt(),
                    AverageNumberOfRealSellerIn3PastMonth = GetValue(data, 78).ToInt(),
                    AverageNumberOfRealSellerIn12PastMonth = GetValue(data, 79).ToInt(),
                    RankOfNumberOfRealSellerIn3PastMonth = GetValue(data, 80).ToInt(),
                    RankOfNumberOfRealSellerIn12PastMonth = GetValue(data, 81).ToInt(),
                    AverageNumberOfLegalSellerIn3PastMonth = GetValue(data, 82).ToInt(),
                    AverageNumberOfLegalSellerIn12PastMonth = GetValue(data, 83).ToInt(),
                    RankOfNumberOfLegalSellerIn3PastMonth = GetValue(data, 84).ToInt(),
                    RankOfNumberOfLegalSellerIn12PastMonth = GetValue(data, 85).ToInt(),
                };
            }
            catch (Exception)
            {
                return new LegalReal();
            }
        }

        private string GetValue(IDictionary<int, string> data, int id)
        {
            try
            {
                if (data.Keys.Where(x => x == id).Count() <= 0)
                    return "0";
                return data[id];
            }
            catch (Exception)
            {
                return "0";
            }
        }

        private IDictionary<int, string> GetKeyValues(string[] values)
        {
            try
            {
                Dictionary<int, string> valuePairs = new Dictionary<int, string>();
                foreach (var item in values)
                {
                    try
                    {
                        var sp = item.Split(',');
                        valuePairs.Add(sp[0].ToInt(), sp[1]);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                return valuePairs;
            }
            catch (Exception)
            {
                return new Dictionary<int, string>();
            }
        }
    }
}
