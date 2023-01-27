
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
        public string Index { get; set; }

        /// <summary>
        /// انتشار
        /// </summary>
        public string Publish { get; set; }

        /// <summary>
        /// مقدار
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// تغییر
        /// </summary>
        public string Change { get; set; }

        /// <summary>
        /// درصد
        /// </summary>
        public string Percent { get; set; }

        /// <summary>
        /// بیشترین
        /// </summary>
        public decimal Hight { get; set; }

        /// <summary>
        /// کمترین
        /// </summary>
        public decimal Less { get; set; }
    }
}
