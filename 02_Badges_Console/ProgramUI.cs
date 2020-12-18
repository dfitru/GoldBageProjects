using _02_Badges_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Badges_Console
{
    public class ProgramUI
    {
        private BadgRepo _badgRepo = new BadgRepo();
        public void Run()
        {
            SeedData();
            while (Menu())
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Goodbye!\n" +
                "Press an key to exit...");
            Console.ReadKey();
        }
        private void SeedData()
        {
            var badge1 = new Badge(new List<string> {"A1","A2","A3" });

            var badge2 = new Badge(new List<string> { "A1", "A2","A4" });
            var badge3 = new Badge(new List<string> { "A1",  "A3" });
            var badge4 = new Badge(new List<string> {  "A2", "A3","A4" });
            var badge5 = new Badge(new List<string> { "A1", "A2","A3","A4","A5" });
            _badgRepo.AddBageForTheDoor(badge1);
            _badgRepo.AddBageForTheDoor(badge5);
            _badgRepo.AddBageForTheDoor(badge4);
            _badgRepo.AddBageForTheDoor(badge3);
            _badgRepo.AddBageForTheDoor(badge2);

        }
        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello, follow the options to add\n\n" +
                "1. View all Badges that have the door access.\n" +
                "\n2. Add Badge\n" +
                "\n3. Update/Edit badge\n" +
                "\n4. Remove Door from Badge and from door\n\n" +
                "\n0. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    //View All Bage
                    DisplayAllBadgeAccess();
                    break;
                case "2":
                    //Add Badge
                    AddBadge();
                    break;
                case "3":
                    UpdateBadgeAccess();
                    //Update badge
                    break;
                case "4":
                    DeleteBadge();
                    break;
                case "0":
                    return false;
                    
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
            return true;
        }
        private void DisplayAllBadgeAccess()
        {
            Console.Clear();
            Dictionary<int, Badge> badgeList = _badgRepo.GetAllBadge();
            foreach (KeyValuePair<int, Badge> badge in badgeList)
            {
                Console.WriteLine($"BadgeID:-{badge.Key}");
                foreach (string item in badge.Value.DoorName)
                {
                    Console.WriteLine($"\tDoorName:{item}");
                }
            }
        }
        public void DisplayBageByID()
        {
        }
        private void AddBadge()
        {
            Console.Clear();
            Badge newBadge = new Badge();

            Console.WriteLine("Enter name of the Door");
            newBadge.DoorName = new List<String> { Console.ReadLine() };

            _badgRepo.AddBageForTheDoor(newBadge);
        }
        private void UpdateBadgeAccess()
        {
            Console.Clear();
            DisplayAllBadgeAccess();
            Console.WriteLine("Enter BadgeId you would like to edit:");
            int Id = int.Parse(Console.ReadLine());
            Badge door = _badgRepo.GetBadgeByID(Id);

            Dictionary<int, Badge> badgeList = _badgRepo.GetAllBadge();
            foreach (KeyValuePair<int, Badge> badge in badgeList)
            {
                Console.WriteLine($"BadgeID:-{badge.Key}");
                foreach (string item in badge.Value.DoorName)
                {
                    Console.WriteLine($"\tDoorName:{item}");
                }
            }
        }
        private void DeleteBadge()
        {
            Console.Clear();
            DisplayAllBadgeAccess();
            Console.WriteLine("Enter Id of the door you would like to remove:");
            int badgeId = int.Parse(Console.ReadLine());
            Console.Clear();
            var doorToDelete = _badgRepo.GetBadgeByID(badgeId);
            
            Console.WriteLine("Are you sure you wnat to remove:(yes or no)-"+doorToDelete);
            string ans = Console.ReadLine();
            if (ans.ToLower()=="yes"|| ans.ToLower() == "y")
            {
                if (_badgRepo.RemoveAllDoor(badgeId))
                {
                    Console.WriteLine("The developer was successfully deleted");
                }
                else
                {
                    Console.WriteLine("The developer could not be deleted");
                }

            }
        }
        //private void DisplayBadge(Badge badge)
        //{
        //    Dictionary<int, Badge> badgeList = _badgRepo.GetAllBadge();
        //    foreach (KeyValuePair<int, Badge> badge in badgeList)
        //    {
        //        Console.WriteLine($"BadgeID:-{badge.Key}\n" +
        //            $"\tDoorName:-{badge.Value.DoorName}");
        //    }

        //}
    }
}