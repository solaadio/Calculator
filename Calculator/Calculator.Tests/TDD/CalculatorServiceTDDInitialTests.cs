using Calculator.Services.Implementations;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Tests.TDD
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class CalculatorServiceTDDInitialTests
    {

        [Test]
        public void Test_That_One_Plus_One_Equals_Two()
        {
            // Arrange
            const float expected = 2;
            const float firstNumber = 1;
            const float secondNumber = 1;
            const string mathOperator = "+";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_One_Minus_One_Equals_Zero()
        {
            // Arrange
            const float expected = 0;
            const float firstNumber = 1;
            const float secondNumber = 1;
            const string mathOperator = "-";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_Times_One_Equals_Four()
        {
            // Arrange
            const float expected = 4;
            const float firstNumber = 4;
            const float secondNumber = 1;
            const string mathOperator = "X";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_Divided_By_Two_Equals_Two()
        {
            // Arrange
            const float expected = 2;
            const float firstNumber = 4;
            const float secondNumber = 2;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const float expected = float.PositiveInfinity;
            const float firstNumber = 4;
            const float secondNumber = 0;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Minus_Four_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const float expected = float.NegativeInfinity;
            const float firstNumber = -4;
            const float secondNumber = 0;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

}
