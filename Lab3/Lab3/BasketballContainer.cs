using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// A container which holds players information
    /// </summary>
    class BasketballContainer
    {

        private Basketball[] basketball;
        public int Count { get; private set; }
        private int Capacity;
        /// <summary>
        /// Defines Basketball container with a given capacity.
        /// </summary>
        /// <param name="capacity">Default capacity</param>
        public BasketballContainer(int capacity = 16)
        {
            this.Capacity = capacity;
            this.basketball = new Basketball[capacity];
        }
        /// <summary>
        /// Checks if capacity is overflowing, if it is, creates a new container with a new capacity
        /// </summary>
        /// <param name="minimumCapacity">New minimum capacity</param>
        private void EnsureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Basketball[] temp = new Basketball[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.basketball[i];
                }
                this.Capacity = minimumCapacity;
                this.basketball = temp;
            }
        }
        /// <summary>
        /// Adds an element into the container, making sure the capacity can hold it.
        /// </summary>
        /// <param name="basketball">Element to add to container</param>
        public void Add(Basketball basketball)
        {
            if (this.Count == this.Capacity) //container is full 
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.basketball[this.Count++] = basketball;
        }
        /// <summary>
        /// Takes an element from the container at a given position.
        /// </summary>
        /// <param name="index">Given position</param>
        /// <returns>Element from wanter position</returns>
        public Basketball Get(int index)
        {
            return this.basketball[index];
        }
        /// <summary>
        /// Checks if container constains a given element.
        /// </summary>
        /// <param name="b">Element to check</param>
        /// <returns>Whether that element exists in the container</returns>
        public bool Contains(Basketball b)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.basketball[i].Equals(b))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Replaces an element at a given position with a given element.
        /// </summary>
        /// <param name="b">Element to place</param>
        /// <param name="index">Position where to place the element.</param>
        public void Put(Basketball b, int index)
        {
            this.basketball[index] = b;
        }
        /// <summary>
        /// Inserts an element into the container at a given position, while not removing anything and making sure the capacity can hold it.
        /// </summary>
        /// <param name="b">Element to insert.</param>
        /// <param name="index">Position where to insert the element.</param>
        public void Insert(Basketball b, int index)
        {
            if (this.Count == this.Capacity) //container is full 
            {
                EnsureCapacity(this.Capacity * 2);
            }
            for (int i = Count; i > index; i--)
            {
                this.basketball[i] = this.basketball[i - 1];
            }
            this.basketball[index] = b;
            this.Count++;
        }
        /// <summary>
        /// Removes an element from container at a given position.
        /// </summary>
        /// <param name="index">Given position at which to remove an element.</param>
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                this.basketball[i] = this.basketball[i + 1];
            }
            this.Count--;
        }
        /// <summary>
        /// Removes elements from container that match given parameter.
        /// </summary>
        /// <param name="b">Parameter, which to remove from the container.</param>
        public void Remove(Basketball b)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.basketball[i].Equals(b))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        this.basketball[j] = this.basketball[j + 1];
                    }
                    i--;
                    this.Count--;
                }
            }
        }
        /// <summary>
        /// Selection sort
        /// </summary>
        public void Sort()
        {
            int hold; ///will hold i value to sort 
            Basketball temp; ///temp space for cars
            for (int i = 0; i < this.Count - 1; i++)
            {
                hold = i;
                for (int j = i + 1; j < this.Count; j++)
                {
                    if (this.basketball[hold].CompareTo(this.basketball[j]) > 0) hold = j;
                }
                temp = this.basketball[hold];
                this.basketball[hold] = this.basketball[i];
                this.basketball[i] = temp;
            }
        }

    }
}
   
