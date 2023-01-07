using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sav1_l1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Money> allMoney = ReadingnPrinting.ReadInfo(@"Info.csv");
            ReadingnPrinting.Print(allMoney);

        }
    }
}
