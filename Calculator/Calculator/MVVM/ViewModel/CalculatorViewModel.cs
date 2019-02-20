using System.Globalization;
using System.Windows.Input;
using Calculator.Library;
using Calculator.MVVM.Model;
using Calculator.Services.Interfaces;
using Xamarin.Forms;

// ReSharper disable once IdentifierTypo
namespace Calculator.MVVM.ViewModel
{
    /// <inheritdoc />
    /// <summary>
    /// CalculatorViewModel class
    /// </summary>
    public class CalculatorViewModel : ViewModelBase
    {

        #region Private members

        private readonly CalculatorModel _calculatorModel = new CalculatorModel();
        private readonly ICalculatorService _service;
        private float _firstNumber;
        private float _secondNumber;
        private int _currentState;
        private string _mathOperator;

        #endregion

        #region Constructor

        public CalculatorViewModel(ICalculatorService service)
        {
            _service = service;
            OnClear();
        }

        #endregion

        #region Commands

        public ICommand OnClearCommand => new Command(OnClear);

        public ICommand OnClearCeCommand => new Command(OnClearCe);

        public ICommand OnSelectNumberCommand => new Command(OnSelectNumber);

        public ICommand OnSelectOperatorCommand => new Command(OnSelectOperator);

        public ICommand OnCalculateCommand => new Command(OnCalculate);

        #endregion

        #region Public Properties

        public string ResultText
        {
            get => _calculatorModel.ResultText;
            set
            {
                _calculatorModel.ResultText = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Private methods

        private void OnClear()
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _currentState = 1;
            ResultText = "0";
        }

        private void OnClearCe()
        {
           
            if (_currentState == 1 || _currentState == -1)
            {
                _firstNumber = 0;
            }
            else
            {
                if (_currentState == 2 || _currentState == -2)
                    _secondNumber = 0;
            }
            ResultText = "0";
        }

        private void OnSelectNumber(object buttonPressed)
        {
            string pressed = buttonPressed.ToString();

            if (ResultText == "0" || _currentState < 0)
            {
                ResultText = "";
                if (_currentState < 0)
                    _currentState *= -1;
            }

            if (_currentState > 0 && ResultText.Length > 8)
            {
                return;
            }

            string resultText = ResultText + pressed;

            if (resultText == ".")
            {
                resultText = "0.";
            }

            if (float.TryParse(resultText, out float number))
            {
                ResultText = resultText;
                if (_currentState == 1)
                {
                    _firstNumber = number;
                }
                else
                {
                    _secondNumber = number;
                }
            }
        }

        private void OnSelectOperator(object operatorButton)
        {
            _currentState = -2;
            var pressed = operatorButton.ToString();
            _mathOperator = pressed;
        }

        private void OnCalculate()
        {
            if (_currentState == 2)
            {
                var result = _service.CalculateFloat(_firstNumber, _secondNumber, _mathOperator);
                var tempResult = result.ToString(CultureInfo.CurrentCulture);

                ResultText = tempResult;
                _firstNumber = result;
                _currentState = -1;
            }
        }

        #endregion
    }
}
