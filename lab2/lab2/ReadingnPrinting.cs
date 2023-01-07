using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace lab2
{
    /// <summary>
    /// Class for reading and printing data
    /// </summary>
    class ReadingnPrinting
    {
        /// <summary>
        /// Reads the data from file
        /// </summary>
        /// <param name="fileName">String which contains unorgonized Data</param>
        /// <returns> information about players</returns>
           public static BasketballRegister ReadDate(string fileName)
           {
            BasketballRegister Basketball = new BasketballRegister();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);

            Basketball.Year = int.Parse(Lines[0]);
            Basketball.StartDate = DateTime.Parse(Lines[1]);
            Basketball.EndDate = DateTime.Parse(Lines[2]);

            foreach(string line in Lines)
            {
                if (line.Contains(";")) 
                {
                    string[] Values = line.Split(';');
                    string name = Values[0];
                    string lastname = Values[1];
                    DateTime birthDate = DateTime.Parse(Values[2]);
                    int height = int.Parse(Values[3]);
                    string position = Values[4];
                    string club = Values[5];
                    bool invited = bool.Parse(Values[6]);
                    bool captain = bool.Parse(Values[7]);
                    Basketball basketball = new Basketball(name, lastname, birthDate, height, position, club, invited, captain);
                    Basketball.Add(basketball);
                }
            }
            return Basketball;
        }
        /// <summary>
        /// prints players' information in console
        /// </summary>
        /// <param name="register">Container with data</param>
        public static void PrintPlayers(BasketballRegister register)
        {
            Console.WriteLine(new string('-', 54));
            Console.WriteLine("| {0,-10} | {1,-10} | {2,-10} |", "Metai", "Stovyklos pradzia", "stovyklos pabaiga");
            Console.WriteLine(new string('-', 54));
            Console.WriteLine("| {0, 10} | {1, 17:yyyy-MM-dd} | {2, 17:yyyy-MM-dd} |", register.Year, register.StartDate, register.EndDate);
            Console.WriteLine(new string('-', 54));
            Console.WriteLine(new string('-', 116));
            Console.WriteLine("| {0,10} | {1,-17} | {2, -10} | {3, -12} | {4,-8} | {5,-8} | {6,-12} | {7,-12} |", "Vardas", "Pavarde", "Gimimo data", "Ugis", "Pozicija", "Klubas", "Ar pakviestas", "Ar kapitonas");
            Console.WriteLine(new string('-', 116));
            string captainTest, IsInvited;
            for (int i = 0; i < register.BasketballCount(); i++)
            {
                Basketball basketball = register.GetBasketball(i);
                Console.Write(register.GetBasketball(i).ToString());
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
            Console.WriteLine(new string('-', 116));
        }
        /// <summary>
        /// Creates .txt file and if there are data, it deletes it
        /// </summary>
        /// <param name="fileName"></param>
        public static void CreateTXTFile(string fileName)
        {
            if (new FileInfo(fileName).Length > 0)
            {
                File.WriteAllText(fileName, string.Empty);
            }
        }
        /// <summary>
        /// Same as PrintPlayers but prints to .txt file
        /// </summary>
        /// <param name="fileName">Name of the export file</param>
        /// <param name="Basketball">Constructor with orgonized data</param>
        public static void PrintDateToTXT(string fileName, BasketballRegister Basketball)
        {

            string[] lines = new string[Basketball.BasketballCount() + 7];
            lines[0] = String.Format("Metai", Basketball.Year);
            lines[1] = String.Format("Stovyklos Pradzia", Basketball.StartDate);
            lines[2] = String.Format("Stovyklos pabaiga", Basketball.EndDate);

            lines[3] = String.Format(new string('-', 116));
            lines[4] = String.Format("| {0,10} | {1,-17} | {2, -10} | {3, -12} | {4,-8} | {5,-8} | {6,-14} | {7,-12} |", "Vardas", "Pavarde", "Gimimo data", "Ugis", "Pozicija", "Klubas", "Ar pakviestas", "Ar kapitonas");
            lines[5] = String.Format(new string('-', 116));
            for (int i = 0; i < Basketball.BasketballCount(); i++)
            {
                lines[i + 6] = String.Format(Basketball.GetBasketball(i).ToStringTwo());
            }
            lines[Basketball.BasketballCount() + 6] = String.Format(new string('-', 116));
            File.AppendAllLines(fileName, lines, Encoding.UTF8);
        }
        /// <summary>
        /// Prints tallest person if there are multiple people with same height, it prints all of them
        /// </summary>
        /// <param name="register"></param>
        public static void PrintTallest(BasketballRegister register)
        {
            Console.WriteLine(new string('-', 45));
            Console.WriteLine("| {0,10} | {1,-17} | {2, -8} |", "Vardas", "Pavarde", "Amzius");
            Console.WriteLine(new string('-', 45));
            for (int i = 0; i < register.BasketballCount(); i++)
            {
                Basketball basketball = register.GetBasketball(i);
                Console.WriteLine("| {0,10} | {1,-17} | {2,8} |", basketball.Name, basketball.LastName, basketball.CalculateAge());
            }
            Console.WriteLine(new string('-', 45));

        }
        /// <summary>
        /// Prints Clubs with invited people to .csv file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="register">data container with only inveted and clubs data</param>
        public static void PrintClubsToCSV(string fileName, BasketballRegister register)
        {
            string[] lines = new string[register.BasketballCount() + 1];
            for (int i = 0; i < register.BasketballCount(); i++)
            {
                Basketball basketball = register.GetBasketball(i);
                lines[i] = basketball.Club;
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }

    }
}
