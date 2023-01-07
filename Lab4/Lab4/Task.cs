using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab4
{
    class Task
    {
        /*public static void Process(string fin, string fin2, string fout, char[] punctuation)
        {
            string exp = "";
            int a = 0;
            string word = "";
            string[] lines = File.ReadAllLines(fin, Encoding.UTF8);
            using (var writerF = File.CreateText(fout))
            {
                //Console.WriteLine("Zodziai, kurie yra abejuose failuose:");
                //Console.WriteLine(new string('-', 38));
                //Console.WriteLine("|  Zodis   |  Pasikarotkimu skaicius |");
                //Console.WriteLine(new string('-', 38));
                foreach (var line in lines)
                {
                    //Console.Write(line);
                    
                    string[] parts = line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var part in parts)
                    {
                        exp = FindUnuiqueBothFileWords(fin2, punctuation, part);
                        word = FindUnuiqueSingleFileWords(fin, punctuation, exp);
                        Console.WriteLine(word);
                        //Console.WriteLine(part);
                        string[] parts2 = part.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
                        //foreach (var part2 in parts2)
                            //Console.WriteLine(part2);
                    }
                }
            }
        }
        */
        //public static List<Words> FindUnuiqueBothFileWords(string[] Parts, List<Words> CloneWords, string[] Word)
        //{
        //    foreach (var part in Parts)
        //    {
        //        foreach(var word in Word)
        //        {
        //            Console.WriteLine(word);
        //            if (UniqueWords(word, part))
        //            {
        //                int index = FindIndex(CloneWords, word);

        //                if (index > -1)
        //                {
        //                    CloneWords[index].Amount++;
        //                }
        //                else
        //                {
        //                    Words newWord = new Words(word);
        //                    CloneWords.Add(newWord);
        //                }
        //            }
        //        }
        //    }
        //    return CloneWords;
        //}
        public static List<Words> FindUnuiqueBothFileWords(string[] Parts, List<Words> CloneWords, string[] Word)
        {
            foreach (var part in Parts)
            {
                foreach (var word in Word)
                {
                    int index = FindIndex(word, part);
                    if (index > -1)
                    {
                        CloneWords[index].Amount++;
                    }
                    else if (longWords.Count < 10 && word != "")
                    {
                        Words newWord = new Words(word);
                        CloneWords.Add(newWord);
                    }
                    else if (word != "")
                    {
                        index = ShortestIndex(longWords);
                        Words newWord = new Words(word);
                        CloneWords[index] = newWord;
                    }
                }
                return CloneWords;
            }
        }
        public static List<Words> FindUnuiqueSingleFileWords(string[] Parts, List<Words> CloneWords, string[] Word)
        {
            foreach (var part in Parts)
            {
                foreach (var word in Word)
                {
                    if (!UniqueWords(part, word))
                    {
                        int index = FindIndex(CloneWords, word);

                        if (index > -1)
                        {
                            CloneWords[index].Amount++;
                        }
                        else
                        {
                            Words newWord = new Words(word);
                            CloneWords.Add(newWord);
                        }
                    }
                }
            }
            return CloneWords;
        }
        private static int FindIndex(List<Words> list, string Index)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].Word.Equals(Index))
                    return i;
            return -1;
        }
        private static bool UniqueWords(string Word, string Words)
        {
            if(Word.Length > 0)
            {
                Match match = Regex.Match(Word, Words);
                if (match.Success)
                    return true;
            }
            return false;
        }
    }
}
