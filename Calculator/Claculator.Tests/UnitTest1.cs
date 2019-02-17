using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Claculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void MustPass()
        {
            // Arrange
            int actual = 1;
            int expected = 1;

            // Act
            actual = expected;
            expected = actual;


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
