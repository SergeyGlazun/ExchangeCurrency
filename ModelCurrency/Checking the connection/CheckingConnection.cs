using Model.Models;
using ModelCurrency.Connection;
using System.Collections.Generic;


namespace ModelCurrency.Checking_the_connection
{
    public class CheckingConnection : ICheckid
    {
        List<Currency> currency;

        ConnectParseHTML connectParseHTML = new ConnectParseHTML();

        ConnectionJSON_NationalBank jSON_NationalBank = new ConnectionJSON_NationalBank();
        public void Checking()
        {
           
            currency = (List<Currency>)connectParseHTML.Connect();
            if (currency == null || currency.Count==0)
            {
                currency = (List<Currency>)jSON_NationalBank.Connect();
            }
        }

        public IEnumerable<Currency> Currency => currency;
    }
}
