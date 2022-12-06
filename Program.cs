// See https://aka.ms/new-console-template for more information
using csharp_oop_shop_2;
using csharp_oop_shop_2.BottleIsEmpty;

WaterBottle SanPelegrino = new WaterBottle("San Pellegrino", "Aqua dal bergamo", 2, 5, 1.5, 4.5, "Pellegrino Therme");
Snack bare = new Snack("Bare", "Frutta secca", 1, 5,4, "Mella");
Applieance Ariston= new Applieance("Ariston", " cestello spazioso e ampio da 10 kg, Centrifuga a 1400 giri", 700, 22, 7600, "bianco", "D");
CannedFood barilla = new CannedFood("Pomodori Confit", "Pomodorii alla confit di barilla", 5, 22, 250, 400);
SanPelegrino.PrintProduct();
bare.PrintProduct();
Ariston.PrintProduct();
Ariston.energeticTAXFREE();
Ariston.PrintProduct();
SanPelegrino.empty();
SanPelegrino.PrintProduct();

    SanPelegrino.refill(0.3);
    SanPelegrino.PrintProduct();
    SanPelegrino.refill(1.5);
    SanPelegrino.PrintProduct();
    SanPelegrino.litterstodrink(1);
/*
try
{
    int waterl = int.Parse(Console.ReadLine());
    SanPelegrino.refill(waterl);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
catch (BottleIsEmpty e)
{
    Console.WriteLine(e.Message);
}
*/

SanPelegrino.PrintProduct();
barilla.PrintProduct();
int waterlit = int.Parse(Console.ReadLine());
double gallons = SanPelegrino.convertiInGalloni(waterlit);
   
