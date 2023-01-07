using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sav4
{
    class Program
    {
        static void Main(string[] args)
        {
            UniContainer university = ReadingnPrinting.Reading("Uni.csv");
            ReadingnPrinting.Printing(university);
        }
    }
}
