using System.Collections.Generic;
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
    internal class BourseDeserializer : IDeserializer<Bourse>
    {
        public Bourse Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new ArgumentNullException(nameof(serverResponse));

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(serverResponse);

                var allTable = htmlDocument.DocumentNode.SelectNodes("//table[@class='table1']").ToArray();
                
                var bourse = GetBasicInfo(allTable[0].InnerHtml);
                bourse.ChosenIndexes = GetChosenIndexes(allTable[3].InnerHtml);
                bourse.EffectiveOnIndex = GetEffectiveOnIndex(allTable[4].InnerHtml);
                bourse.TopTransactionSymbol = GetTopTransactionSymbols(allTable[2].InnerHtml);

                return bourse;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<TopTransactionSymbol> GetTopTransactionSymbols(string innerHtml)
        {
            try
            {
                if (Common.Useful.IsNullString(innerHtml))
                    return new List<TopTransactionSymbol>();

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(innerHtml);
                var records = htmlDocument.DocumentNode.SelectNodes("//tbody//tr");
                var topTransactionSymbol = new List<TopTransactionSymbol>();
                foreach (var record in records)
                {
                    var fields = record.Elements("td").ToList();
                    topTransactionSymbol.Add(new TopTransactionSymbol()
                    {
                        Symbol = fields[0].InnerText,
                        FinalPrice = fields[1].InnerText,
                        LastTransaction = fields[3].InnerText,
                        Hight = fields[6].InnerText,
                        Less = fields[5].InnerText,
                        Count = fields[7].InnerText,
                        Volume = fields[8].Element("div").GetAttributeValue("title", fields[8].InnerText),
                        Value = fields[9].Element("div").GetAttributeValue("title", fields[9].InnerText),
                    });
                }

                return topTransactionSymbol;
            }
            catch (Exception)
            {
                return new List<TopTransactionSymbol>();
            }
        }

        private List<EffectiveOnIndex> GetEffectiveOnIndex(string innerHtml)
        {
            try
            {
                if (Common.Useful.IsNullString(innerHtml))
                    return new List<EffectiveOnIndex>();

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(innerHtml);
                var records = htmlDocument.DocumentNode.SelectNodes("//tbody//tr");
                var effectiveOnIndexes = new List<EffectiveOnIndex>();
                foreach (var record in records)
                {
                    var fields = record.Elements("td").ToList();
                    effectiveOnIndexes.Add(new EffectiveOnIndex()
                    {
                        Symbol = fields[0].InnerText,
                        FinalPrice = fields[1].InnerText,
                        Efficacy = fields[2].InnerText
                    });
                }

                return effectiveOnIndexes;
            }
            catch (Exception)
            {
                return new List<EffectiveOnIndex>();
            }
        }

        private List<ChosenIndexes> GetChosenIndexes(string innerHtml)
        {
            try
            {
                if (Common.Useful.IsNullString(innerHtml))
                    return new List<ChosenIndexes>();

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(innerHtml);
                var records = htmlDocument.DocumentNode.SelectNodes("//tbody//tr");
                var topIndexes = new List<ChosenIndexes>();
                foreach (var record in records)
                {
                    var fields = record.Elements("td").ToList();
                    var ti = new ChosenIndexes
                    {
                        Index = fields[0].InnerText,
                        Publish = fields[1].InnerText,
                        Value = fields[2].InnerText,
                        Change = fields[3].InnerText,
                        Percent = fields[4].InnerText,
                        Hight = fields[5].InnerText,
                        Less = fields[6].InnerText
                    };
                    topIndexes.Add(ti);
                }

                return topIndexes;
            }
            catch (Exception)
            {
                return new List<ChosenIndexes>();
            }
        }

        private Bourse GetBasicInfo(string innerHtml)
        {
            try
            {
                if (Common.Useful.IsNullString(innerHtml))
                    return new Bourse();

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(innerHtml);
                var fields = htmlDocument.DocumentNode.SelectNodes("//tbody//tr//td");

                return new Bourse()
                {
                    MarketStatus = fields[1].InnerText.Substring(0, fields[1].InnerText.Length - 6),
                    OverallIndex = fields[3].InnerText.Split(' ')[0],
                    WeightIndex = fields[5].InnerText.Split(' ')[0],
                    MarketValue = fields[7].Element("div").GetAttributeValue("title", fields[7].InnerText),
                    PriceInformation = fields[9].InnerText,
                    TransactionCount = fields[11].InnerText,
                    TransactionValue = fields[13].Element("div").GetAttributeValue("title", fields[13].InnerText),
                    TransactionVolume = fields[15].Element("div").GetAttributeValue("title", fields[15].InnerText)
                };
            }
            catch (Exception)
            {
                return new Bourse();
            }
        }
    }
}
