using System;
using System.Collections.Generic;
using System.Text;
using AGL.WebAPI.Controllers;
using AGL.WebAPI.Models;
using AGL.WebAPI.Provider;
using AGL.WebAPI.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AGL.WebAPI.Tests.Controller
{
    [TestClass]
    public class AGLDataControllerMoqTest
    {
        AGLDataRepository _repo;
        IAGLDataRepository repository;
        IAGLDataProvider provider;
        
        [TestMethod]

        public void GetPetDetailsTest()
        {
            var pet1 = new PetDetails { PetName = "", PetType = "Cat" };
            var pet2 = new PetDetails { PetName = "", PetType = "Dog" };
            var people = new People
            { Pets = new List<PetDetails>(), Gender = "Male" };
            people.Pets.Add(pet1);
            people.Pets.Add(pet2);
            var listOfPeople = new List<People>();
            listOfPeople.Add(people);
            var repo = new Mock<IAGLDataRepository>();
            repository = repo.Object;
            var pro = new Mock<IAGLDataProvider>();
            provider = pro.Object;
            repo.Setup(x => x.GetPetDetails()).Returns(listOfPeople);
            var controller = new AGLDataController();
            
            var response = controller.GetPetDetails();
            repo.Verify(x => x.GetPetDetails(), Times.Once);
            //Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(response.Count, 1);
        }
    }
}
