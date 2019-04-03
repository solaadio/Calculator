using Autofac;
using Calculator.AutoFac;
using Calculator.Library;
using Xamarin.Forms;

namespace Calculator.Libraries
{
    public class ViewPage<T> : ContentPage where T : IViewModel
    {
        readonly T _viewModel;
        public T ViewModel
        {
            get { return this._viewModel; }
        }

        public ViewPage()
        {
            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                this._viewModel = AppContainer.Container.Resolve<T>();
            }
            this.BindingContext = this._viewModel;
        }
    }
}