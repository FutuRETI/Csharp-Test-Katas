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

        [TestMethod]
        public void TestAddManyNumbers()
        {
            // arrange
            String input = "5,7,1,2,3,4,5";
            int expectedResult = 27;

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAddNewLineSplitter()
        {
            // arrange
            String input = "1\n2,3";
            int expectedResult = 6;

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestWrongInput()
        {
            // arrange
            String input = "1,\n";

            // act
            try
            {
                StringCalculatorKata.Program program = new StringCalculatorKata.Program();
                int result = program.Add(input);
                Assert.Fail();
            }

            catch (StringCalculatorKata.ProgramException e)
            {
                // assert
                Assert.IsNotNull(e);
            }
        }

        [TestMethod]
        public void TestAddFirstNegative()
        {
            // arrange
            String input = "-1,2";

            // act
            try
            {
                StringCalculatorKata.Program program = new StringCalculatorKata.Program();
                int result = program.Add(input);
                Assert.Fail();
            }
            catch (StringCalculatorKata.ProgramException e)
            {
                // assert
                Assert.IsNotNull(e);
                Assert.AreEqual("Negatives not allowed.", e.Message);
            }
        }

        [TestMethod]
        public void TestAddNegative()
        {
            // arrange
            String input = "1,-1,2";

            // act
            try
            {
                StringCalculatorKata.Program program = new StringCalculatorKata.Program();
                int result = program.Add(input);
                Assert.Fail();
            }
            catch (StringCalculatorKata.ProgramException e)
            {
                // assert
                Assert.IsNotNull(e);
                Assert.AreEqual("Negatives not allowed.", e.Message);
            }
        }

        [TestMethod]
        public void TestAddCustomDelimeter()
        {
            // arrange
            String input = ";\n1;2";
            int expectedResult = 3;

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
