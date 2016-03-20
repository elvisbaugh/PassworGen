using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGeneratorApp;
using PasswordGeneratorApp.Controllers;
using PasswordGeneratorApp.Models;
using BusinessLogicLayer.PasswordGenerator;
using BusinessLogicLayer.Models;
using Telerik.JustMock;
using BusinessLogicLayer.Interfaces;

namespace PasswordGeneratorApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Given_ID_Return_Password()
        {
            //Arrange
            var validationOfPasswordWithId = Mock.Create<IValidatePassword>();
            Mock.Arrange(() => validationOfPasswordWithId.ValidatePassword("18085228")).Returns(
                new PasswordsAndIds() { ID = "18085228", Password = "Wxyzh" }
                ).MustBeCalled();

            //Act
            var controller = new PasswordController(validationOfPasswordWithId);
            ViewResult result = controller.Index("18085228") as ViewResult;
            var model = result.Model as ViewPasswordAndId;

            //Assert
            Assert.AreEqual("18085228", model.ViewID);
            Assert.AreEqual("Wxyzh", model.ViewID);
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
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
