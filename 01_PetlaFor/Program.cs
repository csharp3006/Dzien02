using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetlaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            for (int i = 1; i <= 10; ++i)
            {
                if (i == 5)
                    continue;
                Console.WriteLine("Licznik pętli=" + i);
                if (i == 9) break;

                //i = 0;
            }

            
            
            for (int i=-50;i>=-10;i-=2) 
            {
                Console.WriteLine("Licznik pętli=" + i);
            }

            // nieskonczona petla for
            for (; ; )
            {
                break;
            }

            Console.ReadKey();
        }
    }
}
