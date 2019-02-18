using Calculator.Services.Implementations;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorServiceTDDInitialTests
    {

        [Test]
        public void Test_That_One_Plus_One_Equals_Two()
        {
            // Arrange
            int expected = 2;
            int firstNumber = 1;
            int secondNumber = 1;
            string mathOperator = "+";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
