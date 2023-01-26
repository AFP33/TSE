using System.Text.RegularExpressions;
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
    internal class EPSDeserializer : IDeserializer<List<EPS>>
    {
        public List<EPS> Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                List<EPS> ePs = new List<EPS>();

                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(serverResponse);
                HtmlNode[] epsItems = html.DocumentNode.SelectNodes("//table//tbody//tr//td").ToArray();

                for (int i = 0; i < epsItems.Length; i += 8)
                {
                    EPS eps = new EPS();
                    eps.Date = Regex.Replace(epsItems[i].InnerText, @"\s+", "");
                    eps.PeriodTime = epsItems[i + 1].InnerText;
                    eps.Predict = epsItems[i + 2].InnerText;
                    eps.Growth = epsItems[i + 3].InnerText;
                    eps.Real = epsItems[i + 4].InnerText;
                    eps.Cover = epsItems[i + 5].InnerText;
                    eps.LastYear = epsItems[i + 6].InnerText;
                    eps.LastPeriod = epsItems[i + 7].InnerText;

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
