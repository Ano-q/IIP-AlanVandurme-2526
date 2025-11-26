using System;

namespace ConsoleContactCard
{
	class Program
   {
      static void Main(string[] args)
	  {
		string naam = "Bobby Peru";
        bool gehuwd = false;
        string telefoon = "0486/33.22.19";
        int leeftijd = 25;
        decimal salaris = 2500m;  
        char geslacht = 'm';
        double lengte = 1.75;  
		
		Console.Write($@"
---------------
*
* Naam: {naam}
* Gehuwd: {(gehuwd ? "ja" : "nee")}
* Telefoon: {telefoon}
* Leeftijd: {leeftijd} jaar
* Salaris: {salaris.ToString("C")} per maand
* Geslacht: {geslacht}
* Lengte: {lengte.ToString("F2")}m
*
---------------
");
		Console.WriteLine("Druk op een toets om verder te gaan...");
		Console.ReadKey();
	  }
   }
}