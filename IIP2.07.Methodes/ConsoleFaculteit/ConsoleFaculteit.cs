using System;

namespace ConsoleFaculteit;

class Program
{
    static void Main(string[] args)
    {
		Console.WriteLine("FACULTEIT BEREKENEN");
		Console.WriteLine();
		Console.WriteLine("Geef een geheel getal: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		int fac = Faculteit(n);
		
		Console.WriteLine($"De faculteit is {fac}");
	}
	
	private static int Faculteit(int n) 
	{
		int resultaat = 1;

            for (int i = 1; i <= n; i++)
            {
                resultaat *= i;
            }

            return resultaat;
	}
}