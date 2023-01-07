using System;
using System.Collections.Generic;


namespace Lab1
{
    /// <summary>
    /// A class for completing diffrent tasks
    /// </summary>
    class Tasks
    {
        /// <summary>
        /// Finds oldest player birthdate
        /// </summary>
        public static Basketball FindOldestPlayer(List<Basketball> Date)
        {
  
             
            List<DateTime> Ages = new List<DateTime>();
            Basketball oldest = Date[0]; // means least value
            for (int i = 1; i < Date.Count; i++)
            {
                if (DateTime.Compare(Date[i].BirthDate, oldest.BirthDate) < 0)
                    oldest = Date[i]; 
            }
            
            return oldest;
        }
        /// <summary>
        /// Filters players by position
        /// </summary>
        public static List<Basketball> FilterByPosition(List<Basketball> Date, string position)
        {
            List<Basketball> Filtered = new List<Basketball>();
            foreach (Basketball basketball in Date)
            {
                if (basketball.Position.Equals(position)) 
                {
                    Filtered.Add(basketball);
                }
            }
            return Filtered;
        }
        /// <summary>
        /// finds players who are invited
        /// </summary>
        public static List<Basketball> FilterByInvitation(List<Basketball> Date)
        {
            List<Basketball> Filtered = new List<Basketball>();
            foreach (Basketball basketball in Date)
            {
                if (basketball.Invited == true) // uses string method Equals()
                {
                    Filtered.Add(basketball);
                }
            }
            return Filtered;
        }
        public static List<Basketball> FilterOldest(List<Basketball> Date)
        {
             Basketball oldest = Tasks.FindOldestPlayer(Date);
             List<Basketball> Filtered = new List<Basketball>();
             foreach (Basketball basketball in Date)
                 if (oldest.CalculateAge() == basketball.CalculateAge())
                     Filtered.Add(basketball);
             return Filtered;
         }
    }
}
