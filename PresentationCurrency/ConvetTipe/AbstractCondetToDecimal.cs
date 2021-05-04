using Model.Models;
using PresentationCurrency.Models;

namespace PresentationCurrency.ConvetTipe
{
    public abstract class AbstractCondetToDecimal
    {
        protected ConnectParseHTML connectParseHTML = new ConnectParseHTML();

        protected Conversion conversion = new Conversion();
        public abstract decimal  intitialName(string input);
    }
}
