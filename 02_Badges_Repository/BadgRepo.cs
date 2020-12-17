using System.Collections.Generic;

namespace _02_Badges_Repository
{
    public class BadgRepo
    {

        private Dictionary<int, List<Badge>> _badgesList = new Dictionary<int, List<Badge>>();
        private int badgeID = 1000;

       // Badge create
        public void AddBadge(Badge badge)
        {
            List<Badge> badges = new List<Badge>();
            badges.Add(badge);
            _badgesList.Add(badge.BadgeID, badges);
        }

        public void AddBageForTheDoor(Badge badge)
        {
            badge.BadgeID = badgeID + 1;
            List<Badge> badges = new List<Badge>();
            badges.Add(badge);
            _badgesList.Add(badgeID,badges);
            badgeID++;
        }
        //Developer Read
        public Dictionary<int, List<Badge>> GetAllBadge()
        {
            return _badgesList;
        }
        //Helper Method
        public Badge GetBadgeByID(int id)
        {
            foreach (KeyValuePair<int, List<Badge>> badge in _badgesList)
            {
                if (badge.Key == id)
                {

                    foreach (var Value in badge.Value)
                    {
                        Badge badge1 = Value;
                        return badge1;
                    }  
                } 
            }
            return null;
        }
        // badge Update

        public bool BadgeUpdate(int badgeID, Badge newBadge)
        {
            Badge oldBadge = GetBadgeByID(badgeID);
            if (oldBadge != null)
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
            if (_badgesList.Remove(badge.BadgeID))
            {
                return true;
            }
            return false;
        }

    }
}
