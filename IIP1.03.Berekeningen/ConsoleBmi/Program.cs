using System;
using System.Text;

namespace ConsoleBmi
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.Write("Lengte (in cm): ");
        int lengteCm = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Gewicht (in kg): ");
		int gewicht  = Convert.ToInt32(Console.ReadLine());
		
		double lengteM = lengteCm / 100.0;
        double bmi = gewicht / Math.Pow(lengteM, 2);
        double bmiAfgerond = Math.Round(bmi, 1);
		
		Console.WriteLine($"Je BMI bedraagt: {bmiAfgerond}");
      }
   }
}