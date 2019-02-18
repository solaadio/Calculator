using System.Collections.Generic;
using System.Text;

namespace Calculator.Services.Interfaces
{
    public interface ICalculatorService
    {
        double Calculate(double firstNumber, double secondNumber, string mathOperator);
    }
}
