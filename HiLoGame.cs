using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHiLo
{
     static class HiLoGame
    {
        static Random random = new Random();
        public const int  MAXIMUM = 10;
        private static int curentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot=MAXIMUM;
        
        public static int GetPot() { return pot; }

        public static void Guess( bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if (higher && nextNumber>=curentNumber)
            {
                Console.WriteLine("Zgadles!!!");
                pot++;
                         
            }
            else if(!higher && nextNumber <= curentNumber) {
                Console.WriteLine("Zgadles!!!");
                pot++;
            }
            else
            {
                Console.WriteLine("Niestety bledna odpowiedz");
                pot--;
            }
            curentNumber = nextNumber;
            Console.WriteLine($"Aktualna wartosc {curentNumber}");
        }
        public static void Hint()
        {
            if (MAXIMUM / 2 >= curentNumber) {
                Console.WriteLine($"Liczja mniejsza niz {MAXIMUM / 2}");
            }
            else { Console.WriteLine($"Liczba wieksza niz {MAXIMUM / 2}"); }
            pot--;
        }


    }
}
