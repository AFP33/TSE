using System.Collections.Generic;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// سود و زیان
    /// </summary>
    public class CostBenefit
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// تاریخ
        /// </summary>
        public string Date { get; internal set; }

        /// <summary>
        /// نام گزارش
        /// </summary>
        public string ReportName { get; internal set; }

        /// <summary>
        /// سال گزارش
        /// </summary>
        public string YearEndToDate { get; internal set; }

        /// <summary>
        /// دوره گزارش
        /// </summary>
        public string Period { get; internal set; }

        /// <summary>
        /// وضعیت حسابرسی
        /// </summary>
        public string IsAudited { get; internal set; }

        /// <summary>
        /// دوره مالی
        /// </summary>
        public string PeriodEndToDate { get; internal set; }

        /// <summary>
        /// اطلاعات
        /// </summary>
        public List<List<string>> Data { get; internal set; }
    }
}
