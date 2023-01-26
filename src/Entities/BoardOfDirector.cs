using System.Collections.Generic;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    /// <summary>
    /// هیئت مدیره
    /// </summary>
    public class BoardOfDirector
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// تاریخ و زمان
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// تاریخ جلسه
        /// </summary>
        public string CouncilDate { get; set; }

        /// <summary>
        /// تاریخ هیئت مدیره
        /// </summary>
        public string BoardDirectorDate { get; set; }

        /// <summary>
        /// اعضاء
        /// </summary>
        public IList<Member> Members { get; set; }

        /// <summary>
        /// مدیر عامل
        /// </summary>
        public DirectorManager DirectorManager { get; set; }
    }

    /// <summary>
    /// اعضای هیئت مدیره
    /// </summary>
    public class Member
    {
        /// <summary>
        /// نام عضو قبلی
        /// </summary>
        public string PreviousMemberName { get; set; }

        /// <summary>
        /// نام عضو فعلی
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// شماره ثبت / کد ملی
        /// </summary>
        public string NationalCode_RegisterNumber { get; set; }

        /// <summary>
        /// سمت قبلی
        /// </summary>
        public string PreviuosAgent { get; set; }

        /// <summary>
        /// سمت
        /// </summary>
        public string Agent { get; set; }

        /// <summary>
        /// کد ملی
        /// </summary>
        public string AgentNationalCode { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Charged { get; set; }

        /// <summary>
        /// مدرک تحصیلی
        /// </summary>
        public string EducationDegree { get; set; }
    }

    /// <summary>
    /// اطلاعات مدیرعامل
    /// </summary>
    public class DirectorManager
    {
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// مدرک تحصیلی
        /// </summary>
        public string EducationDegree { get; set; }
    }
}
