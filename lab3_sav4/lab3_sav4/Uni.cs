using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sav4
{
    class Uni
    {
        public string Faculty { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int GradeNO { get; set; }
        public int Grade { get; set; }
        
        public Uni(string faculty, string lastName, string name, string group, int groupNO, int grade)
        {
            this.Faculty = faculty;
            this.LastName = lastName;
            this.Name = name;
            this.Group = group;
            this.GradeNO = GradeNO;
            this.Grade = grade;
        }
        public override string ToString()
        {

            string line;
            line = String.Format("| {0,10} | {1,-17} | {2,-11:yyyy-MM-dd} | {3,-8} cm. | {4,-8} | {5, -8} |", this.Faculty, this.LastName, this.Name, this.Group, this.GradeNO, this.Grade);
            return line;
        }
    }
}
