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

        /// <summary>
        /// معاملات حقیقی ها
        /// </summary>
        public CurrentDayTransactionDetails RealsTransaction { get; internal set; }

        /// <summary>
        /// معاملات حقوقی ها
        /// </summary>
        public CurrentDayTransactionDetails LegalTransaction { get; internal set; }
    }

    public class Range
    {
        /// <summary>
        /// حد پایین
        /// </summary>
        public int Low { get; internal set; }

        /// <summary>
        /// حد بالا
        /// </summary>
        public int High { get; internal set; }
    }

    /// <summary>
    /// جزئیات معاملات
    /// حقیقی - حقوقی
    /// </summary>
    public class CurrentDayTransactionDetails
    {
        /// <summary>
        /// تعداد خریداران
        /// </summary>
        public int BuyerCount { get; internal set; }

        /// <summary>
        /// حجم معاملات خرید
        /// </summary>
        public long BuyerVolume { get; internal set; }

        /// <summary>
        /// تعداد فروشندگان
        /// </summary>
        public int SellerCount { get; internal set; }

        /// <summary>
        /// حجم معاملات فروش
        /// </summary>
        public long SellerVolume { get; internal set; }
    }
}
