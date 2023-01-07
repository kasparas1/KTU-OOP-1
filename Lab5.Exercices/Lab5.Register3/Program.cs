using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Register3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CFd = "Duomenys.txt";
            const string CFr = "Rezultatai.txt";
            const string CFa = "Analize.txt";
            InOut.Process(CFd, CFr, CFa);
        }
    }
}
