using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Badges_Repository
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public string DoorName { get; set; }
        private Dictionary<int, Badge> doorBadge = new Dictionary<int, Badge>();
        public Badge() { }
        public Badge(int id,string doorName,Dictionary<int,Badge> lsitOfBadge)
        {
            BadgeID = id;
            DoorName = doorName;
            doorBadge = lsitOfBadge;

        }
    }
}
