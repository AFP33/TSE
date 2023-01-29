using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    public class Statistics
    {
        /// <summary>
        /// آمار روزهای منفی
        /// </summary>
        public NegetiveDays NegetiveDays { get; internal set; }

        /// <summary>
        /// آمار روزهای مثبت
        /// </summary>
        public PositiveDays PositiveDays { get; internal set; }

        /// <summary>
        /// آمار روزهای معاملاتی
        /// </summary>
        public TradingDays TradingDays { get; internal set; }

        /// <summary>
        /// دفعات معامله
        /// </summary>
        public TradingCounts TradingCounts { get; internal set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public TradingValue TradingValue { get; internal set; }

        /// <summary>
        /// ارزش شرکت
        /// </summary>
        public CompanyValue CompanyValue { get; internal set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public TradingVolume TradingVolume { get; internal set; }

        /// <summary>
        /// قیمت ها
        /// </summary>
        public Prices Prices { get; internal set; }

        /// <summary>
        /// وضعیت نماد
        /// </summary>
        public SymbolStatus SymbolStatus { get; internal set; }

        /// <summary>
        /// خریداران و فروشندگان
        /// </summary>
        public BuyersSellers BuyersSellers { get; internal set; }

        /// <summary>
        /// حقیقی حقوقی
        /// </summary>
        public LegalReal LegalReal { get; internal set; }
    }

    /// <summary>
    /// حقیقی حقوقی
    /// </summary>
    public class LegalReal
    {
        /// <summary>
        /// میانگین حجم خرید حقیقی در 3 ماه گذشته
        /// </summary>
        public decimal AverageOfRealBuyVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم خرید حقیقی در 12 ماه گذشته
        /// </summary>
        public decimal AverageOfRealBuyVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم خرید حقیقی در 3 ماه گذشته
        /// </summary>
        public int RankOfRealBuyVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم خرید حقیقی در 12 ماه گذشته
        /// </summary>
        public int RankOfRealBuyVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم خرید حقوقی در 3 ماه گذشته
        /// </summary>
        public decimal AverageOfLegalBuyVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم خرید حقوقی در 12 ماه گذشته
        /// </summary>
        public decimal AverageOfLegalBuyVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم خرید حقوقی در 3 ماه گذشته
        /// </summary>
        public int RankOfLegalBuyVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم خرید حقوقی در 12 ماه گذشته
        /// </summary>
        public int RankOfLegalBuyVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد خریدار حقیقی در 3 ماه گذشته
        /// </summary>
        public int AverageNumberOfRealBuyerIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد خریدار حقیقی در 12 ماه گذشته
        /// </summary>
        public int AverageNumberOfRealBuyerIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد خریدار حقیقی در 3 ماه گذشته
        /// </summary>
        public int RankOfNumberOfRealBuyerIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد خریدار حقیقی در 12 ماه گذشته
        /// </summary>
        public int RankOfNumberOfRealBuyerIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد خریدار حقوقی در 3 ماه گذشته
        /// </summary>
        public int AverageNumberOfLegalBuyerIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد خریدار حقوقی در 12 ماه گذشته
        /// </summary>
        public int AverageNumberOfLegalBuyerIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد خریدار حقوقی در 3 ماه گذشته
        /// </summary>
        public int RankOfNumberOfLegalBuyerIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد خریدار حقوقی در 12 ماه گذشته
        /// </summary>
        public int RankOfNumberOfLegalBuyerIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم فروش حقیقی در 3 ماه گذشته
        /// </summary>
        public decimal AverageOfRealSellVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم فروش حقیقی در 12 ماه گذشته
        /// </summary>
        public decimal AverageOfRealSellVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم فروش حقیقی در 3 ماه گذشته
        /// </summary>
        public int RankOfRealSellVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم فروش حقیقی در 12 ماه گذشته
        /// </summary>
        public int RankOfRealSellVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم فروش حقوقی در 3 ماه گذشته
        /// </summary>
        public decimal AverageOfLegalSellVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم فروش حقوقی در 12 ماه گذشته
        /// </summary>
        public decimal AverageOfLegalSellVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم فروش حقوقی در 3 ماه گذشته
        /// </summary>
        public int RankOfLegalSellVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم فروش حقوقی در 12 ماه گذشته
        /// </summary>
        public int RankOfLegalSellVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد فروشنده حقیقی در 3 ماه گذشته
        /// </summary>
        public int AverageNumberOfRealSellerIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد فروشنده حقیقی در 12 ماه گذشته
        /// </summary>
        public int AverageNumberOfRealSellerIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد فروشنده حقیقی در 3 ماه گذشته
        /// </summary>
        public int RankOfNumberOfRealSellerIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد فروشنده حقیقی در 12 ماه گذشته
        /// </summary>
        public int RankOfNumberOfRealSellerIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد فروشنده حقوقی در 3 ماه گذشته
        /// </summary>
        public int AverageNumberOfLegalSellerIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد فروشنده حقوقی در 12 ماه گذشته
        /// </summary>
        public int AverageNumberOfLegalSellerIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد فروشنده حقوقی در 3 ماه گذشته
        /// </summary>
        public int RankOfNumberOfLegalSellerIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد فروشنده حقوقی در 12 ماه گذشته
        /// </summary>
        public int RankOfNumberOfLegalSellerIn12PastMonth { get; internal set; }
    }

    /// <summary>
    /// خریداران و فروشندگان
    /// </summary>
    public class BuyersSellers
    {
        /// <summary>
        /// میانگین تعداد خریداران در 3 ماه گذشته
        /// </summary>
        public int AverageOfBuyersNumberIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد خریداران در 12 ماه گذشته
        /// </summary>
        public int AverageOfBuyersNumberIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد خریداران در 3 ماه گذشته
        /// </summary>
        public int RankOfBuyersNumberIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد خریداران در 12 ماه گذشته
        /// </summary>
        public int RankOfBuyersNumberIn12PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد فروشندگان در 3 ماه گذشته
        /// </summary>
        public int AverageOfSellersNumberIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین تعداد فروشندگان در 12 ماه گذشته
        /// </summary>
        public int AverageOfSellersNumberIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد فروشندگان در 3 ماه گذشته
        /// </summary>
        public int RankOfSellersNumberIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه تعداد فروشندگان در 12 ماه گذشته
        /// </summary>
        public int RankOfSellersNumberIn12PastMonth { get; internal set; }
    }

    /// <summary>
    /// وضعیت نماد
    /// </summary>
    public class SymbolStatus
    {
        /// <summary>
        /// تعداد روزهای باز در 3 ماه گذشته
        /// </summary>
        public int NumberOfOpenDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// تعداد روزهای باز در 12 ماه گذشته
        /// </summary>
        public int NumberOfOpenDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای باز در 3 ماه گذشته
        /// </summary>
        public decimal PercentOfOpenDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای باز در 12 ماه گذشته
        /// </summary>
        public decimal PercentOfOpenDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای باز در 3 ماه گذشته
        /// </summary>
        public int RankOfOpenDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای باز در 12 ماه گذشته
        /// </summary>
        public decimal RankOfOpenDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// تعداد روزهای بسته در 3 ماه گذشته
        /// </summary>
        public decimal NumberOfCloseDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// تعداد روزهای بسته در 12 ماه گذشته
        /// </summary>
        public decimal NumberOfCloseDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای بسته در 3 ماه گذشته
        /// </summary>
        public decimal PercentOfCloseDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای بسته در 12 ماه گذشته
        /// </summary>
        public decimal PercentOfCloseDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای بسته در 3 ماه گذشته
        /// </summary>
        public int RankOfCloseDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای بسته در 12 ماه گذشته
        /// </summary>
        public int RankOfCloseDaysIn12PastMonth { get; internal set; }
    }

    /// <summary>
    /// قیمت ها
    /// </summary>
    public class Prices
    {
        /// <summary>
        /// قیمت میانگین وزنی آخرین روز - بدون دخالت حجم مبنا
        /// </summary>
        public decimal WeightedAveragePriceInLastDayWithoutBaseVolume { get; internal set; }

        /// <summary>
        /// قیمت میانگین وزنی آخرین روز - با دخالت حجم مبنا
        /// </summary>
        public decimal WeightedAveragePriceInLastDayWithBaseVolume { get; internal set; }

    }

    /// <summary>
    /// حجم معاملات
    /// </summary>
    public class TradingVolume
    {
        /// <summary>
        /// میانگین حجم معاملات در 3 ماه گذشته
        /// </summary>
        public ulong AverageTradingVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین حجم معاملات در 12 ماه گذشته
        /// </summary>
        public ulong AverageTradingVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم معاملات در 3 ماه گذشته
        /// </summary>
        public int RankOfTradingVolumeIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه حجم معاملات در 12 ماه گذشته
        /// </summary>
        public int RankOfTradingVolumeIn12PastMonth { get; internal set; }

        /// <summary>
        /// حجم معاملات آخرین روز
        /// </summary>
        public ulong TradingVolumeInLastDay { get; internal set; }

    }

    /// <summary>
    /// ارزش شرکت
    /// </summary>
    public class CompanyValue
    {
        /// <summary>
        /// ارزش شرکت در آخرین روز
        /// </summary>
        public decimal CompanyValueInLastDay { get; internal set; }

        /// <summary>
        /// رتبه ارزش شرکت در آخرین روز
        /// </summary>
        public int RankOfCompanyValueInLastDay { get; internal set; }
    }

    /// <summary>
    /// ارزش معاملات
    /// </summary>
    public class TradingValue
    {
        /// <summary>
        /// میانگین ارزش معاملات در 3 ماه گذشته
        /// </summary>
        public decimal AverageTradingValueIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین ارزش معاملات در 12 ماه گذشته
        /// </summary>
        public decimal AverageTradingValueIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه ارزش معاملات در 3 ماه گذشته
        /// </summary>
        public int RankTradingValueIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه ارزش معاملات در 12 ماه گذشته
        /// </summary>
        public int RankTradingValueIn12PastMonth { get; internal set; }

        /// <summary>
        /// ارزش معاملات آخرین روز
        /// </summary>
        public decimal TradingValueInLastDay { get; internal set; }
    }

    /// <summary>
    /// دفعات معامله
    /// </summary>
    public class TradingCounts
    {
        /// <summary>
        /// میانگین دفعات معاملات روزانه در 3 ماه گذشته
        /// </summary>
        public int AverageDailyTradingCountsIn3PastMonth { get; internal set; }

        /// <summary>
        /// میانگین دفعات معاملات روزانه در 12 ماه گذشته
        /// </summary>
        public int AverageDailyTradingCountsIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه دفعات معاملات روزانه در 3 ماه گذشته
        /// </summary>
        public int RankOfDailyTradingCountsIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه دفعات معاملات روزانه در 12 ماه گذشته
        /// </summary>
        public int RankOfDailyTradingCountsIn12PastMonth { get; internal set; }

        /// <summary>
        /// دفعات معاملات در آخرین روز
        /// </summary>
        public int TradingCountsInLastDay { get; internal set; }

    }

    /// <summary>
    /// آمار روزهای معاملاتی
    /// </summary>
    public class TradingDays
    {
        /// <summary>
        /// روزهای بدون معامله در 3 ماه گذشته
        /// </summary>
        public int DaysWithoutTradingIn3PastMonth { get; internal set; }

        /// <summary>
        /// روزهای بدون معامله در 12 ماه گذشته
        /// </summary>
        public int DaysWithoutTradingIn12PastMonth { get; internal set; }

        /// <summary>
        /// روزهای با معامله در 3 ماه گذشته
        /// </summary>
        public int DaysWithTradingIn3PastMonth { get; internal set; }

        /// <summary>
        /// روزهای با معامله در 12 ماه گذشته
        /// </summary>
        public int DaysWithTradingIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای با معامله در 3 ماه گذشته
        /// </summary>
        public int RankOfTradingDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای با معامله در 12 ماه گذشته
        /// </summary>
        public int RankOfTradingDaysIn12PastMonth { get; internal set; }
    }

    /// <summary>
    /// آمار روزهای منفی
    /// </summary>
    public class NegetiveDays
    {
        /// <summary>
        /// تعداد روزهای منفی در 3 ماه گذشته
        /// </summary>
        public int NumberOfNegetiveDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// تعداد روزهای منفی در 12 ماه گذشته
        /// </summary>
        public int NumberOfNegetiveDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای منفی در 3 ماه گذشته
        /// </summary>
        public decimal PercentOfNegetiveDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای منفی در 12 ماه گذشته
        /// </summary>
        public decimal PercentOfNegetiveDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای منفی در 3 ماه گذشته
        /// </summary>
        public int RankOfNegetiveDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای منفی در 12 ماه گذشته
        /// </summary>
        public int RankOfNegetiveDaysIn12PastMonth { get; internal set; }
    }

    /// <summary>
    /// آمار روزهای مثبت
    /// </summary>
    public class PositiveDays
    {
        /// <summary>
        /// تعداد روزهای مثبت در 3 ماه گذشته
        /// </summary>
        public int NumberOfPositiveDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// تعداد روزهای مثبت در 12 ماه گذشته
        /// </summary>
        public int NumberOfPositiveDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای مثبت در 3 ماه گذشته
        /// </summary>
        public decimal PercentOfPositiveDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// درصد روزهای مثبت در 12 ماه گذشته
        /// </summary>
        public decimal PercentOfPositiveDaysIn12PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای مثبت در 3 ماه گذشته
        /// </summary>
        public int RankOfPositiveDaysIn3PastMonth { get; internal set; }

        /// <summary>
        /// رتبه روزهای مثبت در 12 ماه گذشته
        /// </summary>
        public int RankOfPositiveDaysIn12PastMonth { get; internal set; }
    }
}
