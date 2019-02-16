using System;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {

        int _currentState = 1;
        string _mathOperator;
        double _firstNumber, _secondNumber;

        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
        }


       

        void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (this.ResultText.Text == "0" || _currentState < 0)
            {
                this.ResultText.Text = "";
                if (_currentState < 0)
                    _currentState *= -1;
            }

            this.ResultText.Text += pressed;

            double number;
            if (double.TryParse(this.ResultText.Text, out number))
            {
                this.ResultText.Text = number.ToString("N0");
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

        void OnSelectOperator(object sender, EventArgs e)
        {
            _currentState = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            _mathOperator = pressed;
        }

        void OnClear(object sender, EventArgs e)
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _currentState = 1;
            this.ResultText.Text = "0";
        }

        void OnCalculate(object sender, EventArgs e)
        {
            if (_currentState == 2)
            {
                var result = 0; // SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

                this.ResultText.Text = result.ToString("N5");
                _firstNumber = result;
                _currentState = -1;
            }
        }
    }
}
