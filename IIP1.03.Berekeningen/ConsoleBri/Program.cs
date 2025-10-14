using System;
using System.Text;

namespace ConsoleBri
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.OutputEncoding = Encoding.UTF8;


        const double BASIS = 364.2;
        const double FACTOR = 365.5;
        const double ONDERGRENS = 3.41;
        const double BOVENGRENS = 4.44;


        Console.WriteLine(@"
BRI CALCULATOR 🏋️
==================
");

    
		Console.Write("Taille (in cm): ");
        int taille = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lengte (in cm): ");
        int lengte = Convert.ToInt32(Console.ReadLine());

        double verhouding = Math.Pow(taille, 2) / (Math.PI * Math.Pow(lengte, 2));
        double bri = BASIS - FACTOR * Math.Sqrt(1 - verhouding);

        bri = Math.Round(bri, 1);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Je BRI bedraagt: {bri:F1}");
        Console.ResetColor();

        Console.Write("\nEen BRI tussen ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{ONDERGRENS:F2} en {BOVENGRENS:F2}");
        Console.ResetColor();

        Console.WriteLine(" is normaal.");
      }
   }
}