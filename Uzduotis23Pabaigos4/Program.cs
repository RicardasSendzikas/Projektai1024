using System;

class Program
{
    static void Main(string[] args)
    {
        double suma = 0;

        while (suma <= 100)
        {
            Console.Write("Įveskite skaičių: ");
            double skaičius = double.Parse(Console.ReadLine());
            suma += skaičius; // Pridėti skaičių prie sumos

            if (suma <= 100)
            {
                Console.WriteLine("Tęskite įvedimą.");
            }
        }

        Console.WriteLine("Suma viršyta.");
    }
}