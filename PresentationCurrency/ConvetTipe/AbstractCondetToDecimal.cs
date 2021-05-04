using Model.Models;
using ModelCurrency.Checking_the_connection;
using PresentationCurrency.Models;
using System.Collections.Generic;

namespace PresentationCurrency.ConvetTipe
{
    public abstract class AbstractCondetToDecimal
    {
       // protected CheckingConnection connection = new CheckingConnection();

        protected Conversion conversion = new Conversion();
        public abstract decimal  intitialName(string input, IEnumerable<Currency> Currency);
    }
}
