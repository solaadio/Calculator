using Xamarin.Forms;

namespace Calculator.MVVM.View
{
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = App.MainViewModel;
        }
    }
}
