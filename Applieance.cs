using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Applieance : Product
    {
        public Applieance(string name, string description, int price, int vat) : base(name, description, price, vat)
        {
        }
    }
}
