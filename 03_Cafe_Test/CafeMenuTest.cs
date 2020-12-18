using Cafe_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Cafe_Test
{
    [TestClass]
    public class CafeMenuTest
    {
        [TestMethod]
        public void MenuTest()
        {
            CafeClass cafe = new CafeClass();
            cafe.MealName = "Sald";
            string expected = "Sald";
            string actual = cafe.MealName;

            Assert.AreEqual(expected,actual);
        }
    }
}
