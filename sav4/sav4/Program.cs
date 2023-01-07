using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sav4
{
    class Program
    {
        static void Main(string[] args)
        {
            char gender;
            string end, name;
            Console.WriteLine("Ivesk savo varda");
            name = Console.ReadLine();
            Console.WriteLine("");
            end = name.Substring(name.Length - 1);
            gender = char.Parse(end);
            if (gender == 's')
            {
                end = name.Substring(name.Length - 2);
                name = name.Remove(name.Length - 2);
                Console.Write("Labas, " + name);
                if (end == "as")
                    Console.WriteLine("ai!");
                else if (end == "is")
                    Console.WriteLine("i!");
                else if (end == "ys!")
                    Console.WriteLine("y!");
            }
            else
            {
                end = name.Substring(name.Length - 1);
                name = name.Remove(name.Length - 1);
                Console.Write("Labas, " + name);
                if (end == "a")
                    Console.WriteLine("ai!");
                else if (end == "e")
                    Console.WriteLine("e!");
            }
            Console.ReadKey();
        }
    }
}
