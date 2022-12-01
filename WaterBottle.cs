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
        private double Ph;
        private string watersource;
        public WaterBottle(string name, string description, int price, int vat, double capacity, double ph, string watersource) : base(name, description, price, vat)
        {
            this.capacity = capacity;
            Ph = ph;
            this.watersource = watersource; 
        }

        public double getCapacity() { return this.capacity; }
        public double getPh() { return this.Ph; }
        public string getWatersource() { return this.watersource; }

        public void setCapacity(double capacity)
        {
            if (capacity <= 1.5) { this.capacity = capacity; }
            else { this.capacity = 1.5; }
        }
        public void litterstodrink(double drinks){
            if (drinks < this.capacity)
            {
                this.capacity = this.capacity - drinks;
            }
        }
        public void refill(int water)
        {
            if (water < 1.5)
            {
                this.capacity=this.capacity+water;
            }
            else { this.capacity = 1.5; }
        }
        public void empty() { this.capacity = 0; }
        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine("Capalita: " + this.capacity + "l.");
            Console.WriteLine("PH: " + this.Ph);
            Console.WriteLine("Sourgente: " + this.watersource);
            Console.WriteLine();
        }

    }
   
}
