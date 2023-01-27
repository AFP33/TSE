using System.Text.RegularExpressions;
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
    internal class EPSDeserializer : IDeserializer<IList<EPS>>
    {
        public IList<EPS> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                List<EPS> ePs = new List<EPS>();

                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(serverResponse);
                HtmlNode[] epsItems = html.DocumentNode.SelectNodes("//table//tbody//tr//td").ToArray();

                for (int i = 0; i < epsItems.Length; i += 8)
                {
                    EPS eps = new EPS();
                    eps.Date = Regex.Replace(epsItems[i].InnerText, @"\s+", "");
                    eps.PeriodTime = epsItems[i + 1].InnerText;
                    eps.Predict = epsItems[i + 2].InnerText.ToInt();
                    eps.Growth = epsItems[i + 3].InnerText;
                    eps.Real = epsItems[i + 4].InnerText.ToInt();
                    eps.Cover = epsItems[i + 5].InnerText;
                    eps.LastYear = epsItems[i + 6].InnerText.ToInt();
                    eps.LastPeriod = epsItems[i + 7].InnerText.ToInt();

                    ePs.Add(eps);
                }

                return ePs;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
