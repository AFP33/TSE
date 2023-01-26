//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// پیام های ناظر برای یک نماد خاص
    /// </summary>
    public class SupervisorMessage
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// زمان انتشار
        /// </summary>
        public string Time { get; internal set; }

        /// <summary>
        /// متن پیام
        /// </summary>
        public string Message { get; internal set; }
    }
}
