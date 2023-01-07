using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sav2
{
    class Program
    {
        static void Main(string[] args)
        {
            double functionResult = 0;
            double x;
            Console.WriteLine("Ivesikte x reiksme");
            x = double.Parse(Console.ReadLine());
            if (x <= 0 && x >= -3)
                functionResult = 1 / (x - 5);
            else if (x <= 5)
                functionResult = Math.Pow(x + 5.0, 0.5);
            else
                functionResult = Math.Pow(x + 3.0, 2);
            if (x < -3)
                Console.WriteLine("Ivedet per maza skaiciu");
            else
                Console.WriteLine("reikšmė x = {0}, fx = {1}", x, functionResult);
            Console.ReadKey();
        }
    }
}
