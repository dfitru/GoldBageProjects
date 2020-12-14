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
            var mark = new Badge("A1");
            var susi = new Badge("A2");
            var koko = new Badge("A3");

        }
        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello, follow the options to add\n\n" +
                "1. View all Badges that have the door access.\n" +
                "\n2. Add Badge to the door\n" +
                "\n3. Update badge access\n" +
                "\n4. Remove Badge from door\n\n" +
                "\n0. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    //View All Bage
                    DisplayAllBadgeAccess();
                    break;
                case "2":
                    //Add Badge
                    AddBageName();
                    break;
                case "3":
                    Console.Clear();
                    //Update badge
                    break;
                case "4":
                    Console.Clear();
                    //Delete Badge
                    break;
                case "0":
                    return false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
            return true;
        }



        private void DisplayAllBadgeAccess()
        {
            Console.Clear();
            var allBadge = _badgRepo.GetAllBadge();
            foreach (var badges in allBadge)
            {
                DisplayBadgeAccess(badges);
            }
            Console.WriteLine();

        }

        private void AddBageName()
        {
            Console.Clear();
            Badge newBadge = new Badge();
            Console.WriteLine("Enter Door Name");
            string doorName = Console.ReadLine();

            Console.WriteLine("Enter name of the Door");
            newBadge.DoorName = Console.ReadLine();

            //Console.WriteLine("Do you want to add BadgeID to DoorName now? (y/n)");
            //string answre = Console.ReadLine();
            //if (answre.ToLower()=="yes" || answre.ToLower() =="y" )
            //{
            //    newBadge.DoorBadge=

            //}
        }

      
        private void UpdateBadgeAccess()
        {

        }
        private void DeleteBadge()
        {

        }
        private void DisplayBadgeAccess(Badge badge)
        {
            Console.WriteLine($"\tID: {badge.BadgeID}");
            Console.WriteLine($"\tName: {badge.DoorName}");
            if (badge.DoorBadge!=null)
            {
                
                foreach ( var item in badge.DoorBadge)
                {
                    Console.WriteLine("BadgeID:{},has access for door:{}",badge.BadgeID,badge.DoorName);
                }
            }
            else
                Console.WriteLine("Badge not found");

        }

    }
}