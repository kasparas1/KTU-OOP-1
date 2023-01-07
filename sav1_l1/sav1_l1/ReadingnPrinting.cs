using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sav1_l1
{
    class ReadingnPrinting
    {
        public static List<Money> ReadInfo(string fileName)
        {
            List<Money> Info = new List<Money>();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach (string line in Lines)
            {
                string[] Values = line.Split(';');
                string name = Values[0];
                string lastname = Values[1];
                double cash = double.Parse(Values[2]);
                Money money = new Money( name, lastname, cash);
                Info.Add(money);
            }
            return Info;
        }

        public static void Print(List<Money> Info)
        {
            double max = 0;
            double touristPart = 0;
            double sum = 0;
            bool test = false;
            int n = 0;
            double[] MoreThanOne = new double[20];
            Console.WriteLine(new string('_', 98));
            foreach (Money money in Info)
            {
                touristPart = money.Cash * 0.25;
                Console.WriteLine("| Vardas: {0,15} |  Pavarde: {1,20} | Prisideta Suma {2,20} |", money.Name, money.LastName, touristPart);
                Console.WriteLine(new string('_', 98));
                if (max < touristPart)
                    max = touristPart;
            }
            Console.WriteLine("Zmones kurie prisdejo daugiausia:");
            Console.WriteLine(new string('_', 98));
            foreach (Money money in Info)
            {
                touristPart = money.Cash * 0.25;

                if (max == touristPart)
                {
                    Console.WriteLine("| Vardas: {0,15} |  Pavarde: {1,20} | Prisideta Suma: {2,20} |", money.Name, money.LastName, touristPart);
                    Console.WriteLine(new string('_', 98));
                }
                sum = touristPart + sum;
                
            }
           

            
  
            Console.WriteLine("Is viso: {0}", max);
           
        }
    }
}
