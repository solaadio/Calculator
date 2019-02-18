using Calculator.Library;

namespace Calculator.MVVM.Model
{
    /// <summary>
    /// CalculatorModel - data model passed between the view and the viewmodel
    /// </summary>
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
