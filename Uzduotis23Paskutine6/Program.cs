using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Įveskite skaičių nuo 1 iki 7: ");
        int diena = int.Parse(Console.ReadLine());

        switch (diena)
        {
            case 1:
                Console.WriteLine("1 - Pirmadienis");
                break;
            case 2:
                Console.WriteLine("2 - Antradienis");
                break;
            case 3:
                Console.WriteLine("3 - Trečiadienis");
                break;
            case 4:
                Console.WriteLine("4 - Ketvirtadienis");
                break;
            case 5:
                Console.WriteLine("5 - Penktadienis");
                break;
            case 6:
                Console.WriteLine("6 - Šeštadienis");
                break;
            case 7:
                Console.WriteLine("7 - Sekmadienis");
                break;
            default:
                Console.WriteLine("Netinkamas skaičius, bandykite dar kartą.");
                break;
        }
    }
}