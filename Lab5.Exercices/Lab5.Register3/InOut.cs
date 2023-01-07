﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5.Register3
{
    class InOut
    {
        public static void Process(string fin, string fout, string finfo)
        {
            string[] lines = File.ReadAllLines(fin, Encoding.UTF8);
            using (var writerF = File.CreateText(fout))
            {
                using (var writerI = File.CreateText(finfo))
                {
                    foreach (string line in lines)
                    {
                        if (line.Length > 0)
                        {
                            string newLine = line;
                            if (TaskUtils.RemoveComments(line, out newLine))
                                writerI.WriteLine(line);
                            if (newLine.Length > 0)
                                writerF.WriteLine(newLine);
                        }
                        else
                            writerF.WriteLine(line);
                    }
                }
            }
        }


    }
}

