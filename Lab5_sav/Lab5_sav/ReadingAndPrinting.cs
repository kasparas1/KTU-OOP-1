using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5_sav
{
    class ReadingAndPrinting
    {
        public static List<Player> FilterPlayersByTeam(List<Player> players, string team)
        {
            List<Player> filtered = new List<Player>();
            foreach(var player in players)
                if(player.TeamName == team)
                    filtered.Add(player);
            return filtered;
        }
        public static List<Player> ReadPlayers(string fileName)
        {
            List<Player> players = new List<Player>();
            string[] Lines = File.ReadAllLines(fileName);
            foreach (string line in Lines)
            {
                string[] parts = line.Split(';');
                string TeamName = parts[0];
                string Name = parts[1];
                string LastName = parts[2];
                DateTime BirthDate = DateTime.Parse(parts[3]);
                int PlayedGames = int.Parse(parts[4]);
                int Score = int.Parse(parts[5]);
                Player player;
                if (parts.Length == 8)
                {
                    int ReboundNumber = int.Parse(parts[6]);
                    int PassNumbers = int.Parse(parts[7]);
                    player = new Basketball(TeamName, Name, LastName, BirthDate, PlayedGames, Score, ReboundNumber, PassNumbers);
                }
                else if (parts.Length == 7)
                {
                    int NumberOfYellowCards = int.Parse(parts[6]);
                    player = new Football(TeamName, Name, LastName, BirthDate, PlayedGames, Score, NumberOfYellowCards);
                }
                else
                {
                    throw new Exception($"Expected basketball or football player: {line}");
                }
                players.Add(player);
            }
            return players;
        }
        public static List<Teams> ReadTeams(string fileName, string fileName2)
        {
            List<Teams> teams = new List<Teams>();
            List<Player> allPlayers = ReadPlayers(fileName2);
            string[] Lines = File.ReadAllLines(fileName);
            foreach(string line in Lines)
            {
                string[] parts = line.Split(';');
                string Team = parts[0];
                string City = parts[1];
                string Coach = parts[2];
                int PlayedGames = int.Parse(parts[3]);
                List<Player> Players = FilterPlayersByTeam(allPlayers, Team);
                Teams team = new Teams(Team, City, Coach, PlayedGames, Players);
                teams.Add(team);
            }
            return teams;
        }
        public static void PrintPlayers(List<Player> players)
        {
            Console.WriteLine(new string('-', 93));
            Console.WriteLine("| {0,-15} | {1,-12} | {2,-12} | {3} | {4} | {5} |", "Team name", "Name", "Surname", "Birth date", "Games played", "Points scored");
            Console.WriteLine(new string('-', 93));
            foreach (Player player in players)
                Console.WriteLine("| {0,-15} | {1,-12} | {2,-12} | {3:yyyy-MM-dd} | {4,12} | {5,13} |", player.TeamName, player.Name, player.LastName, player.BirthDate, player.PlayedGames, player.Score);
            Console.WriteLine(new string('-', 93));
        }
    }
}
