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
        public string LastTransaction { get; set; }
        
        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public string FinalPrice { get; set; }

        /// <summary>
        /// اولین قیمت
        /// </summary>
        public string FirstPrice { get; set; }

        /// <summary>
        /// قیمت دیروز
        /// </summary>
        public string YesterdayPrice { get; set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string TransactionCount { get; set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public string TransactionVolume { get; set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string TransactionValue { get; set; }

        /// <summary>
        /// ارزش بازار
        /// </summary>
        public string MarketValue { get; set; }

        /// <summary>
        /// بازه روز
        /// </summary>
        public Range TodayRange { get; set; }
    }

    public class Range
    {
        public string Low { get; set; }
        public string High { get; set; }
    }
}
