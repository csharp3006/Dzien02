using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Co jest wieksze, 5 czy 3: {0}", FindMax(5,3)  );

            int x = 100, y = -100;
            SwapVar(ref x, ref y);
            Console.WriteLine("X={0}, Y={1}", x, y);

            int result;
            FindMaxOut(5, 3, out result);
            Console.WriteLine("Co jest wieksze, 5 czy 3: {0}", result);

            PrintEmpData("Jan", "Kowalski");
            PrintEmpData("Jan", "Kowalski", 45);
            PrintEmpData("Jan", "Kowalski", 45, 9999);
            PrintEmpData("Jan", "Kowalski", salary: 12345);
            PrintEmpData("Jan", "Kowalski", salary: 12345, age: 55);
            PrintEmpData(salary: 12345, age: 55);

            Console.ReadKey();
        }

        static void PrintEmpData(string fname="XXX", string lname="YYY", int age=0, double salary=0.0)
        {
            if (age > 0)
            {
                Console.WriteLine("{0} {1}, wiek={2}, zarobki={3}", fname, lname, age, salary);
            } else
            {
                Console.WriteLine("{0} {1}, zarobki={2}", fname, lname, salary);
            }
        }

        /// <summary>
        /// Przykład przekazywania parametrów przez referencje
        /// </summary>
        /// <param name="x">Zmienna X</param>
        /// <param name="y">Zmienna Y</param>
        private static void SwapVar(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static void FindMaxOut(int a, int b, out int c)
        {
            c =  (a > b) ? a : b;
        }

    }
}
