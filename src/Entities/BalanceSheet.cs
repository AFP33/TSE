using System.Collections.Generic;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// ترازنامه
    /// </summary>
    public class BalanceSheet
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// نام گزارش
        /// </summary>
        public string ReportName { get; internal set; }

        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        public string PublishDate { get; internal set; }

        /// <summary>
        /// سال مالی
        /// </summary>
        public string YearEndToDate { get; internal set; }

        /// <summary>
        /// دوره مالی
        /// </summary>
        public string PeriodEndToDate { get; internal set; }

        /// <summary>
        /// اطلاعات
        /// </summary>
        public List<List<string>> Data { get; internal set; }

        /// <summary>
        /// دوره زمانی
        /// </summary>
        public string Period { get; internal set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public BalanceSheetStatus Status { get; internal set; }

    }

    /// <summary>
    /// وضعیت ترازنامه
    /// </summary>
    public enum BalanceSheetStatus
    {
        /// <summary>
        /// حسابرسی شده
        /// </summary>
        AUDITE,

        /// <summary>
        /// حسابرسی نشده
        /// </summary>
        NOTAUDITE
    }
}
