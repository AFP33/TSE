
//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    public class Bourse
    {
        /// <summary>
        /// وضعیت بازار
        /// </summary>
        public MarketStatus MarketStatus { get; internal set; }

        /// <summary>
        /// شاخص کل
        /// </summary>
        public decimal OverallIndex { get; internal set; }

        /// <summary>
        /// شاخص هم وزن
        /// </summary>
        public decimal WeightIndex { get; internal set; }

        /// <summary>
        /// ارزش بازار
        /// </summary>
        public ulong MarketValue { get; internal set; }

        /// <summary>
        /// اطلاعات قیمت
        /// </summary>
        public string PriceInformation { get; internal set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public int TransactionCount { get; internal set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public ulong TransactionValue { get; internal set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public ulong TransactionVolume { get; internal set; }
    }

    public enum MarketStatus
    {
        Open,
        Close
    }
}
