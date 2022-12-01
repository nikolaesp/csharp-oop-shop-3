using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Applieance : Product
    {
        private int power;
        private string color;
        private string energeticclass;
        public Applieance(string name, string description, int price, int vat, int power, string color, string energeticclass) : base(name, description, price, vat)
        {
            this.power = power;
            this.color = color;
            this.energeticclass = energeticclass;
        }
        public int getPowerClass() { return this.power; }
        public string getColor() { return this.color;}
        public string getenergeticclass() { return this.energeticclass; }

        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine("Potenza: " + this.power+"W.");
            Console.WriteLine("Colore: " + this.color);
            Console.WriteLine("Class: "+this.energeticclass);
            Console.WriteLine();

       }
    public void energeticTAXFREE()
        {
            if((this.energeticclass == "C")|| this.energeticclass == "D"|| this.energeticclass == "E"|| this.energeticclass== "F") {
                base.setIva(0);
            }
        }
    
    
    
    
    
    
    }



}

