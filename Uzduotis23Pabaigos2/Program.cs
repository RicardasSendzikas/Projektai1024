using System;

class Program
{
    static void Main(string[] args)
    {
        string teisingasSlaptazodis = "slaptas123"; // Nustatyti teisingą slaptažodį
        string įvestasSlaptazodis;

        while (true)
        {
            Console.Write("Įveskite slaptažodį: ");
            įvestasSlaptazodis = Console.ReadLine();

            if (įvestasSlaptazodis == teisingasSlaptazodis)
            {
                Console.WriteLine("Prisijungimas sėkmingas.");
                break; // Nutraukti ciklą, jei slaptažodis teisingas
            }
            else
            {
                Console.WriteLine("Neteisingas slaptažodis, bandykite dar kartą.");
            }
        }
    }
}