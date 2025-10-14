using System;
using System.Text;

namespace ConsoleShortsBasis
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Oefining A.1: een tekstregel afdrukken");
Console.WriteLine("------------");
			Console.WriteLine();
			
			Console.WriteLine("Welkom in de werld van C# !");
			Console.WriteLine();
			
			Console.WriteLine("Oefining A.2: meerdere tekstregel afdrukken");
Console.WriteLine("------------");
			Console.WriteLine();
			
			Console.WriteLine("Fouten zijn rood");
			Console.WriteLine("Variabelen zijn blauw");
			Console.WriteLine("Ik werk aan de code");
			Console.WriteLine("Waar ik zo van hou.");
			
			Console.WriteLine("Oefining A.3: multiline string");
Console.WriteLine("------------");
			Console.WriteLine();
			
			Console.WriteLine($@"
     ---
    (o o)
   (  v  )
-----m-m-----
");

			Console.WriteLine("Oefining B.1: tekst inlezen en afdrukken");
Console.WriteLine("------------");
			Console.WriteLine();
			
			Console.WriteLine("Voer je naam in:");
			string naam = Console.ReadLine();
			
			Console.WriteLine($"Hallo, {naam}!");
			
			Console.WriteLine("Oefining B.2: tekst inlezen en meermaals afdrukken");
Console.WriteLine("------------");
			Console.WriteLine();
			
			Console.WriteLine("Welkom in de echoput");
			Console.Write("Zeg iets: ");
			string iets = Console.ReadLine();
			Console.WriteLine($"{iets} {iets} {iets}");
			
			Console.WriteLine("Oefining C.1: variablen declareren");
Console.WriteLine("------------");
			Console.WriteLine();
			
			string naam = Jan;
			int lengte = 185 CM;
			char geslacht = M;
			
			Console.WriteLine(@$"
			Naam: {naam} 
			Lengte: {lengte} 
			Geslacht: {geslacht}
			");
			
			
		}	
	}
}
