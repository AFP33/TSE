//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// معرفی
    /// </summary>
    public class CompanyInfo
    {
        /// <summary>
        /// موضوع فعالیت
        /// </summary>
        public string ActivityTopic { get; internal set; }

        /// <summary>
        /// مدیر عامل
        /// </summary>
        public string ManagerDirector { get; internal set; }

        /// <summary>
        /// آدرس
        /// </summary>
        public string Address { get; internal set; }

        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string Phone { get; internal set; }

        /// <summary>
        /// نمابر
        /// </summary>
        public string Fax { get; internal set; }

        /// <summary>
        /// نشانی دفتر
        /// </summary>
        public string OfficeAddress { get; internal set; }

        /// <summary>
        /// نشانی امور سهام
        /// </summary>
        public string StockAffairsAddress { get; internal set; }

        /// <summary>
        /// وب سایت
        /// </summary>
        public string Website { get; internal set; }

        /// <summary>
        /// پست الکترونیکی
        /// </summary>
        public string Email { get; internal set; }

        /// <summary>
        /// حسابرس
        /// </summary>
        public string Auditor { get; internal set; }

        /// <summary>
        /// سرمایه
        /// </summary>
        public string Fund { get; internal set; }

        /// <summary>
        /// سال مالی
        /// </summary>
        public string FiscalYear { get; internal set; }

        /// <summary>
        /// مدیر مالی
        /// </summary>
        public string FinancialManager { get; internal set; }

        /// <summary>
        /// شناسه ملی
        /// </summary>
        public string NationalID { get; internal set; }
    }
}
