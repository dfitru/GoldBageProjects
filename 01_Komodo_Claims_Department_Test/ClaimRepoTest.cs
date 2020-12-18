using _01_Komodo_Claims_Department;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Komodo_Claims_Department_Test
{
    
    [TestClass]
    public class ClaimRepoTest
    {
        private ClaimRepo _repo;
        private Claim _claim;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimRepo();
            _claim= new Claim(ClaimOptions.Car, "the car hit the block", 277.67, new DateTime(2020, 3, 15), new DateTime(2020, 3, 16), true);
            _repo.AddClaimToDirectory(_claim);
        }
        
        [TestMethod]
        public void SeeTestMethod()
        {
            //Arrange
            ClaimRepo claimRepo = new ClaimRepo();

            //Act
            Queue<Claim> claims = claimRepo.GetAllClaims();

            //Assert
            Assert.IsNotNull(claims);


        }
        [TestMethod]
        public void RemoveMethod_Test()
        {
            //Act
            bool removeTest = _repo.RemoveClaim(_claim);
            //Assert
            Assert.IsTrue(removeTest);
        }
        [TestMethod]
        public void NewClaimTestMethod()
        {
            //Arrenge
            ClaimRepo repo = new ClaimRepo ();
            Claim toTest= new Claim(ClaimOptions.Car, "the car hit the block", 277.67, new DateTime(2020, 3, 15), new DateTime(2020, 3, 16), true);
            //Act - 
            repo.AddClaimToDirectory(toTest);

        }
        [TestMethod]
        public void TestGetBYID()
        {
            ClaimRepo claimRepo = new ClaimRepo();
            Claim claimToTest= new Claim(ClaimOptions.Car, "the car hit the block", 277.67, new DateTime(2020, 3, 15), new DateTime(2020, 3, 16), true);
            claimRepo.AddClaimToDirectory(claimToTest);

            //Act
            Claim byID = claimRepo.GetClaimBYID(claimToTest.ClaimID);
            bool claimEqual = claimToTest.Description == byID.Description;

            Assert.IsTrue(claimEqual);
        }
    }
}
