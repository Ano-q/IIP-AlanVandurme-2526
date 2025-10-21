using System;
using System.Text;

namespace ConsoleRadenGrenzen
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.WriteLine(@"
 ____  ____  ____  _____ _     
/  __\/  _ \/  _ \/  __// \  /|
|  \/|| / \|| | \||  \  | |\ ||
|    /| |-||| |_/||  /_ | | \||
\_/\_\\_/ \|\____/\____\\_/  \|
");
		Console.WriteLine();
        Console.WriteLine("Geef twee gehele getallen.");
        Console.Write("- getal 1: ");
        int getal1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("- getal 2: ");
        int getal2 = Convert.ToInt32(Console.ReadLine());

        if (getal2 < getal1)
        {
            int tmp = getal1;
            getal1 = getal2;
            getal2 = tmp;
        }

        Random rnd = new Random();
        int doel = rnd.Next(getal1, getal2 + 1);

        Console.WriteLine($"\nEven denken... ja, ik heb een getal tussen {getal1} en {getal2} in mijn hoofd.");

        Console.Write("Doe een gok: ");
        int gok = Convert.ToInt32(Console.ReadLine());

        if (gok == doel)
			{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nJUIST");
            Console.ResetColor();
        }
        else
			{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nFOUT");
            Console.ResetColor();

            int verschil = Math.Abs(gok - doel);
            if (verschil <= 2)
				{
                Console.WriteLine("Je zat er nochtans niet ver af!");
				}
			}
		}
   }
}