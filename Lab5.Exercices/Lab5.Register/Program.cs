using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Register
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CFd = "Duomenys.txt";
            const string CFr = "Rezultatai.txt";
            LettersFrequency letters = new LettersFrequency();
            Console.WriteLine("Iveskite eilute is mazuju ir didziuju raidziu");
            string line = Console.ReadLine();
            letters.line = line;
            letters.Count();
            InOut.PrintRepetitions(CFr, letters);
        }
    }
}
