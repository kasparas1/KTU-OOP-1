using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4.part2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CFd = "Duomenys.txt";
            const string CFr = "Rezultatai.txt";
            int j = 999;
            int[] No = new int[j];
            int n = 0;
            n = InOut.LongestLine(CFd, n);
            for (int i = 0; i < n; i++)
            {
                No[i] = InOut.LongestLine(CFd, n);
                InOut.RemoveLine(CFd, CFr, No[i]);
                Console.WriteLine("Ilgiausios eilutės nr. {0, 4:d}", No[i] + 1);
            }
           
        }
    }
}
