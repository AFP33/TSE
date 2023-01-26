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
        public string MarketStatus { get; set; }

        /// <summary>
        /// شاخص کل
        /// </summary>
        public string OverallIndex { get; set; }

        /// <summary>
        /// ارزش بازار اول و دوم
        /// </summary>
        public string Market1_2Value { get; set; }

        /// <summary>
        /// ارزش بازار پایه
        /// </summary>
        public string BaseMarketValue { get; set; }

        /// <summary>
        /// اطلاعات قیمت
        /// </summary>
        public string PriceInformation { get; set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string TransactionCount { get; set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string TransactionValue { get; set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public string TransactionVolume { get; set; }

        /// <summary>
        /// تاثیر در شاخص
        /// </summary>
        public List<EffectiveOnIndex> EffectiveOnIndex { get; set; }

        /// <summary>
        /// نماد های پرتراکنش
        /// </summary>
        public List<TopTransactionSymbol> TopTransactionSymbol { get; set; }
    }
}
