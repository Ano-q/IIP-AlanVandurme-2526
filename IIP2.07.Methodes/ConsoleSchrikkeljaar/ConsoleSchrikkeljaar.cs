using System;

namespace ConsoleSchrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"
SCHRIKKELJAAR
=============
");

            int jaar;

            do
            {
                Console.Write("Geef een jaartal: ");
                jaar = Convert.ToInt32(Console.ReadLine());

                if (jaar > 0)
                {
                    if (IsSchrikkeljaar(jaar))
                        Console.WriteLine($"Het jaar {jaar} is een schrikkeljaar.");
                    else
                        Console.WriteLine($"Het jaar {jaar} is geen schrikkeljaar.");
                }

            } while (jaar > 0);

            Console.WriteLine("\nBedankt en tot ziens.");
        }

        private static bool IsSchrikkeljaar(int jaar)
        {
            return (jaar % 4 == 0 && (jaar % 100 != 0 || jaar % 400 == 0));
        }
    }
}