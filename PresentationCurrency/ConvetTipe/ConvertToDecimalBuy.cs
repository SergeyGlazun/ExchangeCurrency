using Model.Models;
using PresentationCurrency.ConvetTipe;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PresentationCurrency
{
    public class ConvertToDecimalBuy: AbstractCondetToDecimal
    {
       
        public  override decimal intitialName(string input, IEnumerable<Currency> Currency)
        {
            foreach (var item in Currency)
            {
                if (item.Cur_Name == input)
                {
                    try
                    {
                        return Convert.ToDecimal(item.Cur_OfficialRate) / Convert.ToDecimal(item.Cur_Scale);
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
