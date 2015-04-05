using System;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture()]
    public class ProgramTests
    {
        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("5", 5)]
        [TestCase("5,7", 12)]
        [TestCase("5,7,1,2,3,4,5", 27)]
        [TestCase("1\n2,3", 6)]
        [TestCase(";\n1;2", 3)]
        public void TestAdd(string input, int expectedResult)
        {
            // arrange

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            int result = program.Add(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("1,\n")]
        [TestCase("1,aaa")]
        [TestCase("-1,2")]
        [TestCase("1,-1,2")]
        [ExpectedException(typeof(StringCalculatorKata.ProgramException))]
        public void TestProgramException(string input)
        {
            // arrange

            // act
            StringCalculatorKata.Program program = new StringCalculatorKata.Program();
            program.Add(input);
            Assert.Fail("An exception should have been thrown before.");
        }
    }
}
