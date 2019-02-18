using Calculator.Services.Interfaces;

namespace Calculator.Services.Implementations
{
    public class CalculatorService : ICalculatorService
    {
        public double Calculate(double firstNumber, double secondNumber, string mathOperator)
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
            }

            return result;
        }
    }
}