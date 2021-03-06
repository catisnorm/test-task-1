﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWebApi;
using TestWebApi.Controllers;

namespace TestWebApi.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            UsersController controller = new UsersController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
