//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// سهامداران
    /// </summary>
    public class Stockholder
    {
        /// <summary>
        /// سهامدار / دارنده
        /// </summary>
        public string Holder { get; internal set; }

        /// <summary>
        /// سهم
        /// </summary>
        public string Share { get; internal set; }

        /// <summary>
        /// درصد
        /// </summary>
        public string Percent { get; internal set; }

        /// <summary>
        /// تغییر
        /// </summary>
        public string Status { get; internal set; }
    }
}
