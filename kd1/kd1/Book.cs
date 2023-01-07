using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kd1
{
    class Book
    {
        public string Publisher { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string SoldTitle { get; set; }

        public Book(string publisher, string title, int amount, double price, string soldTitle)
        {
            this.Publisher = publisher;
            this.Title = title;
            this.Amount = amount;
            this.Price = price;
            this.SoldTitle = soldTitle;
        }
        public Book()
        {

        }
        public override string ToString()
        {
            string line;
;           line = string.Fomat("{0} {1}" this.Publisher, this.Title);
            return line;
        }
    }
}
