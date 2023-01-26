using System.Collections.Generic;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// مجامع
    /// </summary>
    public class CouncilAnnouncement
    {
        /// <summary>
        /// عنوان مجمع
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// زمان مجمع
        /// </summary>
        public string Time { get; internal set; }

        /// <summary>
        /// محل برگزاری
        /// </summary>
        public MeetingLocation MeetingLocation { get; internal set; }

        /// <summary>
        /// دستورات جلسه
        /// </summary>
        public List<string> AgendaItems { get; internal set; }
    }

    /// <summary>
    /// محل برگزاری مجمع
    /// </summary>
    public class MeetingLocation
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
        /// آدرس
        /// </summary>
        public string Address { get; internal set; }
    }
}
