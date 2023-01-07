using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4.part2
{
    class InOut
    {
        public static int LongestLine(string fin, int i)
        {
            int n = 999;
            i = 0;
            int[] No = new int[n];
            No[0] = -1;
            int Nr = -1;
            using (StreamReader reader = new StreamReader(fin, Encoding.UTF8))
            {
                string line;
                int length = 0;
                int lineNo = 0;
                while((line = reader.ReadLine()) != null)
                {
                    if (line.Length > length)
                    {
                        length = line.Length;
                        Nr = lineNo;
                    }
                    lineNo++;
                    if (Nr == line.Length)
                        No[i] = Nr;
                    i++;
                }
            }
            return No[i];
        }
        public static void RemoveLine(string fin, string fout, int No)
        {
            using (StreamReader reader = new StreamReader(fin, Encoding.UTF8))
            {
                string line;
                int lineNo = 0;
                using(var writer = File.CreateText(fout))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (No != lineNo)
                            writer.WriteLine(line);
                        lineNo++;
                    } 
                }
            }
        }
    }
}
