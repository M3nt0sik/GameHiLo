using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHiLo
{
     internal class HiLoGame
    {
        static Random random = new Random();
        public int MAXIMUM = 10;
        private int curentNumber = random.Next(1,11);
        private int pot=MAXIMUM;

        public void Guess( bool higher)
        {
            int nextNumber = random.Next(1, 11);
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
        }



        


    }
}
