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
        public void GivenOneNumberWithoutOperatorShouldReturnSameNumber()
        {
            Assert.AreEqual("0", calculator.Add("0"));
            Assert.AreEqual("13", calculator.Add("13"));
        }

        [Test]
        public void GivenTwoNumbersWithSumOperatorShouldReturnSumm()
        {
            Assert.AreEqual("0", calculator.Add("0+0"));
            Assert.AreEqual("3", calculator.Add("1+2"));
            Assert.AreEqual("6", calculator.Add("1+2+3"));
            Assert.AreEqual("45", calculator.Add("1+2+3+4+5+6+7+8+9"));
        }

        [Test]
        public void GivenOneNumberFolllowedSumOperatorShouldBeIgnored()
        {
            Assert.AreEqual("0", calculator.Add("0+"));
            Assert.AreEqual("10", calculator.Add("10+"));
        }
    }
}
