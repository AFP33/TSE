using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Tse.Entities;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class AnnouncementDeserializer : IDeserializer<List<Announcement>>
    {
        public List<Announcement> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                var announcements = new List<Announcement>();

                var json = JArray.Parse(serverResponse).Children();

                foreach (var item in json)
                {
                    Announcement announcement = new Announcement();
                    announcement.DownloadLink = string.Format("http://cdn8.tsetmc.com/tsev2/data/CodalData.aspx?t=p&i={0}", item[0].Value<string>());
                    announcement.Title = item[3].Value<string>();
                    announcement.Date = item[4].Value<string>();

                    // Get Attachment
                    var attachments = new List<Attachment>();
                    foreach (var attach in item[10].Children())
                    {
                        var attachement = new Attachment();
                        attachement.DownloadLink = string.Format("http://cdn8.tsetmc.com/tsev2/data/CodalData.aspx?t=a&i={0}&i2={1}", item[0].Value<string>(), attach[0].Value<string>());
                        attachement.Type = attach[1].Value<string>();
                        attachement.Name = attach[2].Value<string>();

                        attachments.Add(attachement);
                    }
                    announcement.Attachments = attachments;

                    announcements.Add(announcement);
                }

                return announcements;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
