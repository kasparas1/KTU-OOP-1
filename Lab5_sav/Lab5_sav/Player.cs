using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_sav
{
    internal class Player
    {
        public string TeamName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PlayedGames { get; set; }
        public int Score { get; set; }
        public Player(string teamName, string name, string lastName, DateTime birthDate, int playedGames, int score)
        {
            TeamName = teamName;
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            PlayedGames = playedGames;
            Score = score;
        }
    }
}
