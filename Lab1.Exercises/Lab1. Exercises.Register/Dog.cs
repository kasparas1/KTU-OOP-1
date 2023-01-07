using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Exercises.Register
{
    class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public Dog(int id, string name, string breed, DateTime birthDate, Gender gender)
        {
            this.ID = id;
            this.Name = name;
            this.Breed = breed;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }
        public static Dog FindOldestDog(List<Dog> Dogs)
        {
            Dog oldest = Dogs[0]; // means least value
            for (int i = 1; i < Dogs.Count; i++)
                if(DateTime.Compare(Dogs[i].BirthDate, oldest.BirthDate) < 0)
                    oldest = Dogs[i];
            return oldest;
        }
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.BirthDate.Year;
            if (this.BirthDate.Date > today.AddYears(-age))
                age--;
            return age;
        }
    }
}
