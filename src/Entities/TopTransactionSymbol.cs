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
        public string Symbol { get; internal set; }

        /// <summary>
        /// قیمت پایانی
        /// </summary>
        public int FinalPrice { get; internal set; }

        /// <summary>
        /// آخرین معامله
        /// </summary>
        public int LastTransaction { get; internal set; }

        /// <summary>
        /// بیشترین
        /// </summary>
        public int Hight { get; internal set; }

        /// <summary>
        /// کمترین
        /// </summary>
        public int Less { get; internal set; }

        /// <summary>
        /// تعداد
        /// </summary>
        public int Count { get; internal set; }

        /// <summary>
        /// حجم
        /// </summary>
        public ulong Volume { get; internal set; }

        /// <summary>
        /// ارزش
        /// </summary>
        public ulong Value { get; internal set; }
    }
}
