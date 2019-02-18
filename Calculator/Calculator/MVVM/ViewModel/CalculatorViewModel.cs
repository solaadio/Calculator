using System;
using System.Globalization;
using System.Windows.Input;
using Calculator.Library;
using Calculator.MVVM.Model;
using Calculator.Services.Interfaces;
using Xamarin.Forms;

namespace Calculator.MVVM.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {
        private readonly CalculatorModel _calculatorModel = new CalculatorModel();
        private readonly ICalculatorService _service;
        private double _firstNumber;
        private double _secondNumber;
        private int _currentState;
        private string _mathOperator;

        public CalculatorViewModel(ICalculatorService service)
        {
            _service = service;
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
                var result = _service.Calculate(_firstNumber, _secondNumber, _mathOperator);

                var tempResult = Convert.ToString(result);
                if (tempResult.Length > 10)
                {
                    tempResult = result.ToString("e8");
                }
                else
                {
                    tempResult = result.ToString("N");
                }

                ResultText = tempResult;
                _firstNumber = result;
                _currentState = -1;
            }
        }
    }
}
