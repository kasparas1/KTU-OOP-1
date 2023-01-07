using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kd2
{
    static class TaskUtils
    {
        public static bool NoDigits(string line)
        {
            Regex digits = new Regex("[0-9]");
            if(!digits.IsMatch(line))
                return true;
            return false;
        }
        public static int NumberDifferentVowelsInLine(string line)
        {
            //eyuioa
            line = line.ToLower();
            int count = 0;
            Char[] vowels = { 'a', 'y', 'u', 'i', 'e', 'o' }; 
            for (int i = 0; i < vowels.Length; i++)
                if(line.Contains(vowels[i]))
                    count++;
            return count;
        }
        public static string FindWord1Line(string line, string punctuation)
        {
            string longestWord = "";
            string[] parts = Regex.Split(line, punctuation);
            foreach(string part in parts)
            {
                if(NumberDifferentVowelsInLine(part) >= 3)
                    if(part.Length > longestWord.Length)
                        longestWord = part;
            }
            return longestWord;
        }
        public static string EditLine(string line, string punctuation, string word)
        {

            return "";
        }
        public static string FindWord2Line(string line, string punctuation)
        {
            Regex LastWord = new Regex(@"\s +\S *$");
            if (LastWord.IsMatch(line))
                if (NoDigits(line))
                    return line;
            return "";
        }
        public static void PerformTask(string fd, string fr)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Console.WriteLine("Iveskite eilute");
            line = Console.ReadLine();
            string vowels = "ayuieo";
            Console.WriteLine(TaskUtils.FindWord2Line( line, vowels));
        }
    }
}
