using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_sav
{
    class Register
    {
        private List<Teams> allTeams;
        public Register()
        {
            allTeams = new List<Teams>();
        }
        public Register(List<Teams> initialTeams)
        {
            allTeams = new List<Teams>();
            foreach(Teams team in initialTeams)
            {
                Add(team);
            }
        }
        public void Add(Teams team)
        {
            allTeams.Add(team);
        }
        public Teams Get(int index)
        {
            return allTeams[index];
        }

        public int Count()
        {
            return allTeams.Count;
        }
        public Register FilterByCity(string city)
        {
            List<Teams> filtered = new List<Teams>();
            foreach(var team in allTeams)
                if(team.City == city)
                    filtered.Add(team);
            return new Register(filtered);
        }
        public List<Player> FilteredPlayers()
        {
            List<Player> Players = new List<Player> ();
            foreach(var team in allTeams)
            {
                float avrageScore = team.GetAvrage();
                foreach (var player in team.Players)
                    if (team.PlayedGames <= player.PlayedGames && player.Score >= avrageScore)
                        Players.Add(player);
            }
            return Players;
        }
    }
}
