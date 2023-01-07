using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab5.Register4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CFd = "Duomenys.txt";
            string punctuation = "[\\s,.;:!?()\\-]+";
            Console.WriteLine("Sutampančių žodžių {0, 3:d}", TaskUtils.Process(CFd, punctuation));
        }

    }
}
