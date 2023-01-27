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
    internal class StatusChangeDeserializer : IDeserializer<List<StatusChange>>
    {
        public List<StatusChange> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new System.ArgumentNullException(nameof(serverResponse));

                var statusChanges = new List<StatusChange>();

                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(serverResponse);
                HtmlNode[] statusChangeNode = html.DocumentNode.SelectNodes("//table//tbody//tr//td").ToArray();

                for (int i = 0; i < statusChangeNode.Length; i += 3)
                {
                    var statusChange = new StatusChange()
                    {
                        Date = statusChangeNode[i].InnerText,
                        Time = statusChangeNode[i + 1].InnerText,
                        Status = statusChangeNode[i + 2].InnerText
                    };
                    statusChanges.Add(statusChange);
                }

                return statusChanges;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
