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

        [Test]
        public void Test_That_One_Minus_One_Equals_Zero()
        {
            // Arrange
            int expected = 0;
            int firstNumber = 1;
            int secondNumber = 1;
            string mathOperator = "-";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_Times_One_Equals_Four()
        {
            // Arrange
            int expected = 4;
            int firstNumber = 4;
            int secondNumber = 1;
            string mathOperator = "X";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_Divided_By_Two_Equals_Two()
        {
            // Arrange
            int expected = 2;
            int firstNumber = 4;
            int secondNumber = 2;
            string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            double expected = double.PositiveInfinity;
            int firstNumber = 4;
            int secondNumber = 0;
            string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Minus_Four_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            double expected = double.NegativeInfinity;
            int firstNumber = -4;
            int secondNumber = 0;
            string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

}
