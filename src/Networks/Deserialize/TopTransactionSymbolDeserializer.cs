using System.Collections.Generic;
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
    internal class TopTransactionSymbolDeserializer : IDeserializer<IList<TopTransactionSymbol>>
    {
        private string _market { get; set; }

        public TopTransactionSymbolDeserializer(string market = "Bourse")
        {
            _market = market;
        }

        public IList<TopTransactionSymbol> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(serverResponse);

                var allTable = htmlDocument.DocumentNode.SelectNodes("//table[@class='table1']").ToArray();

                if (_market == "Bourse")
                    return GetTopTransactionSymbols(allTable[2].InnerHtml);
                else if (_market == "Farabourse")
                    return GetTopTransactionSymbols(allTable[29].InnerHtml);

                return new List<TopTransactionSymbol>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IList<TopTransactionSymbol> GetTopTransactionSymbols(string innerHtml)
        {
            try
            {
                if (innerHtml.IsEmpty())
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
    }
}
