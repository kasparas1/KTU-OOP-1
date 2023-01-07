using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Exercises.Register
{
    class DogsContainer
    {
        private Dog[] dogs;
        private int Capacity;
        public int Count { get; private set; }
        public DogsContainer(int capacity = 16)
        {
            this.dogs = new Dog[16];
            this.Capacity = capacity;
            this.dogs = new Dog[capacity];
        }
        public void Add(Dog dog)
        {
            if (this.Count == this.Capacity)
                ensureCapacity(this.Capacity * 2);
            this.dogs[this.Count++] = dog;
        }
        public Dog Get(int index)
        {
            return this.dogs[index];
        }
        public bool Contains(Dog dog)
        {
            for (int i = 0; i < this.Count; i++)
                if (this.dogs[i].Equals(dog))
                    return true;
            return false;
        }
        public int CountByGender(Gender gender, DogsContainer dogs)
        {
            int count = 0;
            for (int i = 0; i < Count; i++)
            {
                if (dogs.Get(i).Gender.Equals(gender))
                {
                    count++;
                }
            }
            return count;
        }
        private Dog FindDogByID(int ID)
        {
            for (int i = 0; i < Count; i++)
                if (dogs[i].ID == ID)
                    return dogs[i];
            return null;

        }
        public void UpdateVaccinationsInfo(List<Vaccination> Vaccinations)
        {
            foreach (Vaccination vaccination in Vaccinations)
            {
                Dog dog = FindDogByID(vaccination.DogID);
                if (dog != null && vaccination > dog.LastVaccinationDate)
                {
                    dog.LastVaccinationDate = vaccination.Date;
                }
            }
        }
        /*public List<Dog> FilterByVaccinationExpired(DogsContainer Filtered)
        {
            for (int i = 0; i < Count; i++)
            {
                if (dogs[i].RequiresVaccination)
                {
                    Filtered.Add(dogs[i]);
                }
            }
            return Filtered;
        }*/
        private void ensureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Dog[] temp = new Dog[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                    temp[i] = this.dogs[i];
                this.Capacity = minimumCapacity;
                this.dogs = temp;
            }
        }
        public void Sort()
        {
            bool flag = true;
            while(flag)
            {
                flag = false;
                for (int i = 0; i < this.Count - 1; i++)
                {
                    Dog a = this.dogs[i];
                    Dog b = this.dogs[i + 1];
                    if (a.CompareTo(b) > 0)
                    {
                        this.dogs[i] = b;
                        this.dogs[i] = a;
                        flag = true;
                    }
                }
            }
        }
        public void Put(Dog dog, int index)
        {
            this.dogs[index] = dog;
        }
        public void Insert (Dog dog, int index)
        {
            if (this.Count == this.Capacity)
                ensureCapacity(this.Capacity * 2);
            for (int i = Count; i > index; i--)
                this.dogs[i] = this.dogs[i - 1];
            this.dogs[index] = dog;
            this.Count++;
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
                this.dogs[i] = this.dogs[i + 1];
            this.Count--;
        }
        public void Remove(Dog dog)
        {
            for (int i = 0; i < Count; i++)
                for (int i = 0; i < Count; i++)
                    if (this.dogs[i].Equals(dog))
                    {
                        for (int )
                    }
        }
        public DogsContainer(DogsContainer container) : this()
        {
            for (int i = 0; i < container.Count; i++)
                this.Add(container.Get(i));
        }
        public DogsContainer Intersect(DogsContainer other)
        {
            DogsContainer result = new DogsContainer();
            for (int i = 0; i < this.Count; i++)
            {
                Dog current = this.dogs[i];
                if (other.Contains(current))
                    result.Add(current);
            }
            return result;
        }
           
    }  
}
