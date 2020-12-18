using _01_Komodo_Claims_Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Komodo_Claims_Department_Console
{
    public class ProgramUI
    {
        private ClaimRepo _claimRepo = new ClaimRepo();

        public void Run()
        {
            SeedData();
            while (Menu())
            {
                Console.WriteLine("Press any Key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Goodbye!\n" +
                "Press an key to exit...");
            Console.ReadKey();
        }
        private void SeedData()
        {
            var walden = new Claim(ClaimOptions.Car, "the car hit the block", 277.67, new DateTime(2020, 3, 15), new DateTime(2020, 3, 16), true);
            var Kit = new Claim(ClaimOptions.Home, "Hell danmaged the roof", 1500.52, new DateTime(2020, 5, 19), new DateTime(2020, 05, 20), true);
            var Bob = new Claim(ClaimOptions.Renter, "Home got fire", 600.21, new DateTime(2020, 09, 21), new DateTime(2020, 09, 22), true);
            _claimRepo.AddClaimToDirectory(walden);
            _claimRepo.AddClaimToDirectory(Bob);
            _claimRepo.AddClaimToDirectory(Kit);
        }

        private bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the DevTeam Menu. Please select an option.\n\n" +
               "1. See all Claim\n" +
               "2. Add a new Claim\n" +
               "3. Take care of  a Calim\n" +
               //"4. Delete a Claim\n" +
               //"5.\n\n" +
               "0. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    //Display all Claim
                    DisplayAllClaim();
                    break;
                case "2":
                    //Create a Claim
                    AddNewClaim();
                    break;
                //case "3":
                //    //Take Care of  a claim
                //    UpdateExistingClaim();
                //    break;
                case "3":
                    //Delete Claim
                     DeleteExistingClaim();
                    break;

                case "0":
                    //Exit
                    return false;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
            return true;
        }
        private void DisplayAllClaim()
        {
            Console.Clear();
            var allClaims = _claimRepo.GetAllClaims();
            foreach (var claim in allClaims) 
            {
                DisplayClaim(claim);
            }
            Console.WriteLine();

        }
        private void AddNewClaim()
        {
            Console.Clear();
            //Claim Type
            Console.WriteLine("Please Choos number for Your Claim Type: \n" +
                "1. Car \n" +
                "2. Home\n" +
                "3. Renter");
            string claimOptions = Console.ReadLine();
            int claimNum = int.Parse(claimOptions);
            //description
            Console.WriteLine("Pleas Enter claim description: ");
            string claimDescription = Console.ReadLine();
            //amount
            Console.WriteLine("Please enter claim estimation: ");
            string estimation = Console.ReadLine();
            double estimate = double.Parse(estimation);
            //Incident Date
            Console.WriteLine("Enter incident date: ");
            string dateIn = Console.ReadLine();
            DateTime iDate = DateTime.Parse(dateIn);
            //Claim Date
            Console.WriteLine("Enter incident date: ");
            string cDateIn = Console.ReadLine();
            DateTime cDate = DateTime.Parse(cDateIn);
            //Validatiom Check
            Console.WriteLine("Is Your Claim Valid? (y/n)");
            bool isClaimValid = GetYesNoAnswer();

            Claim newClaim = new Claim((ClaimOptions)claimNum,claimDescription,estimate,iDate,cDate,isClaimValid);
            _claimRepo.AddClaimToDirectory(newClaim);
            //
        }
        //private void UpdateExistingClaim()
        //{
        //    Console.Clear();
        //    DisplayAllClaim();
        //    Console.WriteLine("Enter the Claim Id please");
        //    int claimID = int.Parse(Console.ReadLine());
        //    DisplayClaim(_claimRepo.GetClaimBYID(claimID));
        //    Console.WriteLine("Please Choos number for Your Claim Type: \n" +
        //      "1. Car \n" +
        //      "2. Home\n" +
        //      "3. Renter");
        //    string claimOptions = Console.ReadLine();
        //    int claimNum = int.Parse(claimOptions);
        //    //description
        //    Console.WriteLine("Pleas Enter claim description: ");
        //    string claimDescription = Console.ReadLine();
        //    //amount
        //    Console.WriteLine("Please enter claim estimation: ");
        //    string estimation = Console.ReadLine();
        //    double estimate = double.Parse(estimation);
        //    //Incident Date
        //    Console.WriteLine("Enter incident date: ");
        //    string dateIn = Console.ReadLine();
        //    DateTime iDate = DateTime.Parse(dateIn);
        //    //Claim Date
        //    Console.WriteLine("Enter incident date: ");
        //    string cDateIn = Console.ReadLine();
        //    DateTime cDate = DateTime.Parse(cDateIn);
        //    //Validatiom Check
        //    Console.WriteLine("Is Your Claim Valid? (y/n)");
        //    bool isClaimValid = GetYesNoAnswer();

        //    Claim updateClaim = new Claim((ClaimOptions)claimNum, claimDescription, estimate, iDate, cDate, isClaimValid);
        //    _claimRepo.AddClaimToDirectory(updateClaim);

        //}
      
        private void DeleteExistingClaim()
        {
            Console.Clear();
            DisplayAllClaim();
            Console.WriteLine("Eneter ClaimId to Take Care");
           // string str = Console.ReadLine();
            int claimID = int.Parse(Console.ReadLine());
            var claimToRemove = _claimRepo.GetClaimBYID(claimID);
            Console.WriteLine("Are you sure to Takecare this claim now?(Yes/No)");
            if (GetYesNoAnswer())
            {
                if (_claimRepo.RemoveClaim(claimToRemove))
                {
                    Console.WriteLine("Removed successfully");
                }
                else
                {
                    Console.WriteLine("Can not be removed claim");
                }
            }
            Console.WriteLine("Do wnat to remove another claim");

            if (GetYesNoAnswer())
            {
                DeleteExistingClaim();
            }

        }
        private bool GetYesNoAnswer()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if(input=="yes" || input == "y")
                {
                    return true;
                }
                else if (input == "no" || input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter valid value");
                }
            }
        }
        private void DisplayClaim(Claim claim)
        {
            Console.WriteLine($"ID:{claim.ClaimID}");
            Console.WriteLine($"\tClaim Type:{claim.ClaimType}");
            Console.WriteLine($"\tID:{claim.Description}");
            Console.WriteLine($"\tClaim Date:{claim.DateOfClaim}");
            Console.WriteLine($"\tClaim Type:{claim.DateOfIncident}");   
        }
            
    }
}
