using Calculator.AutoFac;

namespace Calculator.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new Calculator.App(new Setup()));
        }
    }
}
