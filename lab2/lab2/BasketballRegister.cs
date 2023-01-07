using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    /// <summary>
    /// Class Register is used to hold information of Players'camps and do calculations regarding said Players'camps.
    /// </summary>
    class BasketballRegister
    {
        /// <summary>
        /// Defines a private List, that will be used within this class.
        /// </summary>
        private List<Basketball> AllBasketball;
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
            AllBasketball = new List<Basketball>();
        }
        /// <summary>
        /// Adds players and its information to the list.
        /// </summary>
        /// <param name="Basketball"></param>
        public BasketballRegister(List<Basketball> Basketball)
        {
            AllBasketball = new List<Basketball>();
            foreach (Basketball basketball in Basketball)
            {
                this.AllBasketball.Add(basketball);
            }
        }
        /// <summary>
        /// Adds a single Player and his information to the list.
        /// </summary>
        /// <param name="basketball"></param>
        public void Add(Basketball basketball)
        {
            AllBasketball.Add(basketball);
        }
        /// <summary>
        /// Finds the player in the list AllBasketball at a wanted position.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Returns the player from the list</returns>
        public Basketball GetBasketball(int index)
        {
            return AllBasketball[index];
        }
        /// <summary>
        /// Finds how many elements are in the list AllBasketball
        /// </summary>
        /// <returns>A number of elemens in the list</returns>
        public int BasketballCount()
        {
            return this.AllBasketball.Count;
        }
  
        /// <summary>
        /// Finds tallest player
        /// </summary>
        /// <param name="Tallest">tallest player</param>
        /// <returns> return tallest player</returns>
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
        /// <returns>returns players who are same height as tallest player</returns>
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
        /// <returns>returns invited players</returns>
        public BasketballRegister FindInvited(BasketballRegister Basketball)
        {
            for (int i = 0; i < BasketballCount(); i++)
                if (GetBasketball(i).Invited == true)
                    Basketball.Add(GetBasketball(i));
            return Basketball;
        }
    }
}
