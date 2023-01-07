using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sav4
{
    class ReadingnPrinting
    {
        public static UniContainer Reading(string fileName)
        {
            UniContainer university = new UniContainer();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            string faculty = (Lines[0]);
            foreach (string line in Lines)
                if (line.Contains(";"))
                {
                    string[] Values = line.Split(';');
                    string lastName = Values[0];
                    string name = Values[1];
                    string group = Values[2];
                    int gradeNo = int.Parse(Values[3]);
                    int grade = int.Parse(Values[4]);
                    Uni uni = new Uni(faculty, lastName, name, group, gradeNo, grade);
                    if (!university.Contains(uni))
                        university.Add(uni);
                }
            return university;
        }
        public static void Printing(UniContainer university)
        {

            Console.WriteLine(new string('-', 54));
            Console.WriteLine("| {0,-10} | {1,-10} | {2,-10} |", "Metai", "Stovyklos pradzia", "stovyklos pabaiga");
            Console.WriteLine(new string('-', 54));
            Console.WriteLine("| {0, 10} | {1, 17} | {2, 17} | {3,17} | {4,-17} | {5,-17} |", "fakultetas", "Pavarde", "Vardas", "Grupe", "Pazymiu skaicius", "pazimys");
            Console.WriteLine(new string('-', 54));
            for (int i = 0; i < university.Count; i++)
                Console.Write(university.Get(i).ToString());
        }
    }
}
