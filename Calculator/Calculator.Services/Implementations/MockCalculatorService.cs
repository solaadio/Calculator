using Calculator.Services.Interfaces;

namespace Calculator.Services.Implementations
{
    public class MockCalculatorService : IMockCalculatorService
    {
        public int OnePlusOne()
        {
            return 2;
        }
    }
}
