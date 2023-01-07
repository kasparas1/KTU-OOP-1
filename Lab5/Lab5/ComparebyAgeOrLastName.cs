using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{ 
        /// <summary>
        /// class to compare by age or last name
        /// </summary>
        class ComparebyAgeOrLastName : MembersComparator
        {
            /// <summary>
            /// Compares
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public override int Compare(Member a, Member b)
            {
                return a.CalculateAge().CompareTo(b.CalculateAge());
            }
        }
}
