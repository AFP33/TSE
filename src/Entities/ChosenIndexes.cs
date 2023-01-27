
namespace Tse.Entities
{
    /// <summary>
    /// شاخصهای منتخب
    /// </summary>
    public class ChosenIndexes
    {
        /// <summary>
        /// شاخص
        /// </summary>
        public string Index { get; internal set; }

        /// <summary>
        /// انتشار
        /// </summary>
        public string Publish { get; internal set; }

        /// <summary>
        /// مقدار
        /// </summary>
        public decimal Value { get; internal set; }

        /// <summary>
        /// تغییر
        /// </summary>
        public string Change { get; internal set; }

        /// <summary>
        /// درصد
        /// </summary>
        public string Percent { get; internal set; }

        /// <summary>
        /// بیشترین
        /// </summary>
        public decimal Hight { get; internal set; }

        /// <summary>
        /// کمترین
        /// </summary>
        public decimal Less { get; internal set; }
    }
}
