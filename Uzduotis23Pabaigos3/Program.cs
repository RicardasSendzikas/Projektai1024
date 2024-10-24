using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Įveskite savo amžių: ");
        int amžius = int.Parse(Console.ReadLine());

        switch (amžius)
        {
            case < 13:
                Console.WriteLine("Jūs esate vaikas.");
                break;
            case < 20:
                Console.WriteLine("Jūs esate paauglys.");
                break;
            case < 65:
                Console.WriteLine("Jūs esate suaugęs.");
                break;
            default:
                Console.WriteLine("Jūs esate senjoras.");
                break;
        }
    }
}