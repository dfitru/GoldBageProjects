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

            var salad = new CafeClass(1,"Salad","Chickn Club Sald",new List<string>() {"lightly fried chicken\n" +
                "egg\n" +
                "tomato\n" +
                "avocado\n" +
                "onion\n" +
                "house made croutons" },16.00);
            var burger = new CafeClass(2, "Chees Burger", "Chees Burger", new List<string>() {
                "cheddar\n" +
                "lettuce\n" +
                "tomato\n" +
                "onion\n" +
                "Pickel" }, 14.57);
            var chicken = new CafeClass(3, "Chicken", "Enchilada Plae", new List<string>() {"corn tortila\n" +
                "montery jack\n" +
                "enchilada red sauce\n" +
                "soure cream\n" +
                "guacomole\n" +
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
                  //  CreateNewMenu();
                    break;
                case "3":
                    //Update an existing Menu
                 //   UpdateMenu();
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
                    $"\tDescription:{menu.MealDescription}\n" +
                    $"\tIngridients:{menu.Ingredients}");

            }

        }



    }
}
