using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Register
{
    class Program
    {
        const string CFd = "Duomenys.txt";
        static void Main(string[] args)
        {
            
            const string CFr = "Rezultatai.txt";
            LettersFrequency letters = new LettersFrequency();
            InOut text = new InOut();
            List<TextLines> Text = InOut.ReadText(CFd);
            Console.WriteLine("Iveskite eilute is mazuju ir didzuju raidziu");
            string line = Console.ReadLine();
            letters.line = line;
            letters.Count();
            InOut.PrintRepetitions(CFr, letters);
        }
    }
}
