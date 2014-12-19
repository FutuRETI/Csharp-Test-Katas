using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestAddNull()
        {
            // arrange
            String input = null;
            int expectedResult = 0;

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddEmptyString()
        {
            // arrange
            String input = "";
            int expectedResult = 0;

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddOneNumber()
        {
            // arrange
            String input = "5";
            int expectedResult = 5;

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddTwoNumbers()
        {
            // arrange
            String input = "5,7";
            int expectedResult = 12;

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
