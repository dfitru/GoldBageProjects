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

        public Dictionary<int, string> DoorBadge { get; set; } = new Dictionary<int, string>( );
        public Badge() { }
        public Badge(string doorName
            ,Dictionary<int,string> lsitOfBadge)
        {
            
            DoorName = doorName;
            DoorBadge = lsitOfBadge;

        }
        // Add Bage to door 
        public void AddIdToDoor()
        {
            DoorBadge.Add(BadgeID, DoorName);
        }
        //Remove 
        public void RemoveFromDoor()
        {
            DoorBadge.Remove(BadgeID);
        }
    }
}
