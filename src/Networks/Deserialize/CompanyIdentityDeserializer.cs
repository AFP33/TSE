using System.Collections.Generic;
using HtmlAgilityPack;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class CompanyIdentityDeserializer : IDeserializer<CompanyIdentity>
    {
        public CompanyIdentity Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(serverResponse);

                List<string> list = new List<string>();
                foreach (HtmlNode node in htmlDoc.DocumentNode.SelectNodes("//td"))
                {
                    list.Add(node.InnerText);
                }
                var companyIdentity = new Entities.CompanyIdentity()
                {
                    Symbol12DigitCode = list[1],
                    Symbol5DigitCode = list[3],
                    EnglishCompanyName = list[5],
                    Company4DigitCode = list[7],
                    CompanyName = list[9],
                    PersianSymbol = list[11],
                    Persian30DigitSymbol = list[13],
                    Company12DigitCode = list[15],
                    Market = list[17],
                    BoardCode = list[19],
                    IndustryGroupCode = list[21],
                    IndustryGroup = list[23],
                    IndustrySubGroupCode = list[25],
                    IndustrySubGroup = list[27],
                };
                return companyIdentity;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
