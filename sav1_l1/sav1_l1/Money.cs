using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sav1_l1
{
    class Money
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Cash { get; set; }

        public Money(string name, string lastname, double cash)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Cash = cash;
        }
    }
}
