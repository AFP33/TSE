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
        public string ActivityTopic { get; set; }

        /// <summary>
        /// مدیر عامل
        /// </summary>
        public string ManagerDirector { get; set; }

        /// <summary>
        /// آدرس
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// نمابر
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// نشانی دفتر
        /// </summary>
        public string OfficeAddress { get; set; }

        /// <summary>
        /// نشانی امور سهام
        /// </summary>
        public string StockAffairsAddress { get; set; }

        /// <summary>
        /// وب سایت
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// پست الکترونیکی
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// حسابرس
        /// </summary>
        public string Auditor { get; set; }

        /// <summary>
        /// سرمایه
        /// </summary>
        public string Fund { get; set; }

        /// <summary>
        /// سال مالی
        /// </summary>
        public string FiscalYear { get; set; }

        /// <summary>
        /// مدیر مالی
        /// </summary>
        public string FinancialManager { get; set; }

        /// <summary>
        /// شناسه ملی
        /// </summary>
        public string NationalID { get; set; }
    }
}
