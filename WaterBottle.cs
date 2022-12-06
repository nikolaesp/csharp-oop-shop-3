using csharp_oop_shop_2.BottleIsEmpty;
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
        static double coeficent = 3.785;
        public WaterBottle(string name, string description, int price, int vat, double capacity, double ph, string watersource) : base(name, description, price, vat)
        {
            if (capacity < 0 || capacity > 1.5)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.capacity = capacity;
            }
            if (ph > 10 || ph < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else{ this.Ph = ph; }
            this.watersource = watersource; 
        }

        public double getCapacity() { return this.capacity; }
        public double getPh() { return this.Ph; }
        public void setPh(double ph)
        {
            if (ph > 10 || ph < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else { this.Ph = ph; }
        }
        public string getWatersource() { return this.watersource; }

        public void setCapacity(double capacity)
        {
            if (capacity < 0 || capacity > 1.5)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.capacity = capacity;
            }
        }
        public void litterstodrink(double drinks){
            if(this.capacity == 0)
            {
                throw new BottleIsEmpty();
            }
            if (drinks <= this.capacity)
            {
                this.capacity = this.capacity - drinks;
            }
            else { empty(); }
        }
        public void refill(double water)
        {
            if(water < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(water), $"Water  must be more then 0l.");
            }
            if (water <= 1.5)
            {
                this.capacity=this.capacity+water;
            }
            else {throw new ArgumentOutOfRangeException(nameof(water), $"Water  must be less then 1.5l."); }
        }
        public static double convertiInGalloni(double litri)
        {
            
            return litri * coeficent;
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
