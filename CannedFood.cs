using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class CannedFood : Product
    {
        private int grams;
        private int calories;
        public CannedFood(string name, string description, int price, int vat, int grams, int calories) : base(name, description, price, vat)
        {
            this.grams = grams;
            this.calories = calories;
        }
        public int getGrams() { return this.grams; }
        public int getCalories() { return this.calories; }
        public void setGrams(int grams)
        {
            if (grams <= 300) { this.grams = grams; }
            else
            {
                this.grams = 300;
            }

        }


        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine("Potenza: " + this.grams + "gr.");
            Console.WriteLine("Calorie: " + this.calories);
            Console.WriteLine();

        }


    }
}
