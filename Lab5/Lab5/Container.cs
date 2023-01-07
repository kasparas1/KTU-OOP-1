using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// A container which holds players information
    /// </summary>
    class Container
    {
        public int Count { get; private set; }
        private Member[] members;
        private int Capacity;
        /// <summary>
        /// Defines container
        /// </summary>
        public Container()
        {
            Capacity = 1;
            this.members = new Member[Capacity]; //default capacity
        }
        /// <summary>
        /// Checks if capacity is overflowing, if it is, creates a new container with a new capacity
        /// </summary>
        /// <param name="minimumCapacity">New minimum capacity</param>
        private void EnsureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Member[] temp = new Member[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.members[i];
                }
                this.Capacity = minimumCapacity;
                this.members = temp;
            }
        }
        /// <summary>
        /// Adds an element into the container, making sure the capacity can hold it.
        /// </summary>
        /// <param name="member">Element to add to container</param>
        public void Add(Member member)
        {
            if (this.Count == this.Capacity) //container is full 
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.members[this.Count++] = member;
        }
        /// <summary>
        /// Takes an element from the container at a given position.
        /// </summary>
        /// <param name="index">Given position</param>
        /// <returns>Element from wanter position</returns>
        public Member Get(int index)
        {
            return this.members[index];
        }
        public bool Contains(Member member)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.members[i].Equals(member))
                {
                    return true;
                }
            }
            return false;
        }
        public void Put(Member member, int index)
        {
            this.members[index] = member;
        }
        public void Insert(Member member, int index)
        {
            if (this.Count == this.Capacity) //container is full 
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.Count++;
            for (int i = Count; i > index; i--)
            {
                this.members[i] = this.members[i - 1];
            }
            this.members[index] = member;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                this.members[i] = this.members[i + 1];
            }
            this.Count--;
        }
        /// <summary>
        /// Removes elements from container that match given parameter.
        /// </summary>
        /// <param name="member"></param>
        public void Remove(Member member)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.members[i].Equals(member))
                {
                    for (int j = i; j < Count - 1; j++)
                        this.members[j] = this.members[j + 1];
                    i--;
                    this.Count--;
                }
            }
        }
        /// <summary>
        /// Selection sort
        /// </summary>
        public void Sort(MembersComparator comparator)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < this.Count - 1; i++)
                {
                    Member a = this.members[i];
                    Member b = this.members[i + 1];
                    if (comparator.Compare(a, b) > 0)
                    {
                        this.members[i] = b;
                        this.members[i + 1] = a;
                        flag = true;
                    }
                }
            }
        }
    }
}
