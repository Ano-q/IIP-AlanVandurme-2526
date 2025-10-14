using System;
using System.Text;

namespace ConsoleBuffet
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.OutputEncoding = Encoding.UTF8;

        const double PRIJS_SEIZOEN = 18.5;
        const double PRIJS_DESSERT = 7.95;
        const double PRIJS_KIDS    = 8.95;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($@"
WELKOM IN HET BUFFETRESTAURANT
==============================

Alles is à volonté en dranken zijn inbegrepen!
!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!
");
        Console.ResetColor();


        Console.Write($"Aantal seizoensbuffets (€{PRIJS_SEIZOEN}): ");
        int aantalSeizoen = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Aantal dessertbuffets (€{PRIJS_DESSERT}): ");
        int aantalDessert = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Aantal kids menus (€{PRIJS_KIDS}): ");
        int aantalKids = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Fooi (0 indien geen): ");
        double fooi = Convert.ToDouble(Console.ReadLine());


        double totaal = aantalSeizoen * PRIJS_SEIZOEN
                      + aantalDessert * PRIJS_DESSERT
                      + aantalKids * PRIJS_KIDS
                      + fooi;

        Console.WriteLine($"Totaal te betalen: {totaal:C2}");

        int teBetalenEuro = (int)Math.Floor(totaal);
        Console.WriteLine($"Afgerond naar beneden: {teBetalenEuro:C0}");
        Console.WriteLine();


        Console.Write("Cash betaald: ");
        int cash = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("U krijgt terug:");

        int wissel = cash - teBetalenEuro;


        int b50 = wissel / 50;  wissel %= 50;
        int b20 = wissel / 20;  wissel %= 20;
        int b10 = wissel / 10;  wissel %= 10;
        int b5  = wissel / 5;   wissel %= 5;
        int s2  = wissel / 2;   wissel %= 2;
        int s1  = wissel;

        Console.WriteLine($"- {b50} briefje(s) van 50");
        Console.WriteLine($"- {b20} briefje(s) van 20");
        Console.WriteLine($"- {b10} briefje(s) van 10");
        Console.WriteLine($"- {b5} briefje(s) van 5");
        Console.WriteLine($"- {s2} stuk(ken) van 2");
        Console.WriteLine($"- {s1} stuk(ken) van 1");
      }
   }
}