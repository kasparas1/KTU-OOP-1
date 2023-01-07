using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// Class Register is used to hold information of Players'camps and do calculations regarding said Players'camps.
    /// </summary>
    class BasketballRegister
    {
        /// <summary>
        /// Defines a private List, that will be used within this class.
        /// </summary>
        private BasketballContainer AllBasketball;
        /// <summary>
        /// Information about camp(year, when it started, ended)
        /// </summary>
        public int Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Used to create a new list.
        /// </summary>
        public BasketballRegister()
        {
            AllBasketball = new BasketballContainer();
        }
        /// <summary>
        /// Adds cars and its information to the container.
        /// </summary>
        /// <param name="Basketball">Register of players (which holds the container)</param>
        public BasketballRegister(BasketballContainer Basketball)
        {
            AllBasketball = new BasketballContainer();
            for (int i = 0; i < Basketball.Count; i++)
            {
                this.AllBasketball.Add(Basketball.Get(i));
            }
        }
        /// <summary>
        /// Adds a single Player and his information to the container.
        /// </summary>
        /// <param name="basketball">Ellement to add</param>
        public void Add(Basketball basketball)
        {
            AllBasketball.Add(basketball);
        }
        /// <summary>
        /// Finds a car in the container AllCars at a wanted position.
        /// </summary>
        /// <param name="index">wanted position</param>
        /// <returns>Returns the player from the list</returns>
        public Basketball GetBasketball(int index)
        {
            return AllBasketball.Get(index);
        }
        /// <summary>
        /// Finds how many elements are in the container
        /// </summary>
        /// <returns>A number of elemens in the container </returns>
        public int BasketballCount()
        {
            return this.AllBasketball.Count;
        }
        /// <summary>
        /// calls container to sort AllBasketball
        /// </summary>
        public void Sort()
        {
            this.AllBasketball.Sort();
        }
        /// <summary>
        /// Finds tallest player
        /// </summary>
        /// <param name="Tallest">tallest player</param>
        /// <returns> return container tallest player</returns>
        public int TallestPlayer(int Tallest)
        {
            for (int i = 0; i < BasketballCount(); i++)
                if (Tallest < GetBasketball(i).Height)
                    Tallest = GetBasketball(i).Height;
            return Tallest;
        }
        /// <summary>
        /// Checcks all list for players with same height
        /// </summary>
        /// <param name="Tallest"></param>
        /// <param name="Basketball"></param>
        /// <returns>returns container of players who are same height as tallest player</returns>
        public BasketballRegister CheckMultiplePlayers(int Tallest, BasketballRegister Basketball)
        {
            for (int i = 0; i < BasketballCount(); i++)
                if (Tallest == GetBasketball(i).Height)
                    Basketball.Add(GetBasketball(i));
            return Basketball;
        }
        /// <summary>
        /// Finds players who were invited
        /// </summary>
        /// <param name="Basketball"></param>
        /// <returns>returns container of invited players</returns>
        public BasketballRegister FindInvited(BasketballRegister Basketball)
        {
            for (int i = 0; i < BasketballCount(); i++)
                if (GetBasketball(i).Invited == true)
                    Basketball.Add(GetBasketball(i));
            return Basketball;
        }
        /// <summary>
        /// Finds the attackers
        /// </summary>
        /// <param name="Basketball"></param>
        /// <returns>Returns container of players who are invted</returns>
        public BasketballRegister FindAttacker(BasketballRegister Basketball)
        {
            for(int i = 0; i < BasketballCount(); i++)
                if (GetBasketball(i).Position == "Puolėjas")
                    Basketball.Add(GetBasketball(i));
            return Basketball;
        }
    }
}
