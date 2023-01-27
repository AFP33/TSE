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
    internal class StockholderDeserializer : IDeserializer<IList<Stockholder>>
    {
        public IList<Stockholder> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var stockholders = new List<Stockholder>();

                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(serverResponse);
                HtmlNode[] stockHolderItems = html.DocumentNode.SelectNodes("//table//tbody//tr//td").ToArray();

                for (int i = 0; i < stockHolderItems.Length; i += 5)
                {
                    Stockholder stockholder = new Stockholder();
                    stockholder.Holder = stockHolderItems[i].InnerText;
                    stockholder.Share = stockHolderItems[i + 1].SelectNodes(".//div[@title]").FirstOrDefault().Attributes["title"].Value;
                    stockholder.Percent = stockHolderItems[i + 2].InnerText;
                    stockholder.Status = stockHolderItems[i + 3].InnerText == "0" ? stockHolderItems[i + 3].InnerText : stockHolderItems[i + 3].SelectNodes(".//div[@title]").FirstOrDefault().Attributes["title"].Value;

                    stockholders.Add(stockholder);
                }

                return stockholders;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
