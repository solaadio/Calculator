using System;
using Calculator.Services.Implementations;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Tests.DecimalTests
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class CalculatorServiceDecimalTests
    {

        [Test]
        public void Test_That_One_Half_Plus_One_Half_Equals_Three()
        {
            // Arrange
            const decimal expected = 3;
            const decimal firstNumber = 1.5M;
            const decimal secondNumber = 1.5M;
            const string mathOperator = "+";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDecimal(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_One_Half_Minus_One_Quarter_Equals_One_Quarter()
        {
            // Arrange
            decimal expected = .25M;
            const decimal firstNumber = 0.5M;
            const decimal secondNumber = .25M;
            const string mathOperator = "-";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDecimal(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_One_Half_Times_One_Half_Equals_One_Quarter()
        {
            // Arrange
            const decimal expected = .25M;
            const decimal firstNumber = .5M;
            const decimal secondNumber = .5M;
            const string mathOperator = "X";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDecimal(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Three_Divided_By_Two_Equals_One_Half()
        {
            // Arrange
            const decimal expected = 1.5M;
            const decimal firstNumber = 3M;
            const decimal secondNumber = 2M;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            var actual = service.CalculateDecimal(firstNumber, secondNumber, mathOperator);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_That_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const decimal firstNumber = 4.5M;
            const decimal secondNumber = 0M;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            //Assert
            Assert.Throws<DivideByZeroException>(() => service.CalculateDecimal(firstNumber, secondNumber, mathOperator));
        }

        [Test]       
        public void Test_That_Minus_Four_And_Half_Divided_By_Zero_Does_Not_Crash()
        {
            // Arrange
            const decimal firstNumber = -4.5M;
            const decimal secondNumber = 0M;
            const string mathOperator = "/";
            ICalculatorService service = new CalculatorService();

            // Act
            //Assert
            Assert.Throws<DivideByZeroException>(() => service.CalculateDecimal(firstNumber, secondNumber, mathOperator));

        }


    }

}
