using Model.Сonnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model.Models
{
    public class ConnectParseHTML : IConnection
    {
        public IEnumerable<Currency> Connect()
        {
            List<Currency> students = new List<Currency>();
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("https://www.bps-sberbank.by/");

            MatchCollection rateMatchesSell = Regex.Matches(Response, @"<div class=""BlockCurrencyExchangeRates__rate-item_sell-rate"">([0-9]+,[0-9]+)</div>");
            MatchCollection rateMatchesBuy = Regex.Matches(Response, @"<div class=""BlockCurrencyExchangeRates__rate-item_buy-rate"">([0-9]+,[0-9]+)</div>");
            MatchCollection rateMatchesCategory = Regex.Matches(Response, @"<span>([0-9]+)");
            MatchCollection rateMatchesName = Regex.Matches(Response, @"([A-Z]+)</span>");
            for (int i = 0; i < rateMatchesSell.Count; i++)
            {
                Match sell = rateMatchesSell[i];
                Match buy = rateMatchesBuy[i];
                Match categori = rateMatchesCategory[i];
                Match name = rateMatchesName[i];
                students.Add(new Currency
                {
                    Sell = sell.Groups[1].Value,
                    Buy = buy.Groups[1].Value,
                    Categori = categori.Groups[1].Value,
                    Name = name.Groups[1].Value
                });
            }

            return students;
        }
    }
}
