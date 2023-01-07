using System;
using System.Collections.Generic;


namespace Lab1
{
    /// <summary>
    /// A class for basketball data type
    /// </summary>
    class Basketball
    {
        public string Name { get; set; } // creates attribute for name
        public string LastName { get; set; } // creates attribute for last name
        public DateTime BirthDate { get; set; } // creates attribute for date of birth
        public int Height { get; set; } // creates attribute for height(centimeters)
        public string Position { get; set; } // creates attribute for position
        public bool Invited { get; set; } // creates attribute for checking if player was invited (true or false)
        public bool Captain { get; set; } // creates attribute for checking if player is a captain (true or false)

        /// <summary>
        /// a class for creating constructors 
        /// </summary>
        /// <param name="name">first name of players</param>
        /// <param name="lastname">last name of players</param>
        /// <param name="birthDate">birthdates of players</param>
        /// <param name="height">height of players</param>
        /// <param name="position">positions of players</param>
        /// <param name="invited">are players invited to leuge?</param>
        /// <param name="captain">is player a captain</param>
        public Basketball(string name, string lastname, DateTime birthDate, int height, string position, bool invited, bool captain)
        {
            this.Name = name;
            this.LastName = lastname;
            this.BirthDate = birthDate;
            this.Height = height;
            this.Position = position;
            this.Invited = invited;
            this.Captain = captain;
        }
        /// <summary>
        /// a class for calculating age from date of birth
        /// </summary>
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.BirthDate.Year;
            if (this.BirthDate.Date > today.AddYears(-age))
                age--;
            return age;

        }
    }
}
