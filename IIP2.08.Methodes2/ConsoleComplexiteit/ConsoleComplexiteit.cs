using System;

namespace ConsoleComplexiteit;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Geef een woord (enter om te stoppen): ");
            string woord = Console.ReadLine() ?? "";
            if (woord.Length == 0)
                break;

            int aantalKarakters = woord.Length;
            int lettergrepen = AantalLettergrepen(woord);
            double complex = Complexiteit(woord);

            Console.WriteLine($"aantal karakters: {aantalKarakters}");
            Console.WriteLine($"aantal lettergrepen: {lettergrepen}");
            Console.WriteLine($"complexiteit: {complex:F1}");
            Console.WriteLine();
        }
		
		Console.WriteLine();
        Console.WriteLine("Bedankt en tot ziens.");
    }

    static bool IsKlinker(char c)
    {
        char ch = char.ToLowerInvariant(c);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }

    static int AantalLettergrepen(string woord)
    {
        int count = 0;
        bool vorigeWasKlinker = false;

        foreach (char raw in woord)
        {
            if (!char.IsLetter(raw))
            {
                vorigeWasKlinker = false;
                continue;
            }

            bool isKlinker = IsKlinker(raw);
            if (isKlinker && !vorigeWasKlinker)
                count++;

            vorigeWasKlinker = isKlinker;
        }

        return count;
    }

    static double Complexiteit(string woord)
    {
        string w = woord.ToLowerInvariant();

        int letters = woord.Length;
        int lettergrepen = AantalLettergrepen(woord);

        int bonus = 0;
        if (w.Contains('q')) bonus++;
        if (w.Contains('x')) bonus++;
        if (w.Contains('y')) bonus++;

        double waarde = letters / 3.0 + lettergrepen + bonus;
        return Math.Round(waarde, 1);
    }
}
