using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Class1
    {
        private List<Dog> AllDogs;
        public Lab1()
        {
            AllDogs = new List<Dog>();
        }
        public Lab1(List<Dog> Dogs)
        {
            AllDogs = new List<Dog>();
            foreach (Dog dog in Dogs)
            {
                this.AllDogs.Add(dog);
            }
        }
        public void Add(Dog dog)
        {
            AllDogs.Add(dog);
        }

    }
}
