using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4_sav3
{
    class InOut
    {
        public static void ReadText(string fileName)
        {
            string[] Lines = File.ReadAllLines(fileName);
            string Text = Lines[0];
        }
    }
}
