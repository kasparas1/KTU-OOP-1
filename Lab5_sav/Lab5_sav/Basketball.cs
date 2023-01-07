using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_sav
{
    internal class Basketball : Player
    {
        public int ReboundNumber { get; set; }
        public int PassNumbers { get; set; }
        public Basketball(string teamName, string name, string lastName, DateTime birthDate, int playedGames, int score, int reboundNumber, int passNumbers) : base(teamName, name, lastName, birthDate, playedGames, score)
        {
            this.ReboundNumber = reboundNumber;
            this.PassNumbers = passNumbers;
        }
    }
}
