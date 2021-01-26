using NUnit.Framework;

using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        //test methods usally follow this convention
        //Methodname_Scenario_ExpectedResult
        //GivenThesearguments_WhenMethodCalled_thenExpectedresult

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            //Arrenage / Given
            int numA = 5;
            int numB = 7;
            Math math = new Math();

            //Act /When
            int result = math.Add(numA, numB);

            //Assert /Then
            Assert.AreEqual(12, result);
            Assert.That(result, Is.EqualTo(12));//The same
        }


        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(4, 4, 4)]
        public void Max_WhenCalled_ReturnBiggerNumber(int numA, int numB, int expected)
        {
            //Act
            int result = _math.Max(numA, numB);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetOddNumbers_WhenGivenLimitHigherThnanZero_returnOddNumbersArray()
        {
            var expected = new[] { 1, 3, 5 };

            IEnumerable<int> result = _math.GetOddNumbers(5);

            //Assert.NotNull(result);
            //Assert.AreEqual(3, result.Count());
            Assert.AreEqual(expected, result);
        }

    }
}
