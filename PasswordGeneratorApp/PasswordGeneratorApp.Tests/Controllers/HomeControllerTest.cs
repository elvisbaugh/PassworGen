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

namespace PasswordGeneratorApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Given_ID_Return_Password()
        {
            PasswordController controller = new PasswordController();
            ValidatePasswordWithID validate = new ValidatePasswordWithID();
            ViewResult result = controller.Index("18085228") as ViewResult;
            List<string> expected = new List<string>() { "18085228", "xwtyj" };
            List<PasswordsAndIds> actualVlaue = new List<PasswordsAndIds>();
            actualVlaue.Contains(expected);
            Assert.AreNotEqual(expected, actualVlaue);

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
