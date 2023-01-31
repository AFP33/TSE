using System.Collections.Generic;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// تصمیمات مجمع
    /// </summary>
    public class CouncilDecision
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
        /// انتهای سال مالی
        /// </summary>
        public DateTime? YearEndToDate { get; internal set; }

        /// <summary>
        /// مکان و زمان
        /// </summary>
        public PlaceAndDateTime PlaceAndDateTime { get; internal set; }

        /// <summary>
        /// سهامداران
        /// </summary>
        public IList<Stockholder> Stockholder { get; internal set; }

        /// <summary>
        /// هیئت رئیسه
        /// </summary>
        public IList<string> Presidium { get; internal set; }

        /// <summary>
        /// مدیر عامل
        /// </summary>
        public DirectorManager DirectorManager {get;internal set;}

        /// <summary>
        /// صورت سود و زیان
        /// </summary>
        public IList<IncomeStatement> IncomeStatements { get; internal set; }

        /// <summary>
        /// سود قابل تخصیص
        /// </summary>
        public IList<DividedRetainedEarning> DividedRetainedEarning { get; internal set; }

        /// <summary>
        /// بازرس
        /// </summary>
        public Inspector Inspector { get; internal set; }

        /// <summary>
        /// روزنامه
        /// </summary>
        public IList<string> Newspaper { get; internal set; }

        /// <summary>
        /// دستمزد اعضای هیئت مدیره
        /// </summary>
        public string BoardMemberWage { get; internal set; }

        /// <summary>
        /// پاداش اعضای عیئت مدیره
        /// </summary>
        public string BoardMemberGift { get; internal set; }

        /// <summary>
        /// سایر موارد
        /// </summary>
        public string Other { get; internal set; }
    }

    /// <summary>
    /// بازرس
    /// </summary>
    public class Inspector
    {
        /// <summary>
        /// متن نهایی
        /// </summary>
        public string Text { get; internal set; }

        /// <summary>
        /// بازرس اصلی
        /// </summary>
        public string Auditor { get; internal set; }

        /// <summary>
        /// بازرس علل البدل
        /// </summary>
        public string AlternativeAuditor { get; internal set; }

    }

    /// <summary>
    /// سود قابل تخصیص
    /// </summary>
    public class DividedRetainedEarning
    {
        /// <summary>
        /// شرح
        /// </summary>
        public string Statement { get; internal set; }

        /// <summary>
        /// مقدار
        /// </summary>
        public string Value { get; internal set; }
    }

    /// <summary>
    /// صورت سود و زیان
    /// </summary>
    public class IncomeStatement
    {
        /// <summary>
        /// شرح
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// مقادیر
        /// </summary>
        public List<string> Values { get; internal set; }
    }

    /// <summary>
    /// مکان و زمان
    /// </summary>
    public class PlaceAndDateTime
    {
        /// <summary>
        /// تاریخ
        /// </summary>
        public DateTime? Date { get; internal set; }

        /// <summary>
        /// زمان
        /// </summary>
        public TimeSpan? Time { get; internal set; }

        /// <summary>
        /// مکان
        /// </summary>
        public string Place { get; internal set; }
    }
}
