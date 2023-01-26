//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// اطلاعات اولیه یک نماد را نشان میدهد
    /// </summary>
    public class BriefInformation
    {
        /// <summary>
        /// آخرین معامله
        /// </summary>
        public string LastTransaction { get; internal set; }
        
        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public string FinalPrice { get; internal set; }

        /// <summary>
        /// اولین قیمت
        /// </summary>
        public string FirstPrice { get; internal set; }

        /// <summary>
        /// قیمت دیروز
        /// </summary>
        public string YesterdayPrice { get; internal set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string TransactionCount { get; internal set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public string TransactionVolume { get; internal set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string TransactionValue { get; internal set; }

        /// <summary>
        /// ارزش بازار
        /// </summary>
        public string MarketValue { get; internal set; }

        /// <summary>
        /// بازه روز
        /// </summary>
        public Range TodayRange { get; internal set; }
    }

    public class Range
    {
        public string Low { get; set; }
        public string High { get; set; }
    }
}
