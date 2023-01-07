using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Register
{
    class LettersFrequency
    {
        private const int CMax = 256;
        private int[] Frequency;
        public string line { get; set; }
        public LettersFrequency()
        {
            line = "";
            Frequency = new int[CMax];
            for (int i = 0; i < CMax; i++)
                Frequency[i] = 0;
        }
        public int Get(char character)
        {
            return Frequency[character];
        }
        public void Count()
        {
            for (int i = 0; i < line.Length; i++)
                if (('a' <= line[i] && line[i] <= 'z') || ('A' <= line[i] && line[i] <= 'Z'))
                    Frequency[line[i]]++;
        }
            
    }
}
