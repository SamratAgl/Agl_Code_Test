using AGL.WebAPI.Controllers;
using AGL.WebAPI.Models;
using AGL.WebAPI.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGL.WebAPI.Tests.Controller
{
   [TestClass]
   public class AGLDataControllerTest
    {
        [TestMethod]
        public void GetPetDetailsTest()
        {
            //Arrange
            var controller = new AGLDataController();

            //Act
            var response = controller.GetPetDetails();

            //Assert
            //Is not null check
            Assert.IsNotNull(response);

            //Gender Count Check
            Assert.AreEqual(response.Count, 2);            
        }
    }
}
