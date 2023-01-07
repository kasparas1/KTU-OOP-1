using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sav4
{
    class ReadingnPrinting
    {
        public static FlatsRegister ReadFlats(string filename)
        {
            List<Flat> flats = new List<Flat>();
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                int no = int.Parse(values[0]);
                double area = double.Parse(values[1]);
                int roomNo = int.Parse(values[2]);
                double price = double.Parse(values[3]);
                string phoneNo = values[4];
                Flat flat = new Flat( no, area, roomNo, price, phoneNo);
                flats.Add(flat);
            }
            return new FlatsRegister(flats);
        }
        public static void PrintFlats(FlatsRegister register)
        {
            Console.WriteLine(new string('-', 78));
            Console.WriteLine("| {0,4} | {1,7} | {2,15} | {3,10} | {4,10} | {5,-13} |", "Num", "Aukštas", "Kambarių kiekis", "Plotas", "Kaina", "Telefonas");
            Console.WriteLine(new string('-', 78));
            for (int i = 0; i < register.Count(); i++)
            {
                Flat flat = register.GetFlat(i);
                Console.WriteLine("| {0,4} | {1,7} | {2,15} | {3,10:f2} | {4,10:f2} | {5,-13} |", flat.No, flat.Floor, flat.RoomNo, flat.Area, flat.Price, flat.PhoneNo);

            }
            Console.WriteLine(new string('-', 78));
        }
    }
}
