using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCheck;
using System;

namespace Check.tests
{
    [TestClass]
    public class PassCheckTests
    {
        [TestMethod]
        public void CheckPass_EmptyPass_Returns0()
        {
            // Arrange
            var pass = new PassCheck();
            string password = "";
            int expectedScore = 0;

            // Act
            int actualScore = pass.Pass(password);

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void CheckPass_PassHaveNumber_Returns1()
        {
            // Arrange
            var pass = new PassCheck();
            string password = "123";
            int expectedScore = 1;

            // Act
            int actualScore = pass.Pass(password);

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void CheckPass_PassHaveNumberAndLowercaseLetter_Returns2()
        {
            // Arrange
            var pass = new PassCheck();
            string password = "123asd";
            int expectedScore = 2;

            // Act
            int actualScore = pass.Pass(password);

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void CheckPass_PassHaveNumberAndLowercaseAndUppercaseLetter_Returns3()
        {
            // Arrange
            var pass = new PassCheck();
            string password = "123Asd";
            int expectedScore = 3;

            // Act
            int actualScore = pass.Pass(password);

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void CheckPass_PassHaveNumberAndLowercaseAndUppercaseLetterAndSpecialCharacters_Returns4()
        {
            // Arrange
            var pass = new PassCheck();
            string password = "123@Sd";
            int expectedScore = 4;

            // Act
            int actualScore = pass.Pass(password);

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void CheckPass_PassHaveNumberAndLowercaseAndUppercaseLetterAndSpecialCharactersAndMoreThan7Char_Returns5()
        {
            // Arrange
            var pass = new PassCheck();
            string password = "1234As";
            int expectedScore = 5;

            // Act
            int actualScore = pass.Pass(password);

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}
