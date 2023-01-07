using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_sav
{
    internal class Teams
    {
        public string Team { get; set; }
        public string City { get; set; }
        public string Coach { get; set; }
        public int PlayedGames { get; set; }
        public List<Player> Players { get; set; }
        public Teams(string team, string city, string coach, int playedGames, List<Player> players)
        {
            Team = team;
            City = city;
            Coach = coach;
            PlayedGames = playedGames;
            Players = players;
        }
        public int GetPlayerCount()
        {
            int count = 0;
            foreach (Player player in Players)
                count += player.Score;
            return count;
        }
        public float GetAvrage()
        {
            return (float)GetPlayerCount() / Players.Count;
        }
    }
}
