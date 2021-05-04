using PresentationCurrency.ConvetTipe;
using System;

namespace PresentationCurrency
{
    public class ConvertToDecimalBuy: AbstractCondetToDecimal
    {
       
        public  override decimal intitialName(string input)
        {
            foreach (var item in connectParseHTML.Connect())
            {
                if (item.Name == input)
                {
                    return Convert.ToDecimal(item.Sell) / Convert.ToDecimal(item.Categori);
                   
                }
            }
            return 0;
        }
    }
}
