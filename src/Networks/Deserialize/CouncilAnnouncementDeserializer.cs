using System.Collections.Generic;
using Newtonsoft.Json.Linq;
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
    public class CouncilAnnouncementDeserializer : IDeserializer<List<CouncilAnnouncement>>
    {
        public List<CouncilAnnouncement> Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                var assemblyAnnouncements = new List<CouncilAnnouncement>();

                var json = JArray.Parse(serverResponse).Children();

                foreach (var item in json)
                {
                    CouncilAnnouncement assemblyAnnouncement = new CouncilAnnouncement();
                    assemblyAnnouncement.Title = item[0].Value<string>();
                    assemblyAnnouncement.Time = item[1].Value<string>();
                    assemblyAnnouncement.MeetingLocation = new Entities.MeetingLocation()
                    {
                        Date = item[4]["Root"]["PlaceAndDateTime"]["Date"].Value<string>(),
                        Time = item[4]["Root"]["PlaceAndDateTime"]["Time"].Value<string>(),
                        Address = item[4]["Root"]["PlaceAndDateTime"]["Place"].Value<string>()
                    };

                    // Get agenda Items 
                    var agendaItems = new List<string>();
                    var agenda = item[4]["Root"]["Agenda"]["AgendaItem"];
                    if (agenda.Count() > 1)
                        foreach (var agendaItem in agenda)
                        {
                            agendaItems.Add(agendaItem.Value<string>());
                        }
                    else
                        agendaItems.Add(agenda.Value<string>());
                    assemblyAnnouncement.AgendaItems = agendaItems;

                    assemblyAnnouncements.Add(assemblyAnnouncement);
                }

                return assemblyAnnouncements;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
