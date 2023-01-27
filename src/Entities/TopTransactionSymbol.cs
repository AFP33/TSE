//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
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
