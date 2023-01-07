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
            int x = 1, n = 20, z = 0;
            Console.WriteLine("Skaiciai nuo 1 iki 20, ju kvadratai ir kubai");
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