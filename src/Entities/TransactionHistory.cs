//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    public class TransactionHistory
    {
        /// <summary>
        /// تاریخ معاملات
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string Count { get; set; }

        /// <summary>
        /// حجم معاملات انجام شده
        /// </summary>
        public string Volume { get; set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// قیمت دیروز
        /// </summary>
        public string YesterdayPrice { get; set; }

        /// <summary>
        /// اولین قیمت
        /// </summary>
        public string FirstPrice { get; set; }

        /// <summary>
        /// آخرین قیمت
        /// </summary>
        public string LastTransactionPrice { get; set; }

        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public string FinalTransactionPrice { get; set; }

        /// <summary>
        /// کمترین قیمت
        /// </summary>
        public string MinimumPrice { get; set; }

        /// <summary>
        /// بیشترین قیمت
        /// </summary>
        public string MaximumPrice { get; set; }
    }

    public enum TransactionHistoryType
    {
        AllDay,
        TradedDay
    }
}
