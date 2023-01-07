using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5
{
    /// <summary>
    /// Reading and printing class
    /// </summary>
    class ReadingNPrinting
    {
        /// <summary>
        /// Reads data from .csv file
        /// </summary>
        /// <param name="fileName">.csv file</param>
        /// <returns>information about members</returns>
        public static Register ReadMembers(string fileName)
        {
            Register members = new Register();
            string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
            members.Year = int.Parse(lines[0]);
            members.StartDate = DateTime.Parse(lines[1]);
            members.EndDate = DateTime.Parse(lines[2]);
            foreach (string line in lines)
            {
                if (line.Contains(";"))
                {
                    string[] values = line.Split(';');
                    string type = values[0];
                    string Name = values[1];
                    string LastName = values[2];
                    DateTime BirthDate = DateTime.Parse(values[3]);
                    switch (type)
                    {
                        case "PLAYER":
                            int Height = int.Parse(values[4]);
                            string Position = values[5];
                            string Club = values[6];
                            bool Invited = bool.Parse(values[7]);
                            bool Captain = bool.Parse(values[8]);
                            Player player = new Player(Name, LastName, BirthDate, Height, Position, Club, Invited, Captain);
                            members.Add(player);
                            break;
                        case "STAFF":
                            string StaffPosition = values[4];
                            Staff staff = new Staff(Name, LastName, BirthDate, StaffPosition);
                            members.Add(staff);
                            break;
                    }
                }
            }
            return members;
        }
        /// <summary>
        /// Prints information about members to console
        /// </summary>
        /// <param name="label"></param>
        /// <param name="members">Register of members (which holds the container)</param>
        public static void PrintMembers(string label, Register members)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("| {0,10} | {1,-10:yyyy-MM-dd} | {2,-10:yyyy-MM-dd} |", members.Year, members.StartDate, members.EndDate);
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("| {0,10} | {1,-17} | {2,-12} | {3,-10} | {4,-8} | {5,-11} | {6,-13} | {6,-13} |", "Vardas", "Pavarde", "Gimimo data", "Ugis/Veikla", "Pozicija", "Klubas", "Ar Pakviestas", "Ar kapitonas");
            Console.WriteLine(new string('-', 120));
            for (int i = 0; i < members.ACount(); i++)
                Console.WriteLine(members.GetMember(i));
            Console.WriteLine(new string('-', 120));
        }
        /// <summary>
        /// Prints attackers and coaches 
        /// </summary>
        /// <param name="register">Register of members (which holds the container)</param>
        public static void PrintAttackersAndCoach(Register register)
        {
            Console.WriteLine(new string('-', 34));
            Console.WriteLine("| {0,-10} | {1,-17} | ", "Vardas", "Pavarde");
            Console.WriteLine(new string('-', 34));
            for (int i = 0; i < register.ACount(); i++)
            {
                Member member = register.GetMember(i);
                Console.WriteLine("| {0,10} | {1,-17} |", member.Name, member.LastName);
            }
            Console.WriteLine(new string('-', 34));
        }
        /// <summary>
        /// prints invited players to .csv
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="register"></param>
        public static void PrintInvitedToCSVFile(string fileName, Register register)
        {
            if (new FileInfo(fileName).Length > 0)
            {
                File.WriteAllText(fileName, string.Empty);
            }
            string[] lines = new string[register.ACount() + 7];
            lines[3] = String.Format(new string('-', 116));
            lines[4] = String.Format("| {0,10} | {1,-17} | {2, -10} | {3, -12} | {4,-8} | {5,-8} | {6,-14} | {7,-12} |", "Vardas", "Pavarde", "Gimimo data", "Ugis", "Pozicija", "Klubas", "Ar pakviestas", "Ar kapitonas");
            lines[5] = String.Format(new string('-', 116));
            for (int i = 0; i < register.ACount(); i++)
            {
                lines[i + 6] = String.Format(register.GetMember(i).ToString());
            }
            lines[register.ACount() + 6] = String.Format(new string('-', 116));
            File.AppendAllLines(fileName, lines, Encoding.UTF8);
        }
    }
}
