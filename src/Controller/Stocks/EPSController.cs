using System.Text.RegularExpressions;
using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Stocks
{
    internal class EPSController : IStockController<List<EPS>>
    {
        private string company12DigitCode { get; set; }

        public EPSController(string company12DigitCode)
        {
            this.company12DigitCode = company12DigitCode;
        }

        public List<EPS> Get(Stock stock)
        {
            try
            {
                if (Common.Useful.IsNullString(this.company12DigitCode))
                    throw new System.ArgumentNullException(this.company12DigitCode);

                string url = string.Format(Networks.Address.EPS, Regex.Replace(this.company12DigitCode, @"\s+", ""));
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                {
                    return new List<EPS>();
                }
                return new EPSDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
