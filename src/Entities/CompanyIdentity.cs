//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// شناسه سهام
    /// </summary>
    public class CompanyIdentity
    {
        /// <summary>
        /// کد 12 رقمی نماد
        /// </summary>
        public string Symbol12DigitCode { get; set; }

        /// <summary>
        /// کد 5 رقمی نماد
        /// </summary>
        public string Symbol5DigitCode { get; set; }

        /// <summary>
        /// نام لاتین شرکت
        /// </summary>
        public string EnglishCompanyName { get; set; }

        /// <summary>
        /// کد 4 رقمی شرکت
        /// </summary>
        public string Company4DigitCode { get; set; }

        /// <summary>
        /// نام شرکت 
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// نماد فارسی
        /// </summary>
        public string PersianSymbol { get; set; }

        /// <summary>
        /// نماد 30 رقمی فارسی
        /// </summary>
        public string Persian30DigitSymbol { get; set; }

        /// <summary>
        /// کد 12 رقمی شرکت
        /// </summary>
        public string Company12DigitCode { get; set; }

        /// <summary>
        /// بازار
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// کد تابلو
        /// </summary>
        public string BoardCode { get; set; }

        /// <summary>
        /// کد گروه صنعت
        /// </summary>
        public string IndustryGroupCode { get; set; }

        /// <summary>
        /// گروه صنعت
        /// </summary>
        public string IndustryGroup { get; set; }

        /// <summary>
        /// کد زیر گروه صنعت
        /// </summary>
        public string IndustrySubGroupCode { get; set; }

        /// <summary>
        /// زیر گروه صنعت
        /// </summary>
        public string IndustrySubGroup { get; set; }
    }
}
