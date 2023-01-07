using System;
using System.Collections.Generic;


namespace Lab3
{
    /// <summary>
    /// Saves all data that is required to define a Player
    /// </summary>
    class Basketball
    {
        /// <summary>
        /// Name of player
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Last name of player
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Birthdate of player
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Height of player
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Player's position in team 
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Player's club
        /// </summary>
        public string Club { get; set; }
        /// <summary>
        /// Defines if player is Invited
        /// </summary>
        public bool Invited { get; set; }
        /// <summary>
        /// Defines if player is a captain of the team
        /// </summary>
        public bool Captain { get; set; }
        /// <summary>
        /// Player's constructor
        /// </summary>
        /// <param name="name">Name of player</param>
        /// <param name="lastname">Last name of player</param>
        /// <param name="birthDate">Birthdate of player</param>
        /// <param name="height">Height of player</param>
        /// <param name="position">Player's position in team </param>
        /// <param name="club">Player's club</param>
        /// <param name="invited">Defines if player is Invited</param>
        /// <param name="captain">Defines if player is a captain of the team</param>
        public Basketball(string name, string lastname, DateTime birthDate, int height, string position, string club, bool invited, bool captain)
        {
            this.Name = name;
            this.LastName = lastname;
            this.BirthDate = birthDate;
            this.Height = height;
            this.Position = position;
            this.Club = club;
            this.Invited = invited;
            this.Captain = captain;
        }
        /// <summary>
        /// Calculates age
        /// </summary>
        /// <returns> age </returns>
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.BirthDate.Year;
            if (this.BirthDate.Date > today.AddYears(-age))
                age--;
            return age;
        }
        /// <summary>
        /// Overrides ToString to make PrintPlayers method in InOutUtils easier to read. (without Invited and Captain)
        /// </summary>
        /// <returns> information about player</returns>
        public override string ToString()
        {

            string line;
            line = String.Format("| {0,10} | {1,-17} | {2,-11:yyyy-MM-dd} | {3,-8} cm. | {4,-8} | {5, -8} |", this.Name, this.LastName, this.BirthDate, this.Height, this.Position, this.Club);
            return line;
        }
        /// <summary>
        /// Overrides ToString to make PrintPlayers method in InOutUtils easier to read. (with Invited and Captain)
        /// </summary>
        /// <returns>information about player</returns>
        public string ToStringTwo()
        {

            string line;
            line = String.Format("| {0,10} | {1,-17} | {2,-11:yyyy-MM-dd} | {3,-8} cm. | {4,-8} | {5, -8} | {6, -15} | {7,-8} |", this.Name, this.LastName, this.BirthDate, this.Height, this.Position, this.Club, this.Invited, this.Captain);
            return line;
        }
        public static bool operator ==(Basketball first, Basketball second)
        {
            return (first.Name == second.Name && first.LastName == second.LastName && first.BirthDate == second.BirthDate && first.Height == second.Height &&
                    first.Position == second.Position && first.Club == second.Club && first.Invited == second.Invited);
        }
        public static bool operator !=(Basketball first, Basketball second)
        {
            return !(first.Name == second.Name && first.LastName == second.LastName && first.BirthDate == second.BirthDate && first.Height == second.Height && first.Position == second.Position && first.Club == second.Club && first.Invited == second.Invited);
        }
        public int CompareTo(Basketball other)
        {
            int num;

            num = this.Height.CompareTo(other.Height);
            if (this.Height == other.Height)
            {
                num = this.LastName.CompareTo(other.LastName);
            }
            if (this.Height == other.Height && this.Height == other.Height)
            {
                num = this.Name.CompareTo(other.Name);
            }

            return num;

        }

    }
}
