using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Words
    {
        public string Word { get; set; }
        public int Amount { get; set; }
        public Words(string word)
        {
            this.Word = word;
            this.Amount = 1;
        }
            
    }
}
