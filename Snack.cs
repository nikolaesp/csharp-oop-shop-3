using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Snack : Product
    {
        private int pcs;
        private string flavor;
        public Snack(string name, string description, int price, int vat, int pcs, string flavor) : base(name, description, price, vat)
        {
            this.pcs = pcs;
            this.flavor = flavor;
        }
        public int getPcs() { return this.pcs; }
        public string getFlavor() { return this.flavor;}
        public void setPcs(int pcs) {
            if (pcs <= 5)
                this.pcs = pcs;
            else this.pcs = 5;
        
        }
        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine("Pezzi: " + this.pcs);
            Console.WriteLine("Gusto: " + this.flavor);
            Console.WriteLine();
            
        }
    }
}
