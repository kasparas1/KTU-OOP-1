using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO

namespace kd1
{
    internal class ReadingNPrinting
    {
       public static BookRegister Reading(string fileName)
        {
            BookRegister Book = new BookRegister();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            for (int i = 0; i < Lines.Length; i++)
            {
                string[] Values = Lines[i].Split(';');
                string Name = Values[0];
                int Price = int.Parse(Values[1]);
                Book book = new Book(Name, Price);
                Book.AddBook(book);
            }
            return Book;
        }
        public static void Print(BookRegister register)
        {
            string lines = new string[register.Count() + 1];
            for (int i = 0; i < register.Count(); i++)
            {
                lines[i] = Console.WriteLine();
            }
        }
            
            
    }
}
