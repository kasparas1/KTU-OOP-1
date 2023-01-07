using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sav1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, rows;
            char symbol;
            Console.WriteLine("Iveskite norima simboli");
            symbol = (char)Console.Read();
            Console.ReadLine();
            Console.WriteLine("Iveskite norima simboliu kieki");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite kiek norite simboliu eiluteje");
            rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < count;)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(symbol);
                    i++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
