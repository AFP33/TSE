//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    public class DPS
    {
        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        public string PublishDate { get; internal set; }

        /// <summary>
        /// تاریخ مجمع
        /// </summary>
        public string CouncilDate { get; internal set; }

        /// <summary>
        /// سال مالی
        /// </summary>
        public string FiscalYear { get; internal set; }

        /// <summary>
        /// سود یا زیان پس از کسر مالیات
        /// </summary>
        public decimal ProfitOrLoss { get; internal set; }

        /// <summary>
        /// سود قابل تخصیص
        /// </summary>
        public decimal DistributableProfit { get; internal set; }

        /// <summary>
        /// سود انباشته پایان دوره
        /// </summary>
        public decimal AccumulatedProfit { get; internal set; }

        /// <summary>
        /// سود نقدی هر سهم
        /// </summary>
        public decimal CashProfit { get; internal set; }
    }
}
