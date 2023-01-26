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
        public string Date { get; set; }

        /// <summary>
        /// معاملات خرید
        /// </summary>
        public Buy Buyes { get; set; }

        /// <summary>
        /// معاملات فروش
        /// </summary>
        public Sell Sellers { get; set; }

        /// <summary>
        /// تغییر مالکیت حقوقی به حقیقی
        /// </summary>
        public string OwnershipLegalToReal { get; set; }
    }

    /// <summary>
    /// خریدها
    /// </summary>
    public class Buy
    {
        /// <summary>
        /// خرید حقیقی
        /// </summary>
        public Items Real { get; set; }

        /// <summary>
        /// خرید حقوقی
        /// </summary>
        public Items Legal { get; set; }
    }

    /// <summary>
    /// فروشها
    /// </summary>
    public class Sell
    {
        /// <summary>
        /// فروش حقیقی
        /// </summary>
        public Items Real { get; set; }

        /// <summary>
        /// فروش حقوقی
        /// </summary>
        public Items Legal { get; set; }
    }

    public class Items
    {
        /// <summary>
        /// تعداد معاملات
        /// </summary>
        public string Count { get; set; }

        /// <summary>
        /// حجم معاملات
        /// </summary>
        public string Volume { get; set; }

        /// <summary>
        /// ارزش معاملات
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// قیمت میانگین
        /// </summary>
        public string AveragePrice { get; set; }
    }
}
