using Calculator.MVVM.View;
using Calculator.MVVM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Calculator
{
    public partial class App : Application
    {
        public static CalculatorViewModel MainViewModel { get; }

        static App()
        {
            MainViewModel = new CalculatorViewModel();
        }

        public App()
        {
            InitializeComponent();
            MainPage = new CalculatorView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
