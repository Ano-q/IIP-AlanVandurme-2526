using System;

namespace ConsoleNamenZoeken
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] namen = { "Elias", "Fatima", "Noah", "Aisha", "Liam", "Sofia", "Kenji", "Mila", "Omar", "Yara" };

         bool stoppen = false;

         while (!stoppen)
         {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("a. Controleer of naam bestaat");
            Console.WriteLine("b. Zoek volgnummer van naam");
            Console.WriteLine("c. Zoek naam op woord");
            Console.WriteLine("d. Zoek naam op lengte");
            Console.WriteLine("e. Afsluiten");
            Console.WriteLine();

            Console.Write("Maak een keuze: ");
            char keuze = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (keuze)
            {
               case 'a':
                  Console.Write("Naam: ");
                  string naamA = Console.ReadLine();

                  if (NaamBestaat(namen, naamA))
                  {
                     Console.WriteLine($"'{naamA}' komt voor in de lijst");
                  }
                  else
                  {
                     Console.WriteLine($"'{naamA}' komt niet voor in de lijst");
                  }
                  break;

               case 'b':
                  Console.Write("Naam: ");
                  string naamB = Console.ReadLine();

                  int? volgnummer = ZoekVolgnummer(namen, naamB);
                  if (volgnummer == null)
                  {
                     Console.WriteLine($"'{naamB}' is niet gevonden");
                  }
                  else
                  {
                     Console.WriteLine($"'{naamB}' is gevonden op positie {volgnummer}");
                  }
                  break;

               case 'c':
                  Console.Write("Zoekwoord: ");
                  string zoekwoord = Console.ReadLine();

                  string gevondenNaam = ZoekOpWoord(namen, zoekwoord);
                  if (gevondenNaam == null)
                  {
                     Console.WriteLine($"geen naam gevonden voor '{zoekwoord}'");
                  }
                  else
                  {
                     Console.WriteLine($"'{gevondenNaam}' gevonden voor '{zoekwoord}'");
                  }
                  break;

               case 'd':
                  Console.Write("Lengte: ");
                  int lengte = Convert.ToInt32(Console.ReadLine());

                  string naamMetLengte = ZoekOpLengte(namen, lengte);
                  if (naamMetLengte == null)
                  {
                     Console.WriteLine($"geen naam gevonden met {lengte}");
                  }
                  else
                  {
                     Console.WriteLine($"naam met {lengte}: {naamMetLengte}");
                  }
                  break;

               case 'e':
                  stoppen = true;
                  break;

               default:
                  Console.WriteLine("Onbekende keuze");
                  break;
            }

            if (!stoppen)
            {
               Console.WriteLine();
            }
         }
      }

      private static bool NaamBestaat(string[] namen, string naam)
      {
         for (int i = 0; i < namen.Length; i++)
         {
            if (namen[i] == naam) return true;
         }
         return false;
      }

      private static string ZoekOpLengte(string[] namen, int lengte)
      {
         for (int i = 0; i < namen.Length; i++)
         {
            if (namen[i].Length == lengte) return namen[i];
         }
         return null;
      }

      private static int? ZoekVolgnummer(string[] namen, string naam)
      {
         for (int i = 0; i < namen.Length; i++)
         {
            if (namen[i] == naam) return i + 1; // 1 = eerste
         }
         return null;
      }

      private static string ZoekOpWoord(string[] namen, string woord)
      {
         if (woord == null) return null;

         string woordLower = woord.ToLower();

         for (int i = 0; i < namen.Length; i++)
         {
            string naamLower = namen[i].ToLower();

            if (naamLower.Contains(woordLower))
            {
               return namen[i];
            }
         }
         return null;
      }
   }
}
