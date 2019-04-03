using Calculator.Library;

namespace Calculator.MVVM.View
{
    /// <summary>
    /// CalculatorView
    /// </summary>
    public partial class CalculatorView 
    {
        public CalculatorView(IViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
