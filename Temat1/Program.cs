using System;
using System.Data;

namespace Drugie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę od 1 do 999: ");
            int liczba = int.Parse(Console.ReadLine());

            int setne = liczba / 100;
            liczba -= setne * 100;
            int dziesietne = liczba / 10;
            liczba -= dziesietne * 10;
            int jednosci = liczba;

            int suma = setne + dziesietne + jednosci;

            if (suma % 3 == 0)
            {
                Console.WriteLine("Liczba ta jest podzielna przez 3.");
            }
            else
            {
                Console.WriteLine("Liczba ta nie jest podzielna przez 3.");
            }
            
        }
    }
}