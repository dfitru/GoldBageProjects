using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Badges_Repository
{
    public class BadgRepo
    {
        private List<Badge> _badges = new List<Badge>();
        private int badgeID = 1000;

        // Badge create 

        public void AddBageForTheDoor (Badge bage)
        {
            bage.BadgeID = badgeID + 1;
            _badges.Add(bage);
            badgeID++;
        }
        //Developer Read
        public List<Badge> GetAllBadge()
        {
            return _badges;
        }

        //Helper Method
        public Badge GetBadgeByID(int id)
        {
            foreach (Badge badge in _badges)
            {
                if (badge.BadgeID == id)
                {
                    return badge;
                }

            } return null;
            
        }
        // badge Update

        public bool BadgeUpdate(int badgeID, Badge newBadge)
        {
            Badge oldBadge = GetBadgeByID(badgeID);
            if (oldBadge!=null)
            {
                oldBadge.BadgeID = newBadge.BadgeID;
                oldBadge.DoorName = newBadge.DoorName;

                return true;
            }
            return false;
        }

        //Remove Bage
        public bool RemoveBage(int badgeid)
        {
            Badge badge = GetBadgeByID(badgeid);
            if (_badges.Remove(badge))
            {
                return true;

            }
            return false;
        }
        
    }
}
