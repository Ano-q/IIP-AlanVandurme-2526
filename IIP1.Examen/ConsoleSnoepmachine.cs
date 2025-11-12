using System;
using System.Text;

namespace ConsoleSnoepmachine
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			const double drank = 2.00;
			const double snoep = 1.5;
			
			do
			{
				Console.Clear();
				Console.WriteLine($@"
a. geld inwerpen
b. drank kopen (2,00 euro)
c. snoep kopen (1,50 euro)
d. stoppen

Huidig saldo: {saldo} euro
");
				Console.WriteLine();
				Console.Write("Maak je keuzen: ");
				code = Convert.ToChar(Console.ReadLine());
				
				switch (code)
				{
					case "a":
					Console.Write("Inworp: ");
					double geld = Convert.ToDouble(Console.ReadLine());
					break;
					
					case "b":
						if (geld > 2)
						{
							Console.Write("Je drankje komt eraan");
							double geld = geld - 2;
						}
						else
						{
							Console.Write("Je saldo is te laag; gelieve nog geld in te werpen");
						}	
					
					case "c":
						if (geld > 1.50)
						{
							Console.Write("Je snoept komt eraan");
							double geld = geld - 1.5;
						}
						else
						{
							Console.Write("Je saldo is te laag; gelieve nog geld in te werpen");
						}	
					
					case "d":
						if (geld > 0)
						{
							Console.Write($"Je krijgt {geld} euro terug.");
							double geld = geld - geld;
						}	
					
					default:
					Console.Write();
				} 
			}	
			while (!);
		}
    }
}