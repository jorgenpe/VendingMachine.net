using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Service
{
    interface IVending
    {
        Product Purchase();
        List<string> ShowAll();
        string Details();
        void InsertMoney();
        Dictionary<int,int> EndTransactin();
    }
}
