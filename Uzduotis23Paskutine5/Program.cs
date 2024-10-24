using System;

class Program
{
    static void Main(string[] args)
    {
        string vardas;

        while (true)
        {
            Console.Write("Įveskite vardą: ");
            vardas = Console.ReadLine();

            if (vardas.Length > 3)
            {
                Console.WriteLine($"Labas, {vardas}!");
                break; // Nutraukti ciklą, jei vardas ilgesnis nei 3 simboliai
            }
            else
            {
                Console.WriteLine("Vardas per trumpas, bandykite dar kartą.");
            }
        }
    }
}