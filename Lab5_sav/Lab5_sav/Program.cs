using System;
using System.Collections.Generic;

namespace Lab5_sav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teams> Team = ReadingAndPrinting.ReadTeams("Teams.csv", "Players.csv");
            Register register = new Register(Team);
            Console.WriteLine("Iveskite norima miesta: ");
            string city = Console.ReadLine();
            List<Player> Players = register.FilterByCity(city).FilteredPlayers();
            ReadingAndPrinting.PrintPlayers(Players);
        }
    }
}
