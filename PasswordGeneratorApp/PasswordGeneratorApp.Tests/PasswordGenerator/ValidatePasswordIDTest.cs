using BusinessLogicLayer.PasswordGenerator;
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
            List<PasswordsAndIds> expected = new List<PasswordsAndIds>();
            expected.Add(new PasswordsAndIds { ID ="18085228 ", Password ="xwtyj " });
            List<PasswordsAndIds> actualValue = validate.ValidatePassword("18085228 ");
            //Assert.AreNotEqual(1, actualValue.Count());
            Assert.AreNotEqual(expected, actualValue);
        }
    }
}
