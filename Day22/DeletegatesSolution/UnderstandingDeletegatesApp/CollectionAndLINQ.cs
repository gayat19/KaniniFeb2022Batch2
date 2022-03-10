using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDeletegatesApp
{
    class CollectionAndLINQ
    {
        public void UnderstandingLINQ()
        {
            int[] numbers = { 20, 45, 90, 54, 94, 78, 86, 67 };
            
            foreach (var item in numbers)
            {
                if(item>70)
                 Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            var goodScores = from n in numbers where n > 70 select n;
            foreach (var item in goodScores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            var goodScoresLanbda = numbers.Where(n => n > 70);
            foreach (var item in goodScoresLanbda)
            {
                Console.WriteLine(item);
            }

        }
    }
}
