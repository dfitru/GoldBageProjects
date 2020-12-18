using _02_Badges_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Badges_Test
{
    [TestClass]
    public class BadgeClass
    {
        [TestMethod]
        public void BadgeName_CorrectString()
        {
            Badge badge = new Badge();
            badge.DoorName = new List<string> { "A1" };
            List<string> expected = new List<string> { "A1" };
            List<string>actual =badge.DoorName;

            Assert.AreEqual(expected, actual);
        }
    }
}
