using System.Net.Http;
using System.Net;
using System.IO;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks
{
    internal class Request
    {
        private string _ResponseResult { get; set; }
        private string _ResponseStatus { get; set; }

        public Request()
        {
            _ResponseResult = string.Empty;
            _ResponseStatus = string.Empty;
        }

        public string ResponseResult { get { return _ResponseResult; } }
        public string ResponseStatus { get { return _ResponseStatus; } }

        public void SendRequest(string url)
        {
            try
            {
                if (url.IsEmpty() || !IsHttpUrl(url))
                    throw new HttpRequestException("URL not valid");

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse())
                using (Stream stream = webResponse.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    _ResponseStatus = webResponse.StatusDescription;

                    if (webResponse.StatusDescription != "OK")
                        return;
                    _ResponseResult = reader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool IsHttpUrl(string url)
        {
            try
            {
                Uri uriResult;
                return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && uriResult.Scheme == Uri.UriSchemeHttp;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
