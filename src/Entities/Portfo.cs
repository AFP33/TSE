using System.Collections.Generic;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// نمایش اطلاعات بخش پورتفوی
    /// </summary>
    public class Portfo
    {
        /// <summary>
        /// پرتفو به تفکیک گروه صنعت
        /// </summary>
        public IList<ByIndustryGroup> ByIndustryGroup { get; internal set; }

        /// <summary>
        /// پرتفوی شرکت های بورسی
        /// </summary>
        public IList<CompaniesPortfo> CompaniesInBourse { get; internal set; }

        /// <summary>
        /// پرتفو شرکت های غیر بورسی
        /// </summary>
        public IList<CompaniesPortfo> CompaniesOutBourse { get; internal set; }

        /// <summary>
        /// صورت ریز معاملات تحصیل شده
        /// </summary>
        public IList<ObtainingAllTransactions> ObtainingAllTransactions { get; internal set; }

        /// <summary>
        /// صورت ریز معاملات واگذار شده
        /// </summary>
        public IList<AssignmentTransaction> AssignmentTransaction { get; internal set; }
    }

    /// <summary>
    /// پرتفوی به تفکیک گروه صنعت
    /// </summary>
    public class ByIndustryGroup
    {
        public PortfoBasicInfo PortfoBasicInfo { get; internal set; }

        public IList<ByIndustryGroupFields> ByIndustryGroupFields { get; internal set; }
    }

    /// <summary>
    /// پورتفوی شرکتها (بورسی و غیر بورسی)
    /// </summary>
    public class CompaniesPortfo
    {
        public PortfoBasicInfo PortfoBasicInfo { get; internal set; }

        public IList<CompaniesPortfoFields> CompaniesPortfoFields { get; internal set; }
    }

    /// <summary>
    /// ریز معاملات تحصیل شده
    /// </summary>
    public class ObtainingAllTransactions
    {
        public PortfoBasicInfo PortfoBasicInfo { get; internal set; }

        public IList<ObtainingAllTransactionsFields> ObtainingAllTransactionsFields { get; internal set; }
    }

    /// <summary>
    /// ریز معاملات واگذار شده
    /// </summary>
    public class AssignmentTransaction
    {
        public PortfoBasicInfo PortfoBasicInfo { get; internal set; }

        public IList<AssignmentTransactionFields> AssignmentTransactionFields { get; internal set; }
    }

    public class ByIndustryGroupFields
    {
        /// <summary>
        /// عنوان آیتم پرتفو
        /// </summary>
        public string Item { get; internal set; }

        /// <summary>
        /// پذیرفته شده در بورس
        /// </summary>
        public Period AcceptedInMarket { get; internal set; }

        /// <summary>
        /// خارج از بورس
        /// </summary>
        public Period OutOffMarket { get; internal set; }

        /// <summary>
        /// جمع سرمایه گذاری
        /// </summary>
        public Period TotalInvestment { get; internal set; }
    }

    public class CompaniesPortfoFields
    {
        /// <summary>
        /// نام شرکت
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// سرمایه
        /// </summary>
        public ulong Capital { get; internal set; }

        /// <summary>
        /// ارزش اسمی هر سهم
        /// </summary>
        public int NominalValue { get; internal set; }

        /// <summary>
        /// دوره (ابتدای دوره، تغییرات، انتهای دوره)
        /// </summary>
        public Period PeriodsValue { get; internal set; }
    }

    public class ObtainingAllTransactionsFields
    {
        /// <summary>
        ///  نام شرکت
        /// </summary>
        public string ComapanyName { get; internal set; }

        /// <summary>
        /// تعداد سهام
        /// </summary>
        public ulong NumberOfStocks { get; internal set; }

        /// <summary>
        /// بهای تمام شده هر سهم
        /// </summary>
        public int StockActivityCost { get; internal set; }

        /// <summary>
        /// کل مبلغ بهای تمام شده پذیرفته شده در بورس
        /// </summary>
        public int TotalAmountActivityCostInBourse { get; internal set; }

        /// <summary>
        /// کل مبلغ بهای تمام شده پذیرفته شده در خارج از بورس
        /// </summary>
        public int TotalAmountActivityCostInOutBourse { get; internal set; }
    }

    public class AssignmentTransactionFields
    {
        /// <summary>
        ///  نام شرکت
        /// </summary>
        public string ComapanyName { get; internal set; }

        /// <summary>
        /// تعداد سهام
        /// </summary>
        public ulong NumberOfStocks { get; internal set; }

        /// <summary>
        /// بهای تمام شده هر سهم
        /// </summary>
        public int StockActivityCost { get; internal set; }

        /// <summary>
        /// کل مبلغ بهای تمام شده
        /// </summary>
        public int TotalAmountActivityConst { get; internal set; }

        /// <summary>
        /// قیمت واگذاری هر سهم
        /// </summary>
        public int PriceOfAssignmentPerStock { get; internal set; }

        /// <summary>
        /// کل مبلغ واگذاری
        /// </summary>
        public int TotalAmountOfAssignment { get; internal set; }

        /// <summary>
        /// سود و زیان واگذاری
        /// </summary>
        public int ProfitOfAssignment { get; internal set; }
    }

    /// <summary>
    /// نمایش دهنده یک دوره
    /// </summary>
    public class Period
    {
        /// <summary>
        /// ابتدای دوره
        /// </summary>
        public PeriodItems OutsetPeriod { get; internal set; }
        
        /// <summary>
        /// تغییرات
        /// </summary>
        public PeriodItems Change { get; internal set; }

        /// <summary>
        /// انتهای دوره
        /// </summary>
        public PeriodItems OutrancePeriod { get; internal set; }
    }

    /// <summary>
    /// .ویژگی های یک دوره
    /// مقادیر این کلاس بسته به نوع تفکیک شده پرتفوی متفاوت خواهد بود
    /// </summary>
    public class PeriodItems
    {
        /// <summary>
        /// تعداد شرکت
        /// </summary>
        public int? NumberOfCompany { get; internal set; }

        /// <summary>
        /// بهای تمام شده
        /// </summary>
        public long? ActivityCost { get; internal set; }

        /// <summary>
        /// ارزش بازار
        /// </summary>
        public long? MarketValue { get; internal set; }

        /// <summary>
        /// درصد کل
        /// </summary>
        public decimal? TotalPercentage { get; internal set; }

        /// <summary>
        /// تعداد سهام
        /// </summary>
        public long? NumberOfStocks { get; internal set; }

        /// <summary>
        /// درصد مالکیت
        /// </summary>
        public decimal? OwnershipPercentage { get; internal set; }

        /// <summary>
        /// بهای تمام شده هر سهم
        /// </summary>
        public int? StockActivityCost { get; internal set; }

        /// <summary>
        /// ارزش هر سهم
        /// </summary>
        public int? StockValue { get; internal set; }

        /// <summary>
        /// افزایش (کاهش)
        /// </summary>
        public int? IncreaseDecrease { get; internal set; }

        /// <summary>
        /// کل مبلغ بهای تمام شده
        /// </summary>
        public int? TotalAmountActivityConst { get; internal set; }
    }

    public class PortfoBasicInfo
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        public DateTime? Publish { get; internal set; }

        /// <summary>
        /// نام گزارش
        /// </summary>
        public string ReportName { get; internal set; }

        /// <summary>
        /// انتهای سال مالی
        /// </summary>
        public DateTime? YearEndToDate { get; internal set; }

        /// <summary>
        /// دوره
        /// </summary>
        public string Period { get; internal set; }

        /// <summary>
        /// وضعیت حسابرسی
        /// </summary>
        public bool IsAudited { get; internal set; }

        /// <summary>
        /// انتهای دوره
        /// </summary>
        public DateTime? PeriodEndToDate { get; internal set; }
    }
}
