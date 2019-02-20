using System;
using Calculator.Services.Interfaces;

namespace Calculator.Services.Implementations
{
    public class CalculatorService : ICalculatorService
    {
        public double CalculateDouble(double firstNumber, double secondNumber, string mathOperator)
        {
            double result;

            switch (mathOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new ArgumentException("Unknown Operator");
            }

            return result;
        }

        public decimal CalculateDecimal(decimal firstNumber, decimal secondNumber, string mathOperator)
        {
            decimal result;

            switch (mathOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new ArgumentException("Unknown Operator");
            }

            return result;
        }

        public float CalculateFloat(float firstNumber, float secondNumber, string mathOperator)
        {
            float result;

            switch (mathOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new ArgumentException("Unknown Operator");
            }

            return result;
        }
    }
}