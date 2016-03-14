using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogicLayer;

namespace PasswordGeneratorApp.Tests.PasswordGenerator
{
    [TestClass]
    public class PasswordGeneratorTest
    {
        [TestMethod]
        public void GeneratedPassword_Should_Return_Identifying_PairKey()
        {
            GenerateNewPassword passwordGenerator = new GenerateNewPassword();
            string expected = "xyzab";
            string actualValue = passwordGenerator.Generate();
            Assert.AreEqual(expected, actualValue);

        }

    }
}
