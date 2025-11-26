using System;

namespace ConsoleContactCard
{
	class Program
   {
      static void Main(string[] args)
	  {
		  Console.WriteLine(@"
BMI CALCULATOR
==============");
		  
		  Console.Write("Lengte (in cm): ");
		  int lengte = Convert.ToInt32(Console.ReadLine()); 
		  Console.Write("Gewicht (in kg): ");
		  int gewicht = Convert.ToInt32(Console.ReadLine());		  
		  
		  double bmi = gewicht / Math.Pow(lengte / 100.0, 2);
		  
		  Console.Write($"Je BMI bedraagt: {Math.Round(bmi, 1)}");
		  
	  }
   }
}