
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab1
{
    /// <summary>
    /// Class used for Reading and printing data.
    /// </summary>
    class ReadingnPrinting
    {
        /// <summary>
        /// Reads data from Date.csv and assigns them to their variables
        /// </summary>
        /// <param name="Date">List of data that was orgonized</param>
        /// <param name="fileName">Unorgonized data</param>
        /// <returns>Orgonzied data</returns>
        public static List<Basketball> ReadDate(List<Basketball> Date, string fileName)
        {
            
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach (string line in Lines)
            {
                string[] Values = line.Split(';');
                string name = Values[0];
                string lastname = Values[1];
                DateTime birthDate = DateTime.Parse(Values[2]);
                int height = int.Parse(Values[3]);
                string position = Values[4];
                string invitedTest = Values[5];
                bool invited = bool.Parse(Values[5]);
                bool captain = bool.Parse(Values[6]);
                Basketball basketball = new Basketball(name, lastname, birthDate, height, position, invited, captain);
                Date.Add(basketball);
            }
            return Date;
        }
        /// <summary>
        /// Prints a chart of players and their data to console
        /// </summary>
        /// <param name="Date">Orgonized data</param>
        public static void PrintPlayers(List<Basketball>Date)
        {
            Console.WriteLine(new string('-', 105));
            Console.WriteLine("| {0,10} | {1,-17} | {2, -10} | {3, -12} | {4,-8} | {5,-12} | {6,-12} |", "Vardas", "Pavarde", "Gimimo data", "Ugis", "Pozicija", "Ar pakviestas", "Ar kapitonas");
            Console.WriteLine(new string('-', 105));
            string captainTest, IsInvited;
            foreach (Basketball basketball in Date)
            {
                Console.Write("| {0,10} | {1,-17} | {2,-11:yyyy-MM-dd} | {3,-8} cm. | {4,-8} |", basketball.Name, basketball.LastName, basketball.BirthDate, basketball.Height, basketball.Position);
                if (basketball.Invited == true)
                    IsInvited = "Taip";
                else
                    IsInvited = "Ne";
                if (basketball.Captain == true)
                    captainTest = "Taip";
                else
                    captainTest = "Ne";
                Console.Write(" {0,-13} | {1,-12} |", IsInvited, captainTest);
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 105));
        }
        /// <summary>
        /// Prints a chart of oldest player/players to console
        /// </summary>
        /// <param name="Date">Filtred data by whos oldest</param>
        public static void PrintOldest(List<Basketball> Date)        
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("| {0,-15} | {1,-15} | {2,-10} | ", "Vardas", "Pavarde", "Amzius");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < Date.Count; i++)
                Console.WriteLine("| {0,-15} | {1,-15} | {2,-10} |", Date[i].Name, Date[i].LastName, Date[i].CalculateAge());
            Console.WriteLine(new string('-', 50));
        }
        /// <summary>
        /// Prints a chart of players who are attackers to console
        /// </summary>
        /// <param name="Date">Data of positions</param>
        public static void PrintPositions(List<Basketball> Date)
        {
            Console.WriteLine(new string('-', 48));
            Console.WriteLine("| {0,10} | {1,-17} | {2, -11} |", "Vardas", "Pavarde", "Ugis");
            Console.WriteLine(new string('-', 48));
            foreach (Basketball basketball in Date)
                Console.WriteLine("| {0,10} | {1,-17} | {2,-8} cm.|", basketball.Name, basketball.LastName, basketball.Height);
            Console.WriteLine(new string('-', 48));
        }
        /// <summary>
        /// Prints all players who were invited to Invite.csv file
        /// </summary>
        /// <param name="fileName">Name of file in which will be printed invited</param>
        /// <param name="Date">filtered data of whos invited</param>
        public static void PrintInvited(string fileName, List<Basketball> Date)
        {
            string[] lines = new string[Date.Count + 1];
            lines[0] = String.Format("{0};{1};{2};{3};{4};{5};{6}", "Vardas", "Pavarde", "Gimimo data", "Ugis", "Pozicija", "Ar pakviestas", "Ar kapitonas");
            for (int i = 0; i < Date.Count; i++)
            {
                lines[i + 1] = String.Format("{0};{1};{2:};{3};{4};{5};{6}", Date[i].Name, Date[i].LastName, Date[i].BirthDate, Date[i].Height, Date[i].Position, Date[i].Invited, Date[i].Captain);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
        
    }
}
