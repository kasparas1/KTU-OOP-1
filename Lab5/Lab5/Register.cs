using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Class Register is used to hold information of Members'camps and do calculations regarding said Members'camps.
    /// </summary>
    class Register
    {
        /// <summary>
        /// Which year did spesific camp take place
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Camps opening date
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Camps closing date
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Defines a private List, that will be used within this class.
        /// </summary>
        private Container all;
        /// <summary>
        /// Used to create a new list.
        /// </summary>
        public Register()
        {
            all = new Container();
        }
        /// <summary>
        /// Adds Members and its information to the container.
        /// </summary>
        /// <param name="members">Register of members (which holds the container)</param>
        public Register(Container members)
        {
            all = new Container();
            for (int i = 0; i < all.Count; i++)
            {
                this.all.Add(members.Get(i));
            }
        }
        /// <summary>
        /// Filters players who are attackers
        /// </summary>
        /// <param name="player"></param>
        /// <returns>Attackers</returns>
        public Register Attacker(Register player)
        {
            for (int i = 0; i < this.all.Count; i++)
            {
                Member member = this.all.Get(i);
                if (member is Player && (member as Player).Position == "Puolėjas")
                    player.Add(member);
            }
            return player;
        }
        /// <summary>
        /// Filters staff members who are coaches
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>Coaches</returns>
        public Register IsCoach(Register staff)
        {
            for (int i = 0; i < this.all.Count; i++)
            {
                Member member = this.all.Get(i);
                if (member is Staff && (member as Staff).StaffPosition == "vyr. treneris")
                    staff.Add(member);
            }
            return staff;
        }
        /// <summary>
        /// Filters players who are invited
        /// </summary>
        /// <param name="player"></param>
        /// <returns>invited players</returns>
        public Register PlayerIsInvited(Register player)
        {
            for (int i = 0; i < this.all.Count; i++)
            {
                Member member = this.all.Get(i);
                if (member is Player && (member as Player).Invited == true)
                    player.Add(member);
            }
            return player;
        }
        public void Add(Member member)
        {
            all.Add(member);
        }
        public Member GetMember(int index)
        {
            return all.Get(index);
        }
        public int ACount()
        {
            return this.all.Count;
        }
        public void Sort(MembersComparator yes)
        {
            all.Sort(yes);
        }
    }
}
