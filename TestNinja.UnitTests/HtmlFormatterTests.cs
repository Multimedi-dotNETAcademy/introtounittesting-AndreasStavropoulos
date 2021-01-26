using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class HtmlFormatterTests
    {
        private HtmlFormatter _htmlFormatter;

        [SetUp]
        public void SetUp()
        {
            _htmlFormatter = new HtmlFormatter();
        }

        [TestCase("One day I am going to be bold")]
        public void FormatAsBold_WhenCalled_ReturnsStringInBold(string content)
        {
            //Assert

            var expected = $"<strong>{content}</strong>";
            //Act

            var result = _htmlFormatter.FormatAsBold(content);

            //Assert

            Assert.AreEqual(expected, result);
        }

    }
}
