using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Repo
{
    public class CafeRepo
    {
        private readonly List<CafeClass> _cafeClass = new List<CafeClass>();

        // Create Menu
        public void AddMenuToList(CafeClass menu)
        {
            _cafeClass.Add(menu);
        }
        //Read
        public List<CafeClass> GetMenuList()
        {
            return _cafeClass;
        }
        public bool UpdateMenu(int orginalMenu,CafeClass newMenu)
        {
            CafeClass oldcafeClass = GetMenuByNum(orginalMenu);

            if (oldcafeClass!=null)
            {
                oldcafeClass.MealNumber = newMenu.MealNumber;
                oldcafeClass.MealName = newMenu.MealName;
                oldcafeClass.MealDescription = newMenu.MealDescription;
                oldcafeClass.Ingredients = newMenu.Ingredients;
                return true;
            }
            return false;
        }
        //Helper 
        public CafeClass GetMenuByNum(int num)
        {
            foreach (var id in _cafeClass)
            {
                if (id.MealNumber==num)
                {
                    return id;

                }

            }
            return null;
        }
        //Remove Menu
        public bool RemoveMenuFromList(int id)
        {
            CafeClass cafeClass = GetMenuByNum(id);
            if (cafeClass==null)
            {
                return false;

            }
            int count = _cafeClass.Count;
            _cafeClass.Remove(cafeClass);
            if (count>_cafeClass.Count)
            {
                return true;

            }
            return false;
        }

    }
}
