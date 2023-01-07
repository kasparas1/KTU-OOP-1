using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sav4
{
    class Flat
    {
        public int No { get; set; }
        public double Area { get; set; }
        public int RoomNo { get; set; }
        public double Price { get; set; }
        public string PhoneNo { get; set ;}
        public int House { get { return (No - 1) / 27 + 1; } }
        public int Floor { get 
            {
                if (No % 3 == 0)
                    return No / 3;
                else
                    return (No / 3) + 1;
            }
        }
        public Flat(int no, double area, int roomNo, double price, string phoneNo)
        {
            this.No = no;
            this.Area = area;
            this.RoomNo = roomNo;
            this.Price = price;
            this.PhoneNo = phoneNo;
        }
    }
}
