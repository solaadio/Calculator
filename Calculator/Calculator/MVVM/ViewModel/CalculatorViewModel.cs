using System.Windows.Input;
using Calculator.Library;
using Calculator.MVVM.Model;
using Xamarin.Forms;

namespace Calculator.MVVM.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {
        private readonly CalculatorModel _calculatorModel = new CalculatorModel();
        private int _firstNumber;
        private int _secondNumber;
        private int _currentState;
        private string _mathOperator;

        public CalculatorViewModel()
        {
            OnClear();
        }


        #region Commands

        public ICommand OnClearCommand => new Command(OnClear);

        public ICommand OnSelectNumberCommand => new Command(OnSelectNumber);

        public ICommand OnSelectOperatorCommand => new Command(OnSelectOperator);

        public ICommand OnCalculateCommand => new Command(OnCalculate);

        #endregion

        public string ResultText
        {
            get => _calculatorModel.ResultText;
            set
            {
                _calculatorModel.ResultText = value;
                NotifyPropertyChanged();
            }
        }

        private void OnClear()
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _currentState = 1;
            ResultText = "0";
        }

        void OnSelectNumber(object buttonPressed)
        {
            string pressed = buttonPressed.ToString();

            if (ResultText == "0" || _currentState < 0)
            {
                ResultText = "";
                if (_currentState < 0)
                    _currentState *= -1;
            }

            ResultText += pressed;

            if (double.TryParse(ResultText, out double number))
            {
                ResultText = number.ToString("N0");
                if (_currentState == 1)
                {
                    _firstNumber = (int)number;
                }
                else
                {
                    _secondNumber = (int)number;
                }
            }
        }

        void OnSelectOperator(object operatorButton)
        {
            _currentState = -2;
            string pressed = operatorButton.ToString();
            _mathOperator = pressed;
        }

        void OnCalculate()
        {
            if (_currentState == 2)
            {
                var result = 0; // SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

                ResultText = result.ToString("N5");
                _firstNumber = result;
                _currentState = -1;
            }
        }
    }
}
