using Calculator.Library;

namespace Calculator.MVVM.Model
{
    public class CalculatorModel : ModelBase
    {

        private int _firstNumber;
        private int _secondNumber;
        private int _currentState;
        private string _resultText;
        private string _mathOperator;

        public string ResultText
        {
            get => _resultText;
            set
            {
                _resultText = value;
                NotifyPropertyChanged();
            }
        }

        public string MathOperator
        {
            get => _mathOperator;
            set
            {
                _mathOperator = value;
                NotifyPropertyChanged();
            }
        }

        public int SecondNumber
        {
            get => _secondNumber;
            set
            {
                _secondNumber = value;
                NotifyPropertyChanged();
            }
        }

        public int FirstNumber
        {
            get => _firstNumber;
            set
            {
                _firstNumber = value;
                NotifyPropertyChanged();
            }
        }


        public int CurrentState
        {
            get => _currentState;
            set
            {
                _currentState = value;
                NotifyPropertyChanged();
            }
        }


    }
}
