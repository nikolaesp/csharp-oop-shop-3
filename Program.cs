// See https://aka.ms/new-console-template for more information
using csharp_oop_shop_2;

WaterBottle SanPelegrino = new WaterBottle("San Pellegrino", "Aqua dal bergamo", 2, 5, 1.5, 4.5, "Pellegrino Therme");
Snack bare = new Snack("Bare", "Frutta secca", 1, 5,4, "Mella");
Applieance Ariston= new Applieance("Ariston", " cestello spazioso e ampio da 10 kg, Centrifuga a 1400 giri", 700, 22, 7600, "bianco", "D");

SanPelegrino.PrintProduct();
bare.PrintProduct();
Ariston.PrintProduct();
Ariston.energeticTAXFREE();
Ariston.PrintProduct();
SanPelegrino.empty();
SanPelegrino.PrintProduct();
SanPelegrino.refill(1.3);
SanPelegrino.PrintProduct();
SanPelegrino.refill(2);
SanPelegrino.PrintProduct();
SanPelegrino.litterstodrink(2);
SanPelegrino.PrintProduct();
