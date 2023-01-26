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
        public string Title { get; set; }

        /// <summary>
        /// نام گزارش
        /// </summary>
        public string ReportName { get; set; }

        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        public string PublishDate { get; set; }

        /// <summary>
        /// سال مالی
        /// </summary>
        public string YearEndToDate { get; set; }

        /// <summary>
        /// دوره مالی
        /// </summary>
        public string PeriodEndToDate { get; set; }

        /// <summary>
        /// اطلاعات
        /// </summary>
        public List<List<string>> Data { get; set; }

        /// <summary>
        /// دوره زمانی
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public BalanceSheetStatus Status { get; set; }

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
