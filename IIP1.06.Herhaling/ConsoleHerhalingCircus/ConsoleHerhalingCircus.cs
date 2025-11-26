using System;
using System.Text;

namespace ConsoleHerhalingCircus

{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;
			
			const double TicketVolwassenen = 19.90;
			const double TicketKinderen = 12.50;
			int volwTotaal = 0;
			int kindTotaal = 0;
			
			Console.WriteLine(@"
Welkom bij de ticketshop voor ""Circus Stromboli""

(a) Tickets toevoegen
(b) Winkelmandje tonen
(c) Winkelmandje wissen
(q) Bestelling afronden
");

			Console.WriteLine();
			string keuzen;
			
			do
			{
				Console.Clear();
				Console.Write("Je keuze: ");
				
				keuze = Console.ReadLine();
				
				switch (keuze)
                {
                    // A: tickets toevoegen
                    case "a":
                        Console.Write("Volwassenen: ");
                        int volw = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kinderen: ");
                        int kind = Convert.ToInt32(Console.ReadLine());

                        volwTotaal += Math.Max(0, volw);
                        kindTotaal += Math.Max(0, kind);

                        Console.WriteLine($"\nEr zijn tickets voor {volw} volwassenen en {kind} kinderen toegevoegd aan je winkelmandje.");
                        Console.WriteLine("\n...druk een toets om verder te gaan.");
                        Console.ReadKey(true);
                        break;

                    // B: winkelmand tonen
                    case "b":
                        if (volwTotaal == 0 && kindTotaal == 0)
                        {
                            Console.WriteLine("\nJe winkelmandje is leeg");
                        }
                        else
                        {
                            Console.WriteLine($"\nVolwassenen: {new string('■', Math.Min(volwTotaal, 50))}");
                            Console.WriteLine($"Kinderen:   {new string('■', Math.Min(kindTotaal, 50))}");
                            Console.WriteLine($"\nTotaal volwassenen: {volwTotaal}");
                            Console.WriteLine($"Totaal kinderen:    {kindTotaal}");
                        }
                        Console.WriteLine("\n...druk een toets om verder te gaan.");
                        Console.ReadKey(true);
                        break;

                    // C: winkelmand wissen
                    case "c":
                        volwTotaal = 0;
                        kindTotaal = 0;
                        Console.WriteLine("\nWinkelmandje is gewist.");
                        Console.WriteLine("\n...druk een toets om verder te gaan.");
                        Console.ReadKey(true);
                        break;

                    // Q: bestelling afronden
                    case "q":
                        Console.Clear();

                        double totaal = volwTotaal * PrijsVolwassene + kindTotaal * PrijsKind;
                        Console.WriteLine($"Totaalprijs: € {totaal:F2}\n");

                        Console.Write("Ben je jarig vandaag (j/n)? ");
                        bool jarig = Console.ReadLine().Trim().ToLower() == "j";

                        double kortingPct = 0;
                        if (jarig)
                        {
                            // random korting tussen 5% en 10% (inclusief)
                            Random rnd = new Random();
                            kortingPct = rnd.Next(5, 11);
                            Console.WriteLine($"Gefeliciteerd! Je krijgt {kortingPct}% korting op je totaalprijs.");
                        }

                        double teBetalen = totaal * (1 - kortingPct / 100.0);
                        Console.WriteLine($"\nTe betalen bedrag: € {teBetalen:F2}");

                        int bonus = (int)(teBetalen / 10.0);
                        Console.WriteLine($"\nJe hebt {bonus} bonuspunten verzameld.");
                        Console.WriteLine("Tot ziens!\n");
                        Console.WriteLine("...druk een toets om af te sluiten.");
                        Console.ReadKey(true);
                        break;

                    // onbekende keuze
                    default:
                        Console.WriteLine("\nOnbekende keuze.");
                        Console.WriteLine("\n...druk een toets om verder te gaan.");
                        Console.ReadKey(true);
                        break;
                }
            }
            while (keuze != "q");
        }
    }
}