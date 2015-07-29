using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTest
    {
        private StringCalculator calculator;

        [TestFixtureSetUp]
        public void setUp()
        {
            calculator = new StringCalculator();
        }

        [Test]
        public void GivenEmptyStringOrNullShouldReturnErrorString()
        {
            Assert.AreEqual("operator not supported", calculator.Add(null));
            Assert.AreEqual("operator not supported", calculator.Add(""));
        }

        [Test]
        public void ExtractNumberFromStringAndReturnAsInteger()
        {
            Assert.AreEqual(new List<int>() { 0 }, calculator.ExtractNumbers("0"));
            Assert.AreEqual(new List<int>() { 1 }, calculator.ExtractNumbers("1"));
            Assert.AreEqual(new List<int>() { -1 }, calculator.ExtractNumbers("-1"));
        }

        [Test]
        public void ExtractNumberFromStringWithOperatorAndInteger()
        {
            Assert.AreEqual(new List<int>() { 0 }, calculator.ExtractNumbers("0+"));
            Assert.AreEqual(new List<int>() { 1}, calculator.ExtractNumbers("1+"));
        }

        [Test]
        public void ExtractNumberFromStringWithOperatorAndTwoIntegers()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 2 }, calculator.ExtractNumbers("1+2"));
        }
    }
}
