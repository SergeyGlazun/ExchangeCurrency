using Model.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace PresentationCurrency.ConvetTipe
{
    public class  CondetToDecimalSell : AbstractCondetToDecimal
    {
        public  override decimal intitialName(string input, IEnumerable<Currency> Currency)
        {
           
            foreach (var item in Currency)
            {
                if (item.Cur_Name == input)
                {
                   
                    try
                    {
                        return Convert.ToDecimal(item.Cur_OfficialRate);
                    }
                    catch
                    {
                                            
                        return Convert.ToDecimal(Regex.Replace(item.Cur_OfficialRate, "\\.", ","));
                    }
                                                                            
                }
            }
            return 0;
        }
    }
}
