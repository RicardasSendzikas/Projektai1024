using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Įveskite skaičių (neigiamas skaičius, kad baigti): ");
            int skaičius = int.Parse(Console.ReadLine());

            if (skaičius < 0)
            {
                Console.WriteLine("Programa baigta.");
                break; // Nutraukti ciklą, jei skaičius neigiamas
            }

            if (skaičius % 2 == 0)
            {
                Console.WriteLine("Skaičius lyginis.");
            }
            else
            {
                Console.WriteLine("Skaičius nelyginis.");
            }
        }
    }
}