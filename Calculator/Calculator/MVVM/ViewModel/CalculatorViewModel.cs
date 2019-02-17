using System.Windows.Input;
using Calculator.Libraries;
using Calculator.MVVM.Model;
using Xamarin.Forms;

namespace Calculator.MVVM.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {

        CalculatorModel CalculatorModel = new CalculatorModel();

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
            get => CalculatorModel.ResultText;
            set
            {
                CalculatorModel.ResultText = value;
                NotifyPropertyChanged();
            }
        }

        private void OnClear()
        {
            CalculatorModel.FirstNumber = 0;
            CalculatorModel.SecondNumber = 0;
            CalculatorModel.CurrentState = 1;
            ResultText = "0";
        }

        void OnSelectNumber(object buttonPressed)
        {
            string pressed = buttonPressed.ToString();

            if (ResultText == "0" || CalculatorModel.CurrentState < 0)
            {
                ResultText = "";
                if (CalculatorModel.CurrentState < 0)
                    CalculatorModel.CurrentState *= -1;
            }

            ResultText += pressed;

            if (double.TryParse(ResultText, out double number))
            {
                ResultText = number.ToString("N0");
                if (CalculatorModel.CurrentState == 1)
                {
                    CalculatorModel.FirstNumber = (int)number;
                }
                else
                {
                    CalculatorModel.SecondNumber = (int)number;
                }
            }
        }

        void OnSelectOperator(object operatorButton)
        {
            CalculatorModel.CurrentState = -2;
            string pressed = operatorButton.ToString();
            CalculatorModel.MathOperator = pressed;
        }

        void OnCalculate()
        {
            if (CalculatorModel.CurrentState == 2)
            {
                var result = 0; // SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

                ResultText = result.ToString("N5");
                CalculatorModel.FirstNumber = result;
                CalculatorModel.CurrentState = -1;
            }
        }
    }
}
