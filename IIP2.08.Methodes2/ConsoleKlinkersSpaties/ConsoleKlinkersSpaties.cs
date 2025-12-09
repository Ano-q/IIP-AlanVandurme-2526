using System;

namespace ConsoleKlinkersSpaties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine() ?? "";

            int spaties = AantalSpaties(tekst);
            int klinkers = AantalKlinkers(tekst);
            string geheim = NaarGeheimschrift(tekst);

            Console.WriteLine($"deze tekst bevat {klinkers} klinkers en {spaties} spaties");
            Console.WriteLine($"in geheimschrift: {geheim}");
        }

        static int AantalSpaties(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (c == ' ')
                    count++;
            }
            return count;
        }

        static bool IsKlinker(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        static int AantalKlinkers(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (IsKlinker(c))
                    count++;
            }
            return count;
        }

        static string NaarGeheimschrift(string s)
        {
            string geheim = "";

            foreach (char c in s)
            {
                if (c == ' ')
                {
                    geheim += " ";
                }
                else
                {
                    int code = (int)c;
                    code++;
                    geheim += (char)code;
                }
            }

            return geheim;
        }
    }
}