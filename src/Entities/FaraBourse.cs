using System.Collections.Generic;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    public class FaraBourse
    {
        /// <summary>
        /// وضعیت بازار
        /// </summary>
        public string MarketStatus { get; internal set; }

        /// <summary>
        /// شاخص کل
        /// </summary>
        public string OverallIndex { get; internal set; }

        /// <summary>
        /// ارزش بازار اول و دوم
        /// </summary>
        public string Market1_2Value { get; internal set; }

        /// <summary>
        /// ارزش بازار پایه
        /// </summary>
        public string BaseMarketValue { get; internal set; }

        /// <summary>
        /// اطلاعات قیمت
        /// </summary>
        public string PriceInformation { get; internal set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string TransactionCount { get; internal set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string TransactionValue { get; internal set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public string TransactionVolume { get; internal set; }

        /// <summary>
        /// تاثیر در شاخص
        /// </summary>
        public List<EffectiveOnIndex> EffectiveOnIndex { get; internal set; }

        /// <summary>
        /// نماد های پرتراکنش
        /// </summary>
        public List<TopTransactionSymbol> TopTransactionSymbol { get; internal set; }
    }
}
