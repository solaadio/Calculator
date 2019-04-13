using Autofac;
using Calculator.Library;
using Calculator.MVVM.View;
using Calculator.MVVM.ViewModel;

namespace Calculator.AutoFac
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            this.RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder cb)
        {
            cb.RegisterType<CalculatorViewModel>().As<IViewModel>().SingleInstance();
            cb.RegisterType<CalculatorView>().SingleInstance();
        }

        
    }
}