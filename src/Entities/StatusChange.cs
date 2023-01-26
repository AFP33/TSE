//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// تغییر وضعیت نماد
    /// </summary>
    public  class StatusChange
    {
        /// <summary>
        /// تاریخ
        /// </summary>
        public string Date { get; internal set; }

        /// <summary>
        /// زمان
        /// </summary>
        public string Time { get; internal set; }

        /// <summary>
        /// وضعیت جدید
        /// </summary>
        public string Status { get; internal set; }
    }
}
