using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class FizzBuzzTests
    {
        [TestCase("FizzBuzz", 15)]
        [TestCase("Fizz", 3)]
        [TestCase("Buzz", 5)]
        [TestCase("7", 7)]
        public void GetOutput_WhenGivenInput_CorrectAnswerGetBack(string answer, int input)
        {
            //Act
            string result = FizzBuzz.GetOutput(input);
            //
            Assert.AreEqual(answer, result);
        }

    }
}