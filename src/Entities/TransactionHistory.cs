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
        public string Date { get; internal set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string Count { get; internal set; }

        /// <summary>
        /// حجم معاملات انجام شده
        /// </summary>
        public string Volume { get; internal set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string Value { get; internal set; }

        /// <summary>
        /// قیمت دیروز
        /// </summary>
        public string YesterdayPrice { get; internal set; }

        /// <summary>
        /// اولین قیمت
        /// </summary>
        public string FirstPrice { get; internal set; }

        /// <summary>
        /// آخرین قیمت
        /// </summary>
        public string LastTransactionPrice { get; internal set; }

        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public string FinalTransactionPrice { get; internal set; }

        /// <summary>
        /// کمترین قیمت
        /// </summary>
        public string MinimumPrice { get; internal set; }

        /// <summary>
        /// بیشترین قیمت
        /// </summary>
        public string MaximumPrice { get; internal set; }
    }

    public enum TransactionHistoryType
    {
        AllDay,
        TradedDay
    }
}
