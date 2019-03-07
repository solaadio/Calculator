using System.Windows.Input;
using Calculator.Library;
using Calculator.Library.Extensions;
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
        private double _firstNumber;
        private double _secondNumber;
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

        public ICommand OnToggleNegateCommand => new Command(OnToggleNegate);


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

        public string HistoryText
        {
            get => _calculatorModel.HistoryText;
            set
            {
                _calculatorModel.HistoryText = value;
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
            HistoryText = "";
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

            if (double.TryParse(resultText, out double number))
            {
                ResultText = resultText.FormatWithThousandsSeparator();
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
            HistoryText = ResultText + " " + _mathOperator + " ";
        }

        private void OnCalculate()
        {
            if (_currentState == 2)
            {
                var result = _service.CalculateDouble(_firstNumber, _secondNumber, _mathOperator);
                var tempResult = result.ToString();

                // we don't want infinity results to be processed
                if (!double.IsPositiveInfinity(result) && !double.IsNegativeInfinity(result))
                {
                    tempResult = result.ToString("").FormatWithThousandsSeparator();
                }

                ResultText = tempResult;
                _firstNumber = result;
                _currentState = -1;
                HistoryText = "";

            }
        }

        private void OnToggleNegate()
        {

            if (_currentState == 1 || _currentState == -1)
            {
                if (_firstNumber.Equals(0))
                    return;
                _firstNumber = _firstNumber * -1;
                ResultText = _firstNumber.ToString("").FormatWithThousandsSeparator();
            }
            else
            {
                if (_currentState == 2 || _currentState == -2)
                {
                    if (_secondNumber.Equals(0))
                        return;
                    _secondNumber = _secondNumber * -1;
                    ResultText = _secondNumber.ToString("").FormatWithThousandsSeparator();
                }
            }
        }


        #endregion
    }
}
