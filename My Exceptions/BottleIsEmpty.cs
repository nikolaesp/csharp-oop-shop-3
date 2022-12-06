using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2.BottleIsEmpty
{
    internal class BottleIsEmpty : ArgumentOutOfRangeException
    {
        public BottleIsEmpty() : base()
        {
            Console.WriteLine("Bottle is empty !!!");
        }

    }
}
