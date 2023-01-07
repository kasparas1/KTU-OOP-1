using System;
using System.Collections.Generic;


namespace Lab1
{
    /// <summary>
    /// a main class 
    /// </summary>
    class Program
    {
        /// <summary>
        /// reads data from file and prints text to either console or to file
        /// </summary>
        static void Main(string[] args)
        {
            List<Basketball> allDate = ReadingnPrinting.ReadDate(@"Date.csv"); // reads data from Date.csv file
            ReadingnPrinting.PrintPlayers(allDate); //prints PrintPlayrs method to console
            Basketball oldest = Tasks.FindOldestPlayer(allDate); // defines variable oldest
            Console.WriteLine();
            List<Basketball> FilterOldest = Tasks.FilterOldest(allDate);
            Console.WriteLine("Seniausias Zaidejas");
            ReadingnPrinting.PrintOldest(FilterOldest);
            // prints PrintOldest method to console
            string selectedPosition = "Puolėjas";
            Console.WriteLine();
            Console.WriteLine("Puolėjai:");
            List<Basketball> FilterByPosition = Tasks.FilterByPosition(allDate, selectedPosition); // defines FilterByPosition
            ReadingnPrinting.PrintPositions(FilterByPosition); // prints PrintPositions method to console
            List<Basketball> FilterByInvitation = Tasks.FilterByInvitation(allDate); // defines FilterByInvitation
            string fileName =  "Invited.csv"; //file name for printing results
            ReadingnPrinting.PrintInvited(fileName, FilterByInvitation); // prints PrintInvited method to file
        }
    }
}
