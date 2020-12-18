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
        public List<string> DoorName { get; set; }



       
        public Badge() { }
        public Badge(List<string> doorName)
        {
           // BadgeID = id;
            DoorName = doorName;
        }
    }
}
