using System;

namespace ConsoleHalloWereld
{
	class Program
   {
      static void Main(string[] args)
	  {
		Console.WriteLine("Hallo Wereld!");
		Console.Write("Hoe heet je; ");
		string naam = Console.ReadLine();
		
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine($"Aangenaame kennismaking, {naam}");
		Console.ResetColor();
		Console.Write("druk een toets om verder te gaan...");
		Console.ReadKey();
	  }
   }
}
