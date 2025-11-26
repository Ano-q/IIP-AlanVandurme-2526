using System;

namespace ConsoleContactCard
{
	class Program
   {
      static void Main(string[] args)
	  {
		  const double SEIZOEN = 18.5;
		  const double DESSERT = 7.95;
		  const double KIDS = 8.95;
		  
		  Console.ForegroundColor = ConsoleColor.Yellow;
		  Console.WriteLine(@"
WELKOM IN HET BUGGETRESTAURANT
==============================

Alles is à volonté en dranken zijn inbegrepen!
!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!");
		  Console.ResetColor();
		  Console.WriteLine();
		  Console.WriteLine();
		  
		  Console.Write("Aantal seizoensbuffets (€18.5): ");
		  int aantalSeizoen = Convert.ToInt32(Console.ReadLine());
		  
		  Console.Write("Aantal dessertenbuffets (€7.95): ");
		  int aantalDessert = Convert.ToInt32(Console.ReadLine());
		  
		  Console.Write("Aantal kids menus (€8.95): ");
		  int aantalKids = Convert.ToInt32(Console.ReadLine());
		  
		  Console.WriteLine();
		  Console.Write("Fooi (0 indien geen): ");
		  double fooi = Convert.ToDouble(Console.ReadLine());
		  
		  double totaal = aantalSeizoen * SEIZOEN 
						+ aantalDessert * DESSERT 
						+ aantalKids * KIDS;
		  
		  Console.Write($"Totaal te betalen: €{totaal}");

	  }
   }
}