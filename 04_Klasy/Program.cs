using _04_Klasy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {

            Users.Test test = new Users.Test();
            _04_Klasy.Reports.Test test2 = new _04_Klasy.Reports.Test();

            Employee employee = new Employee();

            double a = 12.34, b = 32.23, obwod, pole;
            Prostokat prostokat1 = new Prostokat(a, b);
            obwod = prostokat1.ObliczObwod();
            pole = prostokat1.ObliczPole();
            prostokat1.obwod = -987;
            

            Console.WriteLine("Pole={0}, obwod={1}", pole, obwod);
            Console.WriteLine(prostokat1.ToString());

            Prostokat prostokat2 = new Prostokat(5);
            obwod = prostokat2.ObliczObwod();
            pole = prostokat2.ObliczPole();
            Console.WriteLine("Pole={0}, obwod={1}, kwadrat={2}", pole, 
                obwod, prostokat2.CzyKwadrat() );

            Console.ReadKey();
        }
    }
}
