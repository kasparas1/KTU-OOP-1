using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sav3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, answer = 0;
            char symbol;
            Console.WriteLine("Iveskite pirmaji skaiciu");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite simboli");
            symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu");
            b = double.Parse(Console.ReadLine());
            if (symbol == '/' && b == 0)
                Console.WriteLine("Negalima dalyba");
            else if (symbol == '+')
            {
                answer = a + b;
                Console.WriteLine("lygtis: {0} {1} {2} = {3}", a, symbol, b, answer);
            }
            else if (symbol == '/')
            {
                answer = a / b;
                Console.WriteLine("lygtis: {0} {1} {2} = {3}", a, symbol, b, answer);
            }
            else if (symbol == '*')
            {
                answer = a * b;
                Console.WriteLine("lygtis: {0} {1} {2} = {3}", a, symbol, b, answer);
            }
            else if (symbol == '-')
            {
                answer = a - b;
                Console.WriteLine("lygtis: {0} {1} {2} = {3}", a, symbol, b, answer);
            }
            else
                Console.WriteLine("Klaidinga operacija");
            Console.ReadKey();
        }
    }
}
