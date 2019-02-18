using System.Collections.Generic;
using System.Text;

namespace Calculator.Services.Interfaces
{
    public interface ICalculatorService
    {
        double CalculateDouble(double firstNumber, double secondNumber, string mathOperator);

        decimal CalculateDecimal(decimal firstNumber, decimal secondNumber, string mathOperator);

        float CalculateFloat(float firstNumber, float secondNumber, string mathOperator);
    }
}
