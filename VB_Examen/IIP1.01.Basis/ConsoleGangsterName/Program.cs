using System;

namespace ConsoleGangsterName
{
	class Program
   {
      static void Main(string[] args)
	  {
		Console.WriteLine(@"
************************
| GANGSTA NAME BUILDER |
************************");
		
		Console.Write("Give the first name of any Disney character: ");
		string disneyName = Console.ReadLine();
		
		Console.Write("Give any workbench tool: ");
		string tool = Console.ReadLine();
		
		Console.Write("What is you last name: ");
		string name = Console.ReadLine();
		Console.WriteLine();
		
		string result = $"{disneyName} 'The {tool}' {name}";
		Console.Write("Your gangsta name: ");
		Console.ForegroundColor = ConsoleColor.Green;
		Console.Write(result);
		Console.ResetColor()
	  }
   }
}
