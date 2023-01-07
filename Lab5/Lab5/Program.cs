///IF-1/1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Main Class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Register register = ReadingNPrinting.ReadMembers(@"Data.csv");
            Register register2 = ReadingNPrinting.ReadMembers(@"Data2.csv");
            Register register3 = ReadingNPrinting.ReadMembers(@"Data3.csv");
            ReadingNPrinting.PrintMembers("members",register);
            ReadingNPrinting.PrintMembers("members", register2);
            ReadingNPrinting.PrintMembers("members", register3);

            Register Attacker = new Register();
            Register Coach = new Register();
            Register Invited = new Register();

            Attacker = register.Attacker(Attacker);
            Attacker = register2.Attacker(Attacker);
            Attacker = register3.Attacker(Attacker);

            Coach = register.IsCoach(Coach);
            Coach = register2.IsCoach(Coach);
            Coach = register3.IsCoach(Coach);

            Invited = register.PlayerIsInvited(Invited);
            Invited = register2.PlayerIsInvited(Invited);
            Invited = register3.PlayerIsInvited(Invited);

            Console.WriteLine("Puolejai");
            ReadingNPrinting.PrintAttackersAndCoach(Attacker);
            Console.WriteLine("Vyr. treneriai");
            ReadingNPrinting.PrintAttackersAndCoach(Coach);
            ReadingNPrinting.PrintInvitedToCSVFile("Rinktinė.csv", Invited);
            register.Sort(new ComparebyAgeOrLastName());
            register2.Sort(new ComparebyAgeOrLastName());
            register3.Sort(new ComparebyAgeOrLastName());
            ReadingNPrinting.PrintMembers("members", register);
            ReadingNPrinting.PrintMembers("members", register2);
            ReadingNPrinting.PrintMembers("members", register3);
        }
    }
}
