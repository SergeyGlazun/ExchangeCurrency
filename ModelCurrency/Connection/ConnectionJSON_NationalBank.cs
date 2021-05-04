using Model.Models;
using Model.Сonnection;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ModelCurrency.Connection
{
    public class ConnectionJSON_NationalBank : IConnection
    {

        public IEnumerable<Currency> Connect()
        {
            List<Currency> currency = new List<Currency>();
           
            currency.Add(GetJsone("https://www.nbrb.by/api/exrates/rates/145"));
            currency.Add(GetJsone("https://www.nbrb.by/api/exrates/rates/292"));
            currency.Add(GetJsone("https://www.nbrb.by/api/exrates/rates/298"));
            currency.Add(GetJsone("https://www.nbrb.by/api/exrates/rates/290"));

            return currency;
        }

        private Currency GetJsone(string _url)
        {          

            string url = _url;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            Currency temperatureInfo = JsonConvert.DeserializeObject<Currency>(response);

            return temperatureInfo;
        }
    }
}
