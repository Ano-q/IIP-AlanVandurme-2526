using System;

namespace ConsoleAbonnement
{
	class Program
   {
      static void Main(string[] args)
	  {		
		Console.WriteLine(@"
Bestelgegens
============");
		Console.Write("- naam klant: ");
		string naam = Console.ReadLine();

        Console.Write("- aantal toegangsbeurten: ");
        int beurten = Convert.ToInt32(Console.ReadLine());

        Console.Write("- prijs (b.v. 122,5): ");
        decimal prijs = Convert.ToDecimal(Console.ReadLine());

        Console.Write("- badkledij inbegrepen (typ true of false): ");
        bool badkledij = Convert.ToBoolean(Console.ReadLine());

        Console.Write("- geslacht (druk 'm' of 'v'): ");
        char geslacht = Convert.ToChar(Console.ReadKey().KeyChar);
        Console.WriteLine();
		
		Random random = new Random();
		string kaartnummer = $"{random.Next(100, 1000)}-{random.Next(1000, 10000)}-{random.Next(10, 100)}";
		  
		Console.ForegroundColor = ConsoleColor.Yellow;
		  
		Console.WriteLine($@"
Samenvatting
============
- houder: {naam}
- geslacht: {geslacht}
- prijs: €{prijs:F2}
- aantal beurten: {beurten}
- incl. badkledij: {badkledij}
- kaartnummer: {kaartnummer}
");
		  
		  Console.ResetColor();
		  Console.WriteLine("Druk op een toets om verder te gaan...");
		  Console.ReadKey();
	  }
   }
}