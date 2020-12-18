using System.Collections.Generic;

namespace _02_Badges_Repository
{
    public class BadgRepo
    {

        private Dictionary<int, Badge> _badgesList = new Dictionary<int, Badge>();
        private int badgeID = 1000;

        // Badge create
        public void AddBadge(Badge badge)
        {
            badge.BadgeID = badgeID + 1;
            Badge badge1 = new Badge(badge.DoorName);
            _badgesList.Add(badge.BadgeID, badge1);
            badgeID++;
        }

        public void AddBageForTheDoor(Badge badge)
        {
            badge.BadgeID = badgeID;
            Badge badges = new Badge(badge.DoorName);
            _badgesList.Add(badgeID, badges);
            badgeID++;
        }
        //Developer Read
        public Dictionary<int, Badge> GetAllBadge()
        {
            return _badgesList;
        }
        //Helper Method
        public Badge GetBadgeByID(int id)
        {
            foreach (KeyValuePair<int, Badge> badge in _badgesList)
            {
                if (badge.Key == id)
                {
                    return badge.Value;
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
        public bool RemoveAllDoor(int id)
        {
            Badge badge = GetBadgeByID(id);
            if (_badgesList.Remove(badge.BadgeID))
            {
                return true;
            }
            return false;
            
        }

    }
}
