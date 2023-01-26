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
        public string Symbol12DigitCode { get; internal set; }

        /// <summary>
        /// کد 5 رقمی نماد
        /// </summary>
        public string Symbol5DigitCode { get; internal set; }

        /// <summary>
        /// نام لاتین شرکت
        /// </summary>
        public string EnglishCompanyName { get; internal set; }

        /// <summary>
        /// کد 4 رقمی شرکت
        /// </summary>
        public string Company4DigitCode { get; internal set; }

        /// <summary>
        /// نام شرکت 
        /// </summary>
        public string CompanyName { get; internal set; }

        /// <summary>
        /// نماد فارسی
        /// </summary>
        public string PersianSymbol { get; internal set; }

        /// <summary>
        /// نماد 30 رقمی فارسی
        /// </summary>
        public string Persian30DigitSymbol { get; internal set; }

        /// <summary>
        /// کد 12 رقمی شرکت
        /// </summary>
        public string Company12DigitCode { get; internal set; }

        /// <summary>
        /// بازار
        /// </summary>
        public string Market { get; internal set; }

        /// <summary>
        /// کد تابلو
        /// </summary>
        public string BoardCode { get; internal set; }

        /// <summary>
        /// کد گروه صنعت
        /// </summary>
        public string IndustryGroupCode { get; internal set; }

        /// <summary>
        /// گروه صنعت
        /// </summary>
        public string IndustryGroup { get; internal set; }

        /// <summary>
        /// کد زیر گروه صنعت
        /// </summary>
        public string IndustrySubGroupCode { get; internal set; }

        /// <summary>
        /// زیر گروه صنعت
        /// </summary>
        public string IndustrySubGroup { get; internal set; }
    }
}
