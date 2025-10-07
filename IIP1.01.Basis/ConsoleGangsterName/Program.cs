using System;

namespace ConsoleGangsterName
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("****************************");
        Console.WriteLine("| GANGSTA NAME BUILDER |");
        Console.WriteLine("****************************");
        Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();
		
		Console.Write("Give the first name of any Disney character: ");
		string character = Console.ReadLine();
		
		Console.Write("Give any workbench tool: ");
		string tool = Console.ReadLine();
		
		Console.Write("What is your last name: ");
		string name = Console.ReadLine();
		
		string result = $"{character} 'the {tool}' {name}";
		Console.WriteLine();
		Console.Write("Your gangsta name: ");
		Console.ForegroundColor = ConsoleColor.Green;
		Console.Write(result);
      }
   }
}