using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Compares members
    /// </summary>
    class MembersComparator
    {
        /// <summary>
        /// Compares
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int Compare(Member a, Member b)
        {
            return a.CompareTo(b);
        }
    }
}
