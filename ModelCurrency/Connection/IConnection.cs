using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Сonnection
{
    public  interface IConnection
    {
        IEnumerable<Currency> Connect();
    }
}
