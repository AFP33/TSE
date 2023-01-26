//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// حقیقی و حقوقی
    /// </summary>
    public class RealLegal
    {
        /// <summary>
        /// تاریخ معاملات
        /// </summary>
        public string Date { get; internal set; }

        /// <summary>
        /// معاملات خرید
        /// </summary>
        public Buy Buyes { get; internal set; }

        /// <summary>
        /// معاملات فروش
        /// </summary>
        public Sell Sellers { get; internal set; }

        /// <summary>
        /// تغییر مالکیت حقوقی به حقیقی
        /// </summary>
        public string OwnershipLegalToReal { get; internal set; }
    }

    /// <summary>
    /// خریدها
    /// </summary>
    public class Buy
    {
        /// <summary>
        /// خرید حقیقی
        /// </summary>
        public Items Real { get; internal set; }

        /// <summary>
        /// خرید حقوقی
        /// </summary>
        public Items Legal { get; internal set; }
    }

    /// <summary>
    /// فروشها
    /// </summary>
    public class Sell
    {
        /// <summary>
        /// فروش حقیقی
        /// </summary>
        public Items Real { get; internal set; }

        /// <summary>
        /// فروش حقوقی
        /// </summary>
        public Items Legal { get; internal set; }
    }

    public class Items
    {
        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string Count { get; internal set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public string Volume { get; internal set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string Value { get; internal set; }

        /// <summary>
        /// قیمت میانگین
        /// </summary>
        public string AveragePrice { get; internal set; }
    }
}
