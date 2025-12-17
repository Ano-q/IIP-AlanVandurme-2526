using System;

namespace ConsoleWeekTemperatuur
{
   class Program
   {
      static void Main(string[] args)
      {
         const int AantalDagen = 7;
         double[] temperaturen = new double[AantalDagen];

         for (int i = 0; i < AantalDagen; i++)
         {
            Console.Write($"Geef de temperatuur op voor dag {i + 1}: ");
            temperaturen[i] = Convert.ToDouble(Console.ReadLine());
         }
		 Console.WriteLine();

         double som = 0;
         double hoogste = temperaturen[0];
         double laagste = temperaturen[0];

         for (int i = 0; i < AantalDagen; i++)
         {
            double temp = temperaturen[i];
            som += temp;

            if (temp > hoogste) hoogste = temp;
            if (temp < laagste) laagste = temp;
         }

         double gemiddelde = Math.Round(som / AantalDagen, 1);

		 Console.Write("Temperaturen deze week: ");
         foreach (double temp in temperaturen)
         {
            Console.Write($"{Math.Round(temp, 1)}°C ");
         }

         Console.WriteLine($@"

Gemiddelde temperatuur: {gemiddelde}°C
Hoogste temperatuur: {Math.Round(hoogste, 1)}°C
Laagste temperatuur: {Math.Round(laagste, 1)}°C");
      }
   }
}