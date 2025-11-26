namespace Program;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        // constanten en variabelen //
        const double prijsSpaghetti = 12.00;
        const double prijsLasagne = 15.00;
        const double prijsPizza = 13.00;
        const double prijsWijn = 7.00;
        const double prijsFrisdrank = 3;
        const double happyHourKortingPercentage = 0.1;
        const double btwTarief = 0.21;
        double prijsExclBtw = 0;
        double prijsBtw = 0;
        double prijsTotaal = 0;
        char bestelCode;
        
        // DO-WHILE loop //
        do
        {
            Console.Clear();
            Console.WriteLine($@"
=== Resto Odisee ====
a. Spaghetti € {prijsSpaghetti}
b. Lasagne € {prijsLasagne}
c. Pizza € {prijsPizza}
d. Wijn € {prijsWijn}
e. Frisdrank € {prijsFrisdrank}
f. Stop");
            Console.WriteLine();
            Console.Write("plaats je bestelling (a-e of f om te stoppen) ");
            bestelCode = Convert.ToChar(Console.ReadLine());
            
            // SWITCH CASE //
            switch (bestelCode)
            {
                case 'a':
                    prijsExclBtw += prijsSpaghetti;
                    Console.WriteLine($"Spaghetti besteld (€ {prijsSpaghetti:F2})");
                    Console.ReadLine();
                    break;
                case 'b':
                    prijsExclBtw += prijsLasagne;
                    Console.WriteLine($"Lasagne besteld (€ {prijsLasagne:F2})");
                    Console.ReadLine();
                    break;
                case 'c':
                    prijsExclBtw += prijsPizza;
                    Console.WriteLine($"Pizza besteld (€ {prijsPizza:F2})");
                    Console.ReadLine();
                    break;
                case 'd':
                    prijsExclBtw += prijsWijn;
                    Console.WriteLine($"Wijn besteld (€ {prijsWijn:F2})");
                    Console.ReadLine();
                    break;
                case 'e':
                    prijsExclBtw += prijsFrisdrank;
                    Console.WriteLine($"Frisdrank besteld (€ {prijsFrisdrank:F2})");
                    Console.ReadLine();
                    break;
                case 'f':
                    Console.WriteLine($"Stop");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
        } while (bestelCode != 'f');
        
        // Berekening van de korting //
        DateTime nu = DateTime.Now;
        int uur = nu.Hour;
        int minuten = nu.Minute;
        
        if ((uur == 17 && minuten >= 30) || uur == 18 || (uur == 19 && minuten == 0))
        {
            double korting = prijsExclBtw * happyHourKortingPercentage;
            prijsExclBtw = prijsExclBtw - korting;
            Console.WriteLine($"Happy hour! Korting van {happyHourKortingPercentage:P0}");
        }
        
        prijsBtw = prijsExclBtw * btwTarief;
        prijsTotaal = prijsExclBtw + prijsBtw;
        
        Console.WriteLine($@"
= Afrekening =
Prijs zonder BTW: € {prijsExclBtw:F2}
BTW: € {prijsBtw:F2}
Totaal: € {prijsTotaal:F2}");
        Console.WriteLine("Bedankt voor je bezoek!");
        Console.ReadLine();
        Console.ReadKey();
    }
}
