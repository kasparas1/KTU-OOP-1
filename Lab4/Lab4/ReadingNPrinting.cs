using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab4
{
    class ReadingNPrinting
    {
        public static void ReadFile(string fin, string fin2, string punctuation, List<Words> UniqueWordsTAIBF, List<Words> UniqueSingleFileWords)
        {
            using (StreamReader read = new StreamReader(fin, Encoding.UTF8))
            {
                using (StreamReader read2 = new StreamReader(fin2, Encoding.UTF8))
                {
                    string line, line2;
                    while ((line = read.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        string[] parts = Regex.Split(line, punctuation);
                        while ((line2 = read2.ReadLine()) != null)
                        {
                            line = line.ToLower();
                            
                            string[] parts2 = Regex.Split(line2, punctuation);
                            UniqueWordsTAIBF = Task.FindUnuiqueBothFileWords(parts, UniqueWordsTAIBF, parts2);
                            UniqueSingleFileWords = Task.FindUnuiqueSingleFileWords(parts, UniqueWordsTAIBF, parts2);
                            //longWords = Task.FindUnuiqueSingleFileWords();
                        }
                    }
                }
            }
        }
        public static void PrintToFile(string fout, List<Words> UniqueWordsTAIBF, List<Words> UniqueSingleFileWords)
        {
            using (StreamWriter write = new StreamWriter(fout))
            {
                for (int i = 0; i < 10 && i < UniqueSingleFileWords.Count; i++)
                {
                    write.WriteLine("{0,6}", UniqueWordsTAIBF[i].Word);
                }
                foreach (Words word in UniqueSingleFileWords)
                {
                    write.WriteLine("{0,6}", word.Word);
                }
            }
        }
    }
}
