using HtmlAgilityPack;
using Tse.Entities;
using System.Linq;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class CompanyInfoDeserializer : IDeserializer<CompanyInfo>
    {
        public CompanyInfo Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                CompanyInfo companyInfo = new CompanyInfo();

                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(serverResponse);
                HtmlNode[] stockHolderItems = html.DocumentNode.SelectNodes("//table//tbody//tr//td").ToArray();

                if (stockHolderItems.Length < 27)
                    return companyInfo;

                companyInfo.ActivityTopic = stockHolderItems[1].InnerText.Replace("\n", "").Replace("\r", "");
                companyInfo.ManagerDirector = stockHolderItems[3].InnerText;
                companyInfo.Address = stockHolderItems[5].InnerText;
                companyInfo.Phone = stockHolderItems[7].InnerText;
                companyInfo.Fax = stockHolderItems[9].InnerText;
                companyInfo.OfficeAddress = stockHolderItems[11].InnerText;
                companyInfo.StockAffairsAddress = stockHolderItems[13].InnerText;
                companyInfo.Website = stockHolderItems[15].InnerText;
                companyInfo.Email = stockHolderItems[17].InnerText;
                companyInfo.Auditor = stockHolderItems[19].InnerText;
                companyInfo.Fund = stockHolderItems[21].InnerText;
                companyInfo.FiscalYear = stockHolderItems[23].InnerText;
                companyInfo.FinancialManager = stockHolderItems[25].InnerText;
                companyInfo.NationalID = stockHolderItems[27].InnerText;

                return companyInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
