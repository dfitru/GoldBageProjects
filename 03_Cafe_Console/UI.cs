using Cafe_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Cafe_Console
{
    public class UI
    {
        private CafeRepo _menuRepo = new CafeRepo();

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
            //CafeClass menu = new CafeClass();
            //menu.Ingredients = new List<string>();

            var salad = new CafeClass("Salad","Chickn Club Sald",new List<string>() {"lightly fried chicken," +
                "egg," +
                "tomato," +
                "avocado," +
                "onion," +
                "house made croutons" },16.00);
            var burger = new CafeClass("Chees Burger", "Chees Burger", new List<string>() {
                "cheddar," +
                "lettuce," +
                "tomato," +
                "onion," +
                "Pickel" }, 14.57);
            var chicken = new CafeClass("Chicken", "Enchilada Plae", new List<string>() {"corn tortila," +
                "montery jack," +
                "enchilada red sauce," +
                "soure cream," +
                "guacomole," +
                "pico" }, 16.50);

            _menuRepo.AddMenuToList(salad);
            _menuRepo.AddMenuToList(burger);
            _menuRepo.AddMenuToList(chicken);
        }
        private bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the DevTeam Menu. Please select an option.\n\n" +
                "1. View all Menu\n" +
                "\t\t2. Add a new Menu\n" +
                "3. Update a Menu\n" +
                "\t\t4. Delete a Menu\n\n" +
               
                "0. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    //Display all Menu
                    DisplayAllMenu();
                    break;
                case "2":
                    //Create a Menu
                   CreateNewMenu();
                    break;
                case "3":
                    //Update an existing Menu
                  UpdateMenu();
                    break;
                case "4":
                    //Delete a Menu
                  //  DeleteMenu();
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
        public void DisplayAllMenu()
        {
            Console.Clear();
            List<CafeClass> menuList = _menuRepo.GetMenuList();
            foreach (var menu in menuList)
            {
                Console.WriteLine($"No:{menu.MealNumber}\n" +
                    $"\tMenu Name:{menu.MealName}\n" +
                    $"\tDescription:{menu.MealDescription}\n");
                foreach (var inputs in menu.Ingredients)
                {
                    Console.WriteLine($"\tIngridients:{inputs}");
                }
            }
        }

        public void CreateNewMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter menuName");
            string menuName = Console.ReadLine();
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            Console.WriteLine("Do you wnat to add Ingridients?enter(yes/y or no/n");
            List<string> menuIngridient = Console.ReadLine().Split(',').ToList();
            Console.WriteLine("Enter Price");
            string strPrice = Console.ReadLine();
            double price = double.Parse(strPrice);

            CafeClass newMenu = new CafeClass(menuName, description, menuIngridient, price);
        }
        public void UpdateMenu()
        {
            Console.Clear();
            DisplayAllMenu();
            Console.WriteLine("Enter Menu Number");
            int menuNum = int.Parse(Console.ReadLine());
            Console.Clear();
            var menuToView = _menuRepo.GetMenuByNum(menuNum);
            ViewMenu(menuToView);
            Console.WriteLine("Enter menuName");
            string menuName = Console.ReadLine();
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            Console.WriteLine("Do you wnat to add Ingridients?enter(yes/y or no/n");
            List<string>  menuIngridient = Console.ReadLine().Split(',').ToList();
            
            
            Console.WriteLine("Enter Price");
            string strPrice = Console.ReadLine();
            double price = double.Parse(strPrice);

            CafeClass newMenu = new CafeClass(menuName, description, menuIngridient, price);



        }
        private bool GetYesNoAnswer()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "yes" || input == "y")
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
        private void ViewMenu(CafeClass menu)
        {
            Console.WriteLine($"No:{menu.MealNumber}\n" +
                    $"\tMenu Name:{menu.MealName}\n" +
                    $"\tDescription:{menu.MealDescription}\n");
            foreach (var inputs in menu.Ingredients)
            {
                Console.WriteLine($"\tIngridients:{inputs}");
            }

        }

       public void RemoveMenu()
        {

        }

    }
}
