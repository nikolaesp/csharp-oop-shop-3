using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Product
    {
        private int code;
        private string name;
        private string description;
        private int price;
        private int vat;


        public Product(string name, string description, int price, int vat)
        {
            Random rnd = new Random();
            int myRandomNo = rnd.Next(00000000, 99999999); // crea random numero di 8 cifre
            this.code = myRandomNo;
            this.name = name;
            this.description = description;
            this.price = price;
            this.vat = vat;
        }
        public int getCode() { return this.code; }
        public void setName(string name)
        {

            this.name = name;
        }
        public string getName() { return this.name; }
        public void setDescription(string des)
        {
            this.description = des;
        }
        public string getDescription() { return this.description; }
        public void setPrezzo(int price)
        {
            this.price = price;
        }
        public int getPrezzo() { return this.price; }
        public void setIva(int vat)
        {
            this.vat = vat;
        }
        public int getIva() { return this.vat; }

        public double prezzoTotale()
        {
            return this.price + (this.price * (this.vat / 100.0));
        }
        public void nomeCompleto()
        {
            Console.WriteLine("Nome completo: " + this.name + this.code);
        }
        public void codiceFormat(int code)
        {

            Console.WriteLine("{0,22:D8}", code);
        }
        public void StampaProdotto()
        {
            Console.WriteLine("Nome: " + this.name);
            Console.WriteLine("Codice: " + this.code);
            Console.WriteLine("Descrizione: " + this.description);
            Console.WriteLine("Prezzo: " + this.price + "eur");
            Console.WriteLine("IVA: " + this.vat + "%");
        }
    }
}
