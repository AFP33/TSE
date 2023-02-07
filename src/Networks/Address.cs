//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks
{
    internal static class Address
    {
        // Market Adresses
        internal readonly static string AllStocks = @"http://www.tsetmc.com/tsev2/data/MarketWatchInit.aspx?h=0&r=0";
        internal readonly static string Industry = @"http://www.tsetmc.com/tsev2/res/loader.aspx?t=g&_535";
        internal readonly static string SearchStocks = @"http://www.tsetmc.com/tsev2/data/search.aspx?skey={0}";
        internal readonly static string Bourse = @"http://www.tsetmc.com/Loader.aspx?ParTree=15";

        // Stocks Addresses
        internal readonly static string BriefInformation = @"http://www.tsetmc.com/tsev2/data/instinfodata.aspx?i={0}&c=27%21";
        internal readonly static string Announcement = @"http://www.tsetmc.com/tsev2/data/CodalTopNew.aspx?i={0}";
        internal readonly static string CompanyIdentity = @"http://www.tsetmc.com/Loader.aspx?Partree=15131M&i={0}";
        internal readonly static string BalaneSheet = @"http://www.tsetmc.com/tsev2/data/CodalContent.aspx?s={0}&r=6&st=6&pi=0";
        internal readonly static string CouncilAnnouncement = @"http://www.tsetmc.com/tsev2/data/CodalContent.aspx?s={0}&r=13";
        internal readonly static string StatusChange = @"http://www.tsetmc.com/Loader.aspx?Partree=15131L&i={0}";
        internal readonly static string BoardOfDirector = @"http://www.tsetmc.com/tsev2/data/CodalContent.aspx?s={0}&r=12";
        internal readonly static string RealLegal = @"http://www.tsetmc.com/tsev2/data/clienttype.aspx?i={0}";
        internal readonly static string Stockholder = @"http://www.tsetmc.com/Loader.aspx?Partree=15131T&c={0}";
        internal readonly static string EPS = @"http://www.tsetmc.com/Loader.aspx?Partree=15131U&c={0}";
        internal readonly static string DPS = @"http://www.tsetmc.com/tsev2/data/DPSData.aspx?s={0}";
        internal readonly static string CompanyInfo = @"http://www.tsetmc.com/Loader.aspx?Partree=15131V&s={0}";
        internal readonly static string CostBenefit = @"http://www.tsetmc.com/tsev2/data/CodalContent.aspx?s={0}&r=6&st=6&pi=1";
        internal readonly static string ProduceSale = @"http://www.tsetmc.com/tsev2/data/CodalContent.aspx?s={0}&r=6&st=6&pi=2";
        internal readonly static string TransactionHistory = @"http://www.tsetmc.com/tsev2/data/InstTradeHistory.aspx?i={0}&Top=999999&A=0";
        internal readonly static string TransactionHistoryAllDays = @"http://www.tsetmc.com/tsev2/data/InstTradeHistory.aspx?i={0}&Top=999999&A=1";
        internal readonly static string SupervisorMessage = @"http://www.tsetmc.com/Loader.aspx?Partree=15131W&i={0}";
        internal readonly static string Statistics = @"http://www.tsetmc.com/tsev2/data/instValue.aspx?i={0}&t=i";
        internal readonly static string CouncilDecision = @"http://tsetmc.com/tsev2/data/CodalContent.aspx?s={0}&r=14";
        internal readonly static string TransactionDetails = @"http://cdn.tsetmc.com/api/Trade/GetTradeHistory/{0}/{1}/true";
        internal readonly static string Portfo = @"http://www.tsetmc.com/tsev2/data/CodalContent.aspx?s={0}&r=6&st=8&pi=-1";

    }
}
