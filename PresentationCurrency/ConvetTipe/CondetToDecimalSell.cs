using System;

namespace PresentationCurrency.ConvetTipe
{
    public class  CondetToDecimalSell : AbstractCondetToDecimal
    {
        public  override decimal intitialName(string input)
        {
            foreach (var item in connectParseHTML.Connect())
            {
                if (item.Name == input)
                {
                   return  Convert.ToDecimal(item.Sell);
                    
                }
            }
            return 0;
        }
    }
}
