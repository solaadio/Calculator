using Calculator.Library;

namespace Calculator.MVVM.Model
{
    public class CalculatorModel : ModelBase
    {
        private string _resultText;

        public string ResultText
        {
            get => _resultText;
            set
            {
                _resultText = value;
                NotifyPropertyChanged();
            }
        }

    }
}
