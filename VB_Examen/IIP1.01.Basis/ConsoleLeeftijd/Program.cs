using System;

namespace ConsoleLeeftijd
{
	class Program
   {
      static void Main(string[] args)
	  {
		Console.Write("Wat is je voornaam? ");
		string naam = Console.ReadLine();
		
		Console.Write("Hoe oud ben je? ");
		int leeftijd = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Geef je lievelingsletter: ");
		string leter = Console.ReadLine();
		
		Console.WriteLine();
		Console.WriteLine($"Hallo {naam}! Jij bent {leeftijd} jaar.");
		Console.WriteLine($"Volgende jaar ben je {leeftijd + 1}");
		Console.WriteLine($"Jouw lievelingsletter is: {leter}");
	  }
   }
}
