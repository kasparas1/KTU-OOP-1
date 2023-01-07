using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_sav
{
    class PlayerContainer
    {
        private Player[] Players;
        public int Count { get; set; }
        public int Capacity;
        public PlayerContainer()
        {
            Players = new Player[16];
        }
        public PlayerContainer(int capacity = 4)
        {
            this.Capacity = capacity;
            this.Players = new Player[capacity];
        }
        private void EnsureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Player[] temp = new Player[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.Players[i];
                }
                this.Capacity = minimumCapacity;
                this.Players = temp;
            }
        }
        public void Add(Player player)
        {
            if (this.Count == this.Capacity) 
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.Players[this.Count++] = player;
        }
        public Player Get(int index)
        {
            return this.Players[index];
        }
        public bool Contains(Player player)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Players[i].Equals(player))
                {
                    return true;
                }
            }
            return false;
        }
        public void Put(Player player, int index)
        {
            this.Players[index] = player;
        }
        public void Insert(Player player, int index)
        {
            if (this.Count == this.Capacity)  
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.Count++;
            for (int i = Count; i > index; i--)
            {
                this.Players[i] = this.Players[i - 1];
            }
            this.Players[index] = player;
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                this.Players[i] = this.Players[i + 1];
            }
            this.Count--;
        }
        public void Remove(Player player)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.Players[i].Equals(player))
                {
                    for (int j = i; j < Count - 1; j++)
                        this.Players[j] = this.Players[j + 1];
                    i--;
                    this.Count--;
                }
            }
        }
    }
}
