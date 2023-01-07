using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Saves all data that is required to define Player
    /// </summary>
    public class Player : Member
    {
        /// <summary>
        /// Players height
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Players Position in team
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Players club
        /// </summary>
        public string Club { get; set; }
        /// <summary>
        /// Is player invited
        /// </summary>
        public bool Invited { get; set; }
        /// <summary>
        /// Is player in club
        /// </summary>
        public bool Captain { get; set; }
        /// <summary>
        /// Player's Constructor
        /// </summary>
        /// <param name="name">name of player</param>
        /// <param name="lastName">last name of player</param>
        /// <param name="birthDate">birtdate of player</param>
        /// <param name="height">players height</param>
        /// <param name="position">players position</param>
        /// <param name="club">players club</param>
        /// <param name="invited">Is player Invited</param>
        /// <param name="captain">Is player a captain</param>
        public Player (string name, string lastName, DateTime birthDate, int height, string position, string club, bool invited, bool captain) : base( name, lastName, birthDate)
        {
            this.Height = height;
            this.Position = position;
            this.Club = club;
            this.Invited = invited;
            this.Captain = captain;
        }
        /// <summary>
        /// Overrides ToString to make PrintPlayers method in InOutUtils easier to read. (without Invited and Captain)
        /// </summary>
        /// <returns> information about player</returns>
        public override string ToString()
        {
            return string.Format("| {0,10} | {1,-17} | {2,-12:yyyy-MM-dd} | {3,-12} | {4,-8} | {5,-10} | {6,-13} | {7,-13} |", Name, LastName, BirthDate, Height, Position, Club, Invited, Captain);
        }
    }
}
