//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

using System.ComponentModel;

namespace Tse.Entities
{
    public class Stock
    {
        public int Id { get; internal set; }

        /// <summary>
        /// نام شرکت
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// نماد ثبت شده در بورس
        /// </summary>
        public string Symbol { get; internal set; }

        /// <summary>
        /// کدهای یکتا نماد
        /// </summary>
        public string TseCode { get; internal set; }

        /// <summary>
        /// صنعت
        /// </summary>
        public Industry Industry { get; internal set; }

        /// <summary>
        /// دیگر اطلاعات
        /// </summary>
        public string[] OtherData { get; internal set; }
    }

    public class Industry
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public enum BondType
    {
        /// <summary>
        /// همه سهام مارکت
        /// </summary>
        All,

        /// <summary>
        /// سهام بورس
        /// </summary>
        Saham,

        /// <summary>
        /// فرابورس - بازار پایه
        /// </summary>
        Farabourse_Payeh,

        /// <summary>
        /// فرابورس - بازار اول و دوم
        /// </summary>
        Farabourse_First_Second,

        /// <summary>
        /// سهام اوراق مسکن
        /// </summary>
        TshilatMaskan,

        /// <summary>
        /// سهام حق تقدم
        /// </summary>
        HaghTaghadom,

        /// <summary>
        /// سهام اوراق بدهی
        /// </summary>
        OraghBedehi,

        /// <summary>
        /// سهام اختیار معامله
        /// </summary>
        EkhtiarMoameleh,

        /// <summary>
        /// سهام آتی
        /// </summary>
        Ati,

        /// <summary>
        /// سهام صندوق های سرمایه گذاری
        /// </summary>
        SandoghSarmayegozari,

        /// <summary>
        /// بورس کالا
        /// </summary>
        Kala
    }

    public enum IndustryType
    {
        [Description("زراعت و خدمات وابسته")]
        Zeraat = 01,

        [Description("استخراج زغال سنگ")]
        ZoghalSang = 10,

        [Description("استخراج نفت گاز و خدمات جانبي بجز اكتشاف")]
        NaftGazi = 11,

        [Description("استخراج كانه هاي فلزي")]
        KanehFelezi = 13,

        [Description("منسوجات")]
        Mansojat = 17,

        [Description("محصولات چوبي")]
        Chobi = 20,

        [Description("محصولات كاغذي")]
        Kaghazi = 21,

        [Description("انتشار، چاپ و تكثير")]
        Enteshar = 22,

        [Description("فراورده هاي نفتي، كك و سوخت هسته اي")]
        Nafti = 23,

        [Description("لاستيك و پلاستيك")]
        Lastik = 25,

        [Description("توليد محصولات كامپيوتري الكترونيكي ونوري")]
        TolidComputeri = 26,

        [Description("فلزات اساسي")]
        Felezat = 27,

        [Description("ساخت محصولات فلزي")]
        SakhtFelezi = 28,

        [Description("ماشين آلات و تجهيزات")]
        Mashinalat = 29,

        [Description("ماشين آلات و دستگاه‌هاي برقي")]
        MashinalatBarghi = 31,

        [Description("ساخت دستگاه‌ها و وسايل ارتباطي")]
        DastgahErtebatat = 32,

        [Description("خودرو و ساخت قطعات")]
        Khodroei = 34,

        [Description("ساير تجهيزات حمل و نقل")]
        SayerTajhizatHaml = 35,

        [Description("قند و شكر")]
        Ghandi = 38,

        [Description("شركتهاي چند رشته اي صنعتي")]
        ChandReshteiSanati = 39,

        [Description("عرضه برق، گاز، بخاروآب گرم")]
        ArzeBargGaz = 40,

        [Description("محصولات غذايي و آشاميدني به جز قند و شكر")]
        Ghazaei = 42,

        [Description("مواد و محصولات دارويي")]
        Darouei = 43,

        [Description("محصولات شيميايي")]
        Shimiaei = 44,

        [Description("پيمانكاري صنعتي")]
        PeymankariSanaati = 45,

        [Description("تجارت عمده فروشي به جز وسايل نقليه موتور")]
        TejaratOmdeh = 46,


        [Description("خرده فروشي،باستثناي وسايل نقليه موتوري")]
        Khordephroshi = 47,

        [Description("كاشي و سراميك")]
        Kashi = 49,

        [Description("تجارت عمده وخرده فروشي وسائط نقليه موتور")]
        TejaratOmdehMotori = 50,

        [Description("سيمان، آهك و گچ")]
        Simani = 53,

        [Description("ساير محصولات كاني غيرفلزي")]
        Kani = 54,

        [Description("هتل و رستوران")]
        Hotel = 55,

        [Description("سرمايه گذاريها")]
        Sarmayehgozari = 56,

        [Description("بانكها و موسسات اعتباري")]
        Banki = 57,

        [Description("ساير واسطه گريهاي مالي")]
        VasetehgaryMali = 58,

        [Description("اوراق حق تقدم استفاده از تسهيلات مسكن")]
        HaghtaghadomMaskan = 59,

        [Description("حمل ونقل، انبارداري و ارتباطات")]
        Anbardari = 60,

        [Description("حمل و نقل آبي")]
        HamloNaghlAbi = 61,

        [Description("مخابرات")]
        Mokhaberat = 64,

        [Description("واسطه‌گري‌هاي مالي و پولي")]
        VasetegaryMaliPoli = 65,

        [Description("بيمه وصندوق بازنشستگي به جزتامين اجتماعي")]
        BimehSandogh = 66,

        [Description("فعاليتهاي كمكي به نهادهاي مالي واسط")]
        KomakiBeNahad = 67,

        [Description("صندوق سرمايه گذاري قابل معامله")]
        SandoghSarmayegozari = 68,

        [Description("اوراق تامين مالي")]
        OraghTaminMali = 69,

        [Description("انبوه سازی، املاک و مستغلات")]
        Amlak = 70,

        [Description("فعاليت مهندسي، تجزيه، تحليل و آزمايش فني")]
        Mohandesi = 71,

        [Description("رایانه و فعالیت های وابسته به آن")]
        Rayaneh = 72,

        [Description("اطلاعات و ارتباطات")]
        Ertebatat = 73,

        [Description("خدمات فنی و مهندسی")]
        FaniMohandesi = 74,

        [Description("فعاليت هاي هنري، سرگرمي و خلاقانه")]
        Honari = 90,

        [Description("فعاليتهاي فرهنگي و ورزشي")]
        FarhangiVarzeshi = 93,
    }
}
