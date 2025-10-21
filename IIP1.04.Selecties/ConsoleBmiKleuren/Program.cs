using System;
using System.Text;

namespace ConsoleBmiKleuren
{
   class Program
   {
      static void Main(string[] args)
      {
			
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");
			
            Console.Write("Lengte (in cm): ");
            int lengteCm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gewicht (in kg): ");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            double lengteM = lengteCm / 100.0;
            double bmi = gewicht / Math.Pow(lengteM, 2);
            double bmiAfgerond = Math.Round(bmi, 1);

            Console.WriteLine($"Je BMI bedraagt: {bmiAfgerond:F1}");

			Console.WriteLine();
            string boodschap;
            ConsoleColor kleur;

            if (bmiAfgerond < 18.5)
            {
                boodschap = "Je hebt ondergewicht";
                kleur = ConsoleColor.Yellow;
            }
            else if (bmiAfgerond < 25.0)
            {
                boodschap = "Je gewicht is normaal";
                kleur = ConsoleColor.Green;
            }
            else if (bmiAfgerond < 30.0)
            {
                boodschap = "Je hebt overgewicht";
                kleur = ConsoleColor.Yellow;
            }
            else
            {
                boodschap = "Je hebt obesitas";
                kleur = ConsoleColor.Red;
            }

            Console.ForegroundColor = kleur;
            Console.WriteLine(boodschap);
            Console.ResetColor();
        }
    }
}