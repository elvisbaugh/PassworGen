﻿using BusinessLogicLayer.PasswordGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Models;

namespace PasswordGeneratorApp.Tests.PasswordGenerator
{
    [TestClass]
    public class ValidatePasswordIDTest
    {
        [TestMethod]
        public void Return_Password_And_ID_Validation_Passes()
        {
            ValidatePasswordWithID validate = new ValidatePasswordWithID();
            PasswordsAndIds actualValue = new PasswordsAndIds();
            actualValue = validate.ValidatePassword("18085228");

            string expectedId = "18085228";
            string expectedPassword = "Wxytb";

            
            Assert.AreEqual(expectedId, actualValue.ID);
            Assert.AreNotEqual(expectedPassword, actualValue.Password);
        }
    }
}
