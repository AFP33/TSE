using System.Text.RegularExpressions;
using System.Collections.Generic;
using Tse.Networks.Deserialize;
using Tse.Entities;
using Tse.Common;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller.Stocks
{
    internal class StockholderController : IStockController<IList<Stockholder>>
    {
        private string company12DigitCode { get; set; }

        public StockholderController(string company12DigitCode)
        {
            this.company12DigitCode = company12DigitCode;
        }

        public IList<Stockholder> Get(Stock stock)
        {
            try
            {
                if (this.company12DigitCode.IsEmpty())
                    throw new ArgumentNullException(this.company12DigitCode);

                string url = string.Format(Networks.Address.Stockholder, Regex.Replace(this.company12DigitCode, @"\s+", ""));
                //send Request and get Response
                var request = new Networks.Request();
                request.SendRequest(url);
                if (request.ResponseStatus != "OK")
                {
                    return new List<Stockholder>();
                }
                return new StockholderDeserializer().Get(request.ResponseResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
