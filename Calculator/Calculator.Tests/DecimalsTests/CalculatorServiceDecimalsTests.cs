using Calculator.Services.Implementations;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Tests.DecimalsTests
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class CalculatorServiceDecimalsTests
    {

        [Test]
        public void Test_That_One_Half_Plus_One_Half_Equals_Three()
        {
            // Arrange
            int expected = 3;
            double firstNumber = 1.5;
            double secondNumber = 1.5;
            string mathOperator = "+";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_One_Half_Plus_One_Quarter_Equals_One_Quarter()
        {
            // Arrange
            double expected = .25;
            double firstNumber = 0.5;
            double secondNumber = .25;
            string mathOperator = "-";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_One_Half_Times_One_Half_Equals_One_Quarter()
        {
            // Arrange
            double expected = .25;
            double firstNumber = .5;
            double secondNumber = .5;
            string mathOperator = "X";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Three_Divided_By_Two_Equals_One_Half()
        {
            // Arrange
            double expected = 1.5;
            int firstNumber = 3;
            int secondNumber = 2;
            string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            double expected = double.PositiveInfinity;
            double firstNumber = 4.5;
            double secondNumber = 0;
            string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Minus_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            double expected = double.NegativeInfinity;
            double firstNumber = -4.5;
            double secondNumber = 0;
            string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            double actual = service.Calculate(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }


    }

}
