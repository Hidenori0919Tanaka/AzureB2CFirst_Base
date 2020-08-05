using System;
using System.Collections.Generic;
using System.Text;
using ASPDotNet_B2C;
using ASPDotNet_B2C.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace ASPDotNet_B2C.Test.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            //Assert.AreEqual("Your application description page.", result.ViewData.Values);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
