namespace Calculator.MVVM.View
{
    /// <summary>
    /// CalculatorView
    /// </summary>
    public partial class CalculatorView
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = App.MainViewModel;
        }
    }
}
