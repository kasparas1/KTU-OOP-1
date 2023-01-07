using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_sav
{
    internal class Football : Player
    {
        public int NumberOfYellowCards { get; set; }
        public Football (string teamName, string name, string lastName, DateTime birthDate, int playedGames, int score, int numberOfYellowCards) : base(teamName, name, lastName, birthDate, playedGames, score)
        {
            this.NumberOfYellowCards = numberOfYellowCards;
        }
    }
}
