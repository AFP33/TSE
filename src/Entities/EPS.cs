//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// اطلاعات EPS
    /// </summary>
    public class EPS
    {
        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        public string Date { get; internal set; }

        /// <summary>
        /// دوره زمانی
        /// </summary>
        public string PeriodTime { get; internal set; }

        /// <summary>
        /// پیش بینی
        /// </summary>
        public int Predict { get; internal set; }

        /// <summary>
        /// رشد
        /// </summary>
        public string Growth { get; internal set; }

        /// <summary>
        /// واقعی
        /// </summary>
        public int Real { get; internal set; }

        /// <summary>
        /// پوشش
        /// </summary>
        public string Cover { get; internal set; }

        /// <summary>
        /// سال قبل
        /// </summary>
        public int LastYear { get; internal set; }

        /// <summary>
        /// دوره قبل
        /// </summary>
        public int LastPeriod { get; internal set; }
    }
}
