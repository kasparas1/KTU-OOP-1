using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        const string CFd = "Knyga1.txt";
        const string CFh = "Knyga2.txt";
        const string CFr = "Rodikliai.txt";
        static void Main(string[] args)
        {
            
            string punctuation = "[\\s,.;:!?()\\-]+";
            List<Words> UniqueBothFileWords = new List<Words>();
            
            List<Words> UniqueSingleFileWords = new List<Words>();
            ReadingNPrinting.ReadFile(CFd, CFh, punctuation, UniqueBothFileWords, UniqueSingleFileWords);
            //Task.Process(CFd, CFh, CFr, punctuation);
            ReadingNPrinting.PrintToFile(CFr, UniqueBothFileWords, UniqueSingleFileWords);
        }
    }
}
