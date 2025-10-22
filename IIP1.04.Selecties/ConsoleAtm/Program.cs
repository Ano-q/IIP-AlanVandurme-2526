using System;
using System.Text;

namespace ConsoleAtm
{
   class Program
   {
      static void Main(string[] args)
      {
		const int MAX_AFHALING = 200;
        int saldo = 1000;

        Console.WriteLine("Bankautomaat");
        Console.WriteLine("============");
        Console.WriteLine($"\nhuidig saldo: {saldo:C2}\n");

        Console.WriteLine("a. afhaling");
        Console.WriteLine("b. storting");
        Console.WriteLine("c. stoppen\n");

        Console.Write("je keuze: ");
        char keuze = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (keuze)
        {
            case 'a':
                Console.Write("welk bedrag wil je afhalen: ");
                int bedragAfhalen = Convert.ToInt32(Console.ReadLine());

                if (bedragAfhalen <= 0)
                {
                    Console.WriteLine("fout: bedrag moet positief zijn");
                    break;
                }

                int maximaalToegestaan = Math.Min(MAX_AFHALING, saldo);
                if (bedragAfhalen > maximaalToegestaan)
                {
                    Console.WriteLine($"fout: je kan maximaal {maximaalToegestaan} afhalen");
                    break;
                }

                bool deelbaarDoor10 = bedragAfhalen % 10 == 0;
                bool is10Of30 = bedragAfhalen == 10 || bedragAfhalen == 30;
                if (!(deelbaarDoor10 && !is10Of30))
                {
                    Console.WriteLine("fout: enkel briefjes van 20 en 50 zijn mogelijk");
                    break;
                }

                saldo -= bedragAfhalen;
                Console.WriteLine($"afhaling ok - het nieuw saldo is {saldo:C0}");
                break;

            case 'b':
                Console.Write("welk bedrag wil je storten: ");
                int bedragStorten = Convert.ToInt32(Console.ReadLine());

                if (bedragStorten <= 0)
                {
                    Console.WriteLine("fout: bedrag moet positief zijn");
                    break;
                }

                saldo += bedragStorten;
                Console.WriteLine($"storting ok - het nieuw saldo is {saldo:C0}");
                break;

            case 'c':
                Console.WriteLine("bedankt en tot ziens");
                break;

            default:
                Console.WriteLine("ongeldige keuze");
                break;
			}
        }
    }
}