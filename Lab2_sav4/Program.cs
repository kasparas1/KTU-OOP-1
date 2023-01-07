using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sav4
{
    class Program
    {
        static void Main(string[] args)
        {
            FlatsRegister register = ReadingnPrinting.ReadFlats("Flats.csv");
            Console.WriteLine("visi butai:");
            ReadingnPrinting.PrintFlats(register);
            Console.WriteLine();
            Console.WriteLine("Įveskite norimą kambarių kiekį:");
            int roomNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite maksimalią buto kainą:");
            double maxPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite žemiausią norimą aukštą [1-9]:");
            int minFloor = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite aukščiausią norimą aukštą [{0}-9]:", minFloor);
            int maxFloor = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Flat> filtered = register.FilterByRoomNo(roomNo);
            filtered = FlatsRegister.FilterByPrice(filtered, maxPrice);
            filtered = FlatsRegister.FilterByFloor(filtered, minFloor, maxFloor);

            FlatsRegister filteredRegister = new FlatsRegister(filtered);
            Console.WriteLine("Atrinkti butai:");
            ReadingnPrinting.PrintFlats(filteredRegister);
        }
    }
}
