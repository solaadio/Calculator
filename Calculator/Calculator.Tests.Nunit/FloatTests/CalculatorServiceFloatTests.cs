using System;
using Calculator.Services.Implementations;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Tests.Nunit.FloatTests
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class CalculatorServiceFloatTests
    {

        [Test]
        public void Test_01_That_One_Half_Plus_One_Half_Equals_Three()
        {
            // Arrange
            const int expected = 3;
            const float firstNumber = 1.5f;
            const float secondNumber = 1.5f;
            const string mathOperator = "+";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_02_That_One_Half_Minus_One_Quarter_Equals_One_Quarter()
        {
            // Arrange
            const float expected = .25f;
            const float firstNumber = 0.5f;
            const float secondNumber = .25f;
            const string mathOperator = "-";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_03_That_One_Half_Times_One_Half_Equals_One_Quarter()
        {
            // Arrange
            const float expected = .25f;
            const float firstNumber = .5f;
            const float secondNumber = .5f;
            const string mathOperator = "X";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


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
            Assert.Throws<ArgumentException>(() => service.CalculateFloat(firstNumber, secondNumber, mathOperator));
        }

        [Test]
        public void Test_05_That_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const float firstNumber = 4.5f;
            const float secondNumber = 0;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            //Assert
            Assert.Throws<ArgumentException>(() => service.CalculateFloat(firstNumber, secondNumber, mathOperator));
        }

        [Test]
        public void Test_06_That_Minus_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const float firstNumber = -4.5f;
            const float secondNumber = 0;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            //Assert
            Assert.Throws<ArgumentException>(() => service.CalculateFloat(firstNumber, secondNumber, mathOperator));
        }


        [Test]
        public void Test_07_That_Three_Divided_By_Two_Equals_One_Half()
        {
            // Arrange
            const float expected = 1.5f;
            const int firstNumber = 3;
            const int secondNumber = 2;
            const string mathOperator = "÷";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_08_That_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const float expected = float.PositiveInfinity;
            const float firstNumber = 4.5f;
            const float secondNumber = 0;
            const string mathOperator = "÷";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_09_That_Minus_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const float expected = float.NegativeInfinity;
            const float firstNumber = -4.5f;
            const float secondNumber = 0;
            const string mathOperator = "÷";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateFloat(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

}
