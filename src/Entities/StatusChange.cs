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
        public string Date { get; set; }

        /// <summary>
        /// زمان
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// وضعیت جدید
        /// </summary>
        public string Status { get; set; }
    }
}
