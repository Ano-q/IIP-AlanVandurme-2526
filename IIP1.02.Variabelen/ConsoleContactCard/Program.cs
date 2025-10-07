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
        decimal salaris = 2500.00m;  
        char geslacht = 'm';
        double lengte = 1.75;  
		string gehuwdText = gehuwd ? "ja" : "nee";
		
		string output = $@"
		
---------------
*
* Naam: {naam}
* Gehuwd: {gehuwdText}
* Telefoon: {telefoon}
* Leeftijd: {leeftijd} jaar
* Salaris: {salaris:C2} per maand
* Geslacht: {geslacht}
* Lengte: {lengte:F2}m
*
---------------
";
		Console.WriteLine(output);
        Console.WriteLine("druk op een toets om verder te gaan...");
        Console.ReadKey();
      }
   }
}