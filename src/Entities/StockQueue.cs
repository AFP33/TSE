using System.Collections.Generic;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// تابلو سهام
    /// </summary>
    public class StockQueue
    {
        /// <summary>
        /// بخش خرید تابلو
        /// </summary>
        public IList<RowStockQueue> BuyStockQueue { get; internal set; }

        /// <summary>
        /// بخش فروش تابلو
        /// </summary>
        public IList<RowStockQueue> SellStockQueue { get; internal set; }
    }

    public class RowStockQueue
    {
        /// <summary>
        /// تعداد
        /// </summary>
        public int Count { get; internal set; }

        /// <summary>
        /// حجم
        /// </summary>
        public ulong Volume { get; internal set; }

        /// <summary>
        /// قیمت
        /// </summary>
        public decimal Price { get; internal set; }
    }

    public enum QueueStatus
    {
        /// <summary>
        /// نمایش همه سفارشهای موجود در تابلو
        /// </summary>
        Full,

        /// <summary>
        /// صرفاً نمایش سفارش های منطبق با بازه روز
        /// </summary>
        Clean
    }
}
