using System;
using System.Collections.Generic;


namespace lab2
{
    /// <summary>
    /// Main Class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /// Code lines that are used for printing data to console or to files
            BasketballRegister register = ReadingnPrinting.ReadDate("Date3.csv");
            BasketballRegister register2 = ReadingnPrinting.ReadDate("Date4.csv");
            ReadingnPrinting.CreateTXTFile("Krepsininkai.txt");
            ReadingnPrinting.PrintDateToTXT("Krepsininkai.txt", register);
            ReadingnPrinting.PrintDateToTXT("Krepsininkai.txt", register2);
            ReadingnPrinting.PrintPlayers(register);
            Console.WriteLine();
            ReadingnPrinting.PrintPlayers(register2);
            Console.WriteLine();
            Console.WriteLine("Auksciausi");
            BasketballRegister FilterByPosition = new BasketballRegister();
            int oneTallest = new int();
            int twoTallest = new int();
            oneTallest = register.TallestPlayer(oneTallest);
            twoTallest = register2.TallestPlayer(twoTallest);
            BasketballRegister Tallest = new BasketballRegister();
            Tallest = register.CheckMultiplePlayers(oneTallest, Tallest);
            Tallest = register.CheckMultiplePlayers(twoTallest, Tallest);
            ReadingnPrinting.PrintTallest(Tallest);
            BasketballRegister Club = new BasketballRegister();
            Club = register.FindInvited(Club);
            Club = register2.FindInvited(Club);
            ReadingnPrinting.PrintClubsToCSV("Klubai.txt", Club);
           
            /// not needed code lines
            /* List<Basketball> FilterOldest = Tasks.FilterOldest(register);
            Console.WriteLine("Seniausias Zaidejas");
            ReadingnPrinting.PrintOldest(FilterOldest);
            string selectedPosition = "Puolėjas";
            Console.WriteLine();
            Console.WriteLine("Puolėjai:");
            List<Basketball> FilterByPosition = Tasks.FilterByPosition(allDate, selectedPosition); 
            ReadingnPrinting.PrintPositions(FilterByPosition);
            List<Basketball> FilterByInvitation = Tasks.FilterByInvitation(allDate); 
            string fileName = "Invited.csv"; 
            ReadingnPrinting.PrintInvited(fileName, FilterByInvitation); 
            */
        }
    }
}
