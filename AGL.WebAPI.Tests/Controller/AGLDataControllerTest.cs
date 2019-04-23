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
        public void AGLDataRepositoryTest()
        {
            var repo = new AGLDataRepository();
            var response = repo.GetPeopleResponse();
        }
    }
}
