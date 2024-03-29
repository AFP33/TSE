﻿using System.Collections.Generic;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// اعلامیه
    /// </summary>
    public class Announcement
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// تاریخ
        /// </summary>
        public string Date { get; internal set; }

        /// <summary>
        /// لینک دانلود
        /// </summary>
        public string DownloadLink { get; internal set; }

        /// <summary>
        /// الصاق ها
        /// </summary>
        public List<Attachment> Attachments { get; internal set; }
    }

    /// <summary>
    /// الصاق
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// لینک دانلود
        /// </summary>
        public string DownloadLink { get; set; }

        /// <summary>
        /// نوع
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
    }
}
