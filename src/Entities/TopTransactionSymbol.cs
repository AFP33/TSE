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
        public int FinalPrice { get; set; }

        /// <summary>
        /// آخرین معامله
        /// </summary>
        public int LastTransaction { get; set; }

        /// <summary>
        /// بیشترین
        /// </summary>
        public int Hight { get; set; }

        /// <summary>
        /// کمترین
        /// </summary>
        public int Less { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// حجم
        /// </summary>
        public ulong Volume { get; set; }

        /// <summary>
        /// ارزش
        /// </summary>
        public ulong Value { get; set; }
    }
}
