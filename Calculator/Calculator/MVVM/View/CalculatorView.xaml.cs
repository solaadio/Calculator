using Xamarin.Forms;

namespace Calculator.MVVM.View
{
    public partial class CalculatorView
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = App.MainViewModel;
        }
    }
}
