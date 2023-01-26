using System.Collections.Generic;

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
        public string MarketStatus { get; internal set; }

        /// <summary>
        /// شاخص کل
        /// </summary>
        public string OverallIndex { get; internal set; }

        /// <summary>
        /// شاخص هم وزن
        /// </summary>
        public string WeightIndex { get; internal set; }

        /// <summary>
        /// ارزش بازار
        /// </summary>
        public string MarketValue { get; internal set; }

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
        /// شاخص های منتخب
        /// </summary>
        public List<ChosenIndexes> ChosenIndexes { get; internal set; }

        /// <summary>
        /// تاثیر در شاخص
        /// </summary>
        public List<EffectiveOnIndex> EffectiveOnIndex { get; internal set; }

        /// <summary>
        /// نماد های پرتراکنش
        /// </summary>
        public List<TopTransactionSymbol> TopTransactionSymbol { get; internal set; }
    }

    /// <summary>
    /// شاخصهای منتخب
    /// </summary>
    public class ChosenIndexes
    {
        /// <summary>
        /// شاخص
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        /// انتشار
        /// </summary>
        public string Publish { get; set; }

        /// <summary>
        /// مقدار
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// تغییر
        /// </summary>
        public string Change { get; set; }

        /// <summary>
        /// درصد
        /// </summary>
        public string Percent { get; set; }

        /// <summary>
        /// بیشترین
        /// </summary>
        public string Hight { get; set; }

        /// <summary>
        /// کمترین
        /// </summary>
        public string Less { get; set; }
    }

    /// <summary>
    /// تاثیر در شاخص
    /// </summary>
    public class EffectiveOnIndex
    {
        /// <summary>
        /// نماد
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public string FinalPrice { get; set; }

        /// <summary>
        /// تاثیر
        /// </summary>
        public string Efficacy { get; set; }
    }

    /// <summary>
    /// نمادهای پر تراکنش
    /// </summary>
    public class TopTransactionSymbol
    {
        /// <summary>
        /// نماد
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public string FinalPrice { get; set; }

        /// <summary>
        /// آخرین معامله
        /// </summary>
        public string LastTransaction { get; set; }

        /// <summary>
        /// بیشترین
        /// </summary>
        public string Hight { get; set; }

        /// <summary>
        /// کمترین
        /// </summary>
        public string Less { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        public string Count { get; set; }

        /// <summary>
        /// حجم
        /// </summary>
        public string Volume { get; set; }

        /// <summary>
        /// ارزش
        /// </summary>
        public string Value { get; set; }
    }
}
