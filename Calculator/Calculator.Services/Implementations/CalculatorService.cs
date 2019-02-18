using Calculator.Services.Interfaces;

namespace Calculator.Services.Implementations
{
    public class CalculatorService : ICalculatorService
    {
        public double CalculateDouble(double firstNumber, double secondNumber, string mathOperator)
        {
            double result = 0;

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
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }

        public decimal CalculateDecimal(decimal firstNumber, decimal secondNumber, string mathOperator)
        {
            decimal result = 0;

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
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }

        public float CalculateFloat(float firstNumber, float secondNumber, string mathOperator)
        {
            float result = 0;

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
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}