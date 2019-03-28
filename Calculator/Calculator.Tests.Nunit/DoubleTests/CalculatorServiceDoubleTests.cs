using System;
using Calculator.Services.Implementations;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Tests.Nunit.DoubleTests
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class CalculatorServiceDoubleTests
    {

        [Test]
        public void Test_01_That_One_Half_Plus_One_Half_Equals_Three()
        {
            // Arrange
            const int expected = 3;
            const double firstNumber = 1.5f;
            const double secondNumber = 1.5f;
            const string mathOperator = "+";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDouble(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_02_That_One_Half_Minus_One_Quarter_Equals_One_Quarter()
        {
            // Arrange
            const double expected = .25f;
            const double firstNumber = 0.5f;
            const double secondNumber = .25f;
            const string mathOperator = "-";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDouble(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_03_That_One_Half_Times_One_Half_Equals_One_Quarter()
        {
            // Arrange
            const double expected = .25f;
            const double firstNumber = .5f;
            const double secondNumber = .5f;
            const string mathOperator = "X";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDouble(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_04_That_Three_Divided_By_Two_Equals_One_Half()
        {
            // Arrange
            const int firstNumber = 3;
            const int secondNumber = 2;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            //Assert
            Assert.Throws<ArgumentException>(() => service.CalculateDouble(firstNumber, secondNumber, mathOperator));
        }

        [Test]
        public void Test_05_That_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const double firstNumber = 4.5f;
            const double secondNumber = 0;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            //Assert
            Assert.Throws<ArgumentException>(() => service.CalculateDouble(firstNumber, secondNumber, mathOperator));

        }

        [Test]
        public void Test_06_That_Minus_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const double firstNumber = -4.5f;
            const double secondNumber = 0;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            //Assert
            Assert.Throws<ArgumentException>(() => service.CalculateDouble(firstNumber, secondNumber, mathOperator));
        }

        [Test]
        public void Test_07_That_Three_Divided_By_Two_Equals_One_Half()
        {
            // Arrange
            const double expected = 1.5f;
            const int firstNumber = 3;
            const int secondNumber = 2;
            const string mathOperator = "÷";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDouble(firstNumber, secondNumber, mathOperator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_08_That_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const double firstNumber = 4.5f;
            const double secondNumber = 0;
            const string mathOperator = "÷";
            const double expected = double.PositiveInfinity;
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDouble(firstNumber, secondNumber, mathOperator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_09_That_Minus_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const double firstNumber = -4.5f;
            const double secondNumber = 0;
            const string mathOperator = "÷";
            const double expected = double.NegativeInfinity;
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDouble(firstNumber, secondNumber, mathOperator);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }

}
