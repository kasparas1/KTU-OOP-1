using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Saves all data that is required to define staff member
    /// </summary>
    public class Staff : Member
    {
        /// <summary>
        /// Which position in team does staff member hold(medic, coach, etc.)
        /// </summary>
        public string StaffPosition { get; set; }
        /// <summary>
        /// Staff member's constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="staffPosition">Which position in team does staff member hold</param>
        public Staff(string name, string lastName, DateTime birthDate, string staffPosition) : base(name, lastName, birthDate)
        {
            this.StaffPosition = staffPosition;
        }
        /// <summary>
        /// /// <summary>
        /// Overrides ToString to make PrintPlayers method in InOutUtils easier to read. (without Invited and Captain)
        /// </summary>
        /// <returns> information about player</returns>
        /// </summary>
        public override string ToString()
        {
            return string.Format("| {0,10} | {1,-17} | {2,-12:yyyy-MM-dd} | {3,-12} | {4,-8} | {5,-10} | {6,-13} | {7,-13} |", Name, LastName, BirthDate, StaffPosition, "-", "-", "-", "-");
        }
    }
}
