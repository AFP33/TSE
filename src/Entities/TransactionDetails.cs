using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// نمایش ریزمعاملات در یک روز خاص
    /// </summary>
    public class TransactionDetails
    {
        /// <summary>
        /// شناسه معامله
        /// </summary>
        public int TransactionId { get; internal set; }

        /// <summary>
        /// زمان انجام معامله
        /// </summary>
        public TimeSpan Time { get; internal set; }

        /// <summary>
        /// حجم انجام شده
        /// </summary>
        public ulong Volume { get; internal set; }

        /// <summary>
        /// قیمت مورد معامله
        /// </summary>
        public decimal Price { get; internal set; }

        /// <summary>
        /// نشان میدهد که آیا معامله مورد تایید قرار گرفته است یا نه
        /// </summary>
        public bool Canceled { get; internal set; }
    }
}
