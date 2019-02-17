using Calculator.Services;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class InitialCalculatorTests
    {
        [Test]
        public void MustPass()
        {
            // Arrange
            int expected = 1;

            // Act
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MustPassServicesTest()
        {
            // Arrange
            int expected = 2;
            ICalculatorService service = new MockCalculatorService();

            // Act
            int actual = service.OnePlusOne();


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
