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
        public int LastTransaction { get; internal set; }
        
        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public int FinalPrice { get; internal set; }

        /// <summary>
        /// اولین قیمت
        /// </summary>
        public int FirstPrice { get; internal set; }

        /// <summary>
        /// قیمت دیروز
        /// </summary>
        public int YesterdayPrice { get; internal set; }

        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public int TransactionCount { get; internal set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public ulong TransactionVolume { get; internal set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public ulong TransactionValue { get; internal set; }

        /// <summary>
        /// بازه روز
        /// </summary>
        public Range TodayRange { get; internal set; }
    }

    public class Range
    {
        public int Low { get; set; }
        public int High { get; set; }
    }
}
