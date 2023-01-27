//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// تاثیر در شاخص
    /// </summary>
    public class EffectiveOnIndex
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
        /// تاثیر
        /// </summary>
        public string Efficacy { get; set; }
    }
}
