using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sav4
{
    class UniContainer
    {
        private Uni[] university;
        private int Capacity;
        public int Count { get; private set; }
        public UniContainer(int capacity = 16)
        {
            this.university = new Uni[16];
            this.Capacity = capacity;
        }
        public void Add(Uni university)
        {
            if (this.Count == this.Capacity)
                ensureCapacity(this.Capacity * 2);
            this.university[this.Count++] = university;
        }
        public Uni Get(int index)
        {
            return this.university[index];
        }
        public bool Contains(Uni university)
        {
            for (int i = 0; i < this.Count; i++)
                if (this.university[i].Equals(university))
                    return true;
            return false;
        }
        private void ensureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Uni[] temp = new Uni[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                    temp[i] = this.university[i];
                this.Capacity = minimumCapacity;
                this.university = temp;
            }
        }
        public UniContainer CountAvrage(UniContainer university)
        {
            UniContainer avrage = new UniContainer();
            int sum = 0;
            avrage = 0;
            for (int i = 0; i < this.Count; i++)
            {
                Uni uni = university.Get(i);
                if (uni.Group == )
                sum = (uni.Grade * uni.GradeNO) + sum;
            }
            return result;
        }
    }
}
