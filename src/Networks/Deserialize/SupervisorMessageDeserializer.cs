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
    internal class SupervisorMessageDeserializer : IDeserializer<List<SupervisorMessage>>
    {
        public List<SupervisorMessage> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(serverResponse);

                List<SupervisorMessage> messages = new List<SupervisorMessage>();

                // get all Header Nodes
                HtmlNode[] headerNodes = html.DocumentNode.SelectNodes("//table//tr/th").ToArray();
                // get all Message
                HtmlNode[] messageNodes = html.DocumentNode.SelectNodes("//table//tr/td").ToArray();

                int counter = 0;
                for (int i = 0; i < headerNodes.Length; i += 2)
                {
                    SupervisorMessage SupervisorMessages = new SupervisorMessage();
                    SupervisorMessages.Title = headerNodes[i].InnerText.Replace("\t", "");
                    SupervisorMessages.Time = headerNodes[i + 1].InnerText;
                    SupervisorMessages.Message = messageNodes[counter].InnerText;
                    counter++;

                    messages.Add(SupervisorMessages);
                }

                return messages;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
