using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Saves all data that is required to define both Player and Staff member
    /// </summary>
    public abstract class Member
    {
        /// <summary>
        /// Name of member
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Last name of member
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Birth date of member
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Member's constructor
        /// </summary>
        /// <param name="name">Name of member</param>
        /// <param name="lastName">Last name of member</param>
        /// <param name="birthDate">Birthdate of member</param>
        public Member(string name, string lastName, DateTime birthDate)
        {
            this.Name = name;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }
        /// <summary>
        /// Calculates age
        /// </summary>
        /// <returns>age</returns>
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.BirthDate.Year;
            if (this.BirthDate.Date > today.AddYears(-age))
                age--;
            return age;
        }
        public int CompareTo(Member other)
        {
            int result = this.CalculateAge().CompareTo(other.CalculateAge());
            if (result == 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            return result;
        }
    }
}
