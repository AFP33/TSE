using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class IndustryDeserializer : IDeserializer<IDictionary<string, string>>
    {
        public IDictionary<string, string> Get(string serverResponse)
        {
            try
            {
                if (serverResponse.IsEmpty())
                    throw new ArgumentNullException(nameof(serverResponse));

                serverResponse = serverResponse.Remove(0, 12);
                serverResponse = serverResponse.Remove(serverResponse.Length - 1, 1);

                var s = JArray.Parse(serverResponse);

                var industries = new Dictionary<string, string>();
                foreach (var item in s.Children())
                {
                    industries.Add(item[0].Value<string>(), item[1].Value<string>());
                }

                return industries;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
