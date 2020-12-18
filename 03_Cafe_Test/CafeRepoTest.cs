using Cafe_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_Cafe_Test
{
    [TestClass]
    public class CafeRepoTest
    {
        private CafeRepo _repo;
        private CafeClass _menu;
        [TestInitialize]

        public void Arrange()
        {
            _repo = new CafeRepo();
            _menu = new CafeClass("Salad", "Chickn Club Sald", new List<string>() {"lightly fried chicken," +
                "egg," +
                "tomato," +
                "avocado," +
                "onion," +
                "house made croutons" }, 16.00); 
            _repo.AddMenuToList(_menu);
        }
        [TestMethod]
        public void MyAddTestMethod()
        {
            //Arrange
            CafeClass cafe = new CafeClass();
            cafe.MealName = "Salad";
            CafeRepo repo = new CafeRepo();
            //Act
            repo.AddMenuToList(cafe);

            CafeClass menuFromCafe = repo.GetMenuByNum(cafe.MealNumber);

            //Assert
            Assert.IsNotNull(menuFromCafe);

        }
        [TestMethod]
        public void TestDeleteMethod()
        {
            //Arrange
            //Act
            bool deleteMenu = _repo.RemoveMenuFromList(_menu.MealNumber);
            //Assert
            Assert.IsTrue(deleteMenu);
        }
    }
}
