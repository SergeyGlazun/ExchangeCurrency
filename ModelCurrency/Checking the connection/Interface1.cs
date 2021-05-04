using Model.Models;
using System.Collections.Generic;


namespace ModelCurrency.Checking_the_connection
{
    interface ICheckid
    {
        IEnumerable<Currency> Currency { get; }
    }
}
