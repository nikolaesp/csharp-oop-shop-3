using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class WaterBottle : Product
    {
        private double capacity;
        public WaterBottle(string name, string description, int price, int vat, double capacity) : base(name, description, price, vat)
        {
            this.capacity = capacity;
        }

        public double getCapacity() { return this.capacity; }
    }
}
