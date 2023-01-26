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
        public string Title { get; set; }

        /// <summary>
        /// تاریخ
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// نام گزارش
        /// </summary>
        public string ReportName { get; set; }

        /// <summary>
        /// سال گزارش
        /// </summary>
        public string YearEndToDate { get; set; }

        /// <summary>
        /// دوره گزارش
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// وضعیت حسابرسی
        /// </summary>
        public string IsAudited { get; set; }

        /// <summary>
        /// دوره مالی
        /// </summary>
        public string PeriodEndToDate { get; set; }

        /// <summary>
        /// اطلاعات
        /// </summary>
        public List<List<string>> Data { get; set; }
    }
}
