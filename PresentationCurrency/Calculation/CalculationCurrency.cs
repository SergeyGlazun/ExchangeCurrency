using PresentationCurrency.ConvetTipe;
using PresentationCurrency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationCurrency.Calculation
{
   public class CalculationCurrency
    {
              
        public decimal ConvertCurrency(decimal Sum, decimal OfName, decimal InName)
        {
            try
            {
                return Math.Round(Sum * OfName / InName, 4);
            }
            catch
            {

                return 0;
            }

        }
    }
}
