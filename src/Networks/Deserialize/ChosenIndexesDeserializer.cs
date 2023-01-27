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
    internal class ChosenIndexesDeserializer : IDeserializer<IList<ChosenIndexes>>
    {
        public IList<ChosenIndexes> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(serverResponse);

                var allTable = htmlDocument.DocumentNode.SelectNodes("//table[@class='table1']").ToArray();

                return GetChosenIndexes(allTable[3].InnerHtml);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<ChosenIndexes> GetChosenIndexes(string innerHtml)
        {
            try
            {
                if (innerHtml.IsEmpty())
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
    }
}
