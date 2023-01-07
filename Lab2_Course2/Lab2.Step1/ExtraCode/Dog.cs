using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Step1.ExtraCode
{
    internal class Dog : Animal
    {
        private static int VaccinationDuration = 1;
        public Dog(string name, int chipId, string breed, string owner, string phone, DateTime vaccinationDate, bool aggressive) : base(name, chipId, breed, owner, phone, vaccinationDate)
        {
            Aggressive = aggressive;
        }
        public Dog(string data)
        : base(data)
        {
            SetData(data);
        }
        public override void SetData(string line)
        {
            base.SetData(line);
            string[] values = line.Split(',');
            Aggressive = bool.Parse(values[7]);
        }
        public bool Aggressive { get; set; }
        public override bool isVaccinationExpired()
        {
            return VaccinationDate.AddYears(VaccinationDuration).CompareTo(DateTime.Now) > 0;
        }
        public override String ToString()
        {
            return String.Format("|{0,-3}|{1,-20}|{2,-9}|{3,-10} ({4})|{5:yyyy-MM-dd}|{6}|",
           ChipId, Breed, Name, Owner, Phone, VaccinationDate, Aggressive ? '+' : ' ');
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Dog); 
        }
        public bool Equals(Dog dog)
        {
            return base.Equals(dog); 
        }
        public override int GetHashCode()
        {
            return ChipId.GetHashCode() ^ Name.GetHashCode();
        }
    }

}

