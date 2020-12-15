using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Repo
{
    public class CafeClass
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public List <string> Ingredients { get; set; }
        public double Price { get; set; }
        public CafeClass() { }

        public CafeClass(string mealName,string description,List<string> ingredients,double price)
        {
           // MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = description;
            Ingredients = ingredients;
            Price = price;
        }

    }
}
