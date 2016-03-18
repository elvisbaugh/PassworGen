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
            string iDvalue = "18085228";

            PasswordController controller = new PasswordController();
            ViewResult result = controller.Index(iDvalue) as ViewResult;
            var model = result.Model as ValidatePasswordWithID;
            var viewModel = result.Model as PasswordsAndIds;


            viewModel = model.ValidatePassword(iDvalue);
            result.TempData["iDNumber"] = viewModel.ID;
            result.TempData["password"] = viewModel.Password;

            string expectedId =  "18085228";
            string expectedPassword = "Xwyzh";

            string actualIdValue = Convert.ToString(result.TempData["iDNumber"]);
            string actualPasswordValue = Convert.ToString(result.TempData["password"]);

            Assert.AreNotEqual(expectedPassword, actualPasswordValue);
            Assert.AreEqual(expectedId, actualIdValue);

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
