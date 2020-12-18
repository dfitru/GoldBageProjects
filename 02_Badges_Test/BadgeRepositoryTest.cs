using _02_Badges_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Badges_Test
{
    [TestClass]
    public class BadgeRepositoryTest
    {
        private BadgRepo _repo;
        private Badge _badge;
        [TestInitialize]
        public void intialize()
        {
            _repo = new BadgRepo();
            _badge = new Badge(new List<string> { "A1" });

            _repo.AddBageForTheDoor(_badge);
        }

        //Add Method
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            Badge badge = new Badge();
            badge.DoorName= new List<string> { "A1" };
            BadgRepo repo = new BadgRepo();

            //Act
            repo.AddBadge(badge);
            Badge badgeFromNew = repo.GetBadgeByID(badge.BadgeID);
            //Assert
            Assert.IsNotNull(badgeFromNew);
        }

        [TestMethod]
        public void TestMethod_GetById()
        {
            BadgRepo repo = new BadgRepo();
            Badge toAdd = new Badge(new List<string> { "A1" });
            repo.AddBadge(toAdd);
            //Act
            Badge byID = repo.GetBadgeByID(toAdd.BadgeID);
            bool badgeisEqual = toAdd.DoorName == byID.DoorName;
            //Assert
            Assert.IsTrue(badgeisEqual);

        }
        [TestMethod]
        public void Delete_Test()
        {
            //Badge newbadge = new Badge("A2");

            //Act
            bool UpDateResult = _repo.RemoveAllDoor(_badge.BadgeID);

            //Assert
            Assert.IsTrue(UpDateResult);

        }
        [TestMethod]
        public void UpdateMethod_Test()
        {
            Badge newbadge = new Badge(new List<string> { "A1" });

            //Act
            bool updateBadge = _repo.BadgeUpdate(1000, newbadge);

        }
        [TestMethod]
        public void View_Test()
        {

        }
    }
}
