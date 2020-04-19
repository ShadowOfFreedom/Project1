using System;
using System.Collections.Generic;

namespace ProjectC
{
    class Program
    {
        static void Main(string[] args)
        {
            var rejestr = new Dictionary<string, int>();

            Console.Write("Prosze wprowadzic wartosc rejestru AX: ");

            string ax = Console.ReadLine();    //zrób tak dla wszystkich inputów użytkownika i przeczytaj sobie jak używać Dictionary<TKey, TValue> https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.8
            int axInt;
            if (!string.IsNullOrEmpty(ax) && int.TryParse(ax, out axInt))
            {
                rejestr.Add("AX", axInt);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }

            Console.Write("Prosze wprowadzic wartosc rejestru BX: ");
            int pudelkoB = int.Parse(Console.ReadLine());

            Console.Write("Prosze wprowadzic wartosc rejestru CX: ");
            int pudelkoC = int.Parse(Console.ReadLine());

            Console.Write("Prosze wprowadzic wartosc rejestru DX: ");
            int pudelkoD = int.Parse(Console.ReadLine());
            Console.WriteLine();
          
            Console.WriteLine("Twoje wartosci to: ");

            Console.WriteLine();
            Console.WriteLine($"1. AX: {rejestr["AX"]}"); //Czytanie z Dictionary rejest, do zmiany w reszcie
            Console.WriteLine($"1. BX: {pudelkoB}");
            Console.WriteLine($"1. CX: {pudelkoC}");
            Console.WriteLine($"1. DX: {pudelkoD}");
            Console.WriteLine();
            
            //Wybor:
            Console.WriteLine("Wybierz swoje 2 rejestry na ktorych chcesz wykonac rozkaz");
            Console.WriteLine("AX, BX, CX, DX");

            do
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "ax":
                        //tu robisz co ma być zrobione
                        break;
                    case "bx":
                        //tu robisz co ma być zrobione
                        break;
                    case "cx":
                        //tu robisz co ma być zrobione
                        break;
                    case "dx":
                        //tu robisz co ma być zrobione
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa wartość");
                        break;
                }

                Console.WriteLine("Kontynuować? y/n");

            } while (Console.ReadLine() == "y");          
        }
    }
}
