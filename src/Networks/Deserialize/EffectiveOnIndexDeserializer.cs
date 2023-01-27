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
    internal class EffectiveOnIndexDeserializer : IDeserializer<IList<EffectiveOnIndex>>
    {
        private string _market { get; set; }
        public EffectiveOnIndexDeserializer(string market = "Bourse")
        {
            _market = market;
        }
        public IList<EffectiveOnIndex> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(serverResponse);

                var allTable = htmlDocument.DocumentNode.SelectNodes("//table[@class='table1']").ToArray();

                if (_market == "Bourse")
                    return GetEffectiveOnIndex(allTable[4].InnerHtml);
                else if (_market == "Farabourse")
                    return GetEffectiveOnIndex(allTable[31].InnerHtml);

                return new List<EffectiveOnIndex>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IList<EffectiveOnIndex> GetEffectiveOnIndex(string innerHtml)
        {
            try
            {
                if (innerHtml.IsEmpty())
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
                        FinalPrice = fields[1].InnerText.ToInt(),
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
    }
}
