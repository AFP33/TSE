using HtmlAgilityPack;
using Tse.Entities;
using System.Linq;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class FaraBourseDeserializer : IDeserializer<FaraBourse>
    {
        public FaraBourse Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(serverResponse);

                var allTable = htmlDocument.DocumentNode.SelectNodes("//table[@class='table1']").ToArray();

                return GetBasicInfo(allTable[26].InnerHtml);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private FaraBourse GetBasicInfo(string innerHtml)
        {
            try
            {
                if (innerHtml.IsEmpty())
                    return new FaraBourse();

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(innerHtml);
                var fields = htmlDocument.DocumentNode.SelectNodes("//tbody//tr//td");

                return new FaraBourse()
                {
                    MarketStatus = Useful.GetMarketStatus(fields[1].InnerText.Substring(0, fields[1].InnerText.Length - 6)),
                    OverallIndex = fields[3].InnerText.Split(' ')[0].ToDecimal(),
                    Market1_2Value = fields[5].Element("div").GetAttributeValue("title", fields[5].InnerText).ToUlong(),
                    BaseMarketValue = fields[7].Element("div").GetAttributeValue("title", fields[7].InnerText).ToUlong(),
                    PriceInformation = fields[9].InnerText,
                    TransactionCount = fields[11].InnerText.ToInt(),
                    TransactionValue = fields[13].Element("div").GetAttributeValue("title", fields[13].InnerText).ToUlong(),
                    TransactionVolume = fields[15].Element("div").GetAttributeValue("title", fields[15].InnerText).ToUlong()
                };
            }
            catch (Exception)
            {
                return new FaraBourse();
            }
        }
    }
}
