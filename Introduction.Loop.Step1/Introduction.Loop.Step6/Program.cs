using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Loop.Step4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, n = 0, z = 0;
            Console.WriteLine("Iveskite Ciklo pradzios skaiciu");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite Ciklo pabaigos skaiciu");
            n = int.Parse(Console.ReadLine());
            Console.Write("Programa skaicuoja skaiciu {0}", x);
            Console.Write("-{0}", n);
            Console.WriteLine(" kvadratus ir kubus");
            for (int i = x; i <= n; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, i * i, i * i * i);
                z++;
            }
            Console.WriteLine("Kiek kartu buvo skaicuota:");
            Console.WriteLine("{0}", z++);
        }
    }
}