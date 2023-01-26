//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    public class Stock
    {
        /// <summary>
        /// نشان دهنده گروه صنعتی است که نماد جزو آن است
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// نام شرکت
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نماد ثبت شده در بورس
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// کدهای یکتا نماد
        /// </summary>
        public string TseCode { get; set; }

        /// <summary>
        /// دیگر اطلاعات
        /// </summary>
        public string[] OtherData { get; set; }
    }
}
