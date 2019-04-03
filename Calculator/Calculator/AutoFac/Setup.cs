using Autofac;
using Calculator.Services.Implementations;
using Calculator.Services.Interfaces;

namespace Calculator.AutoFac
{
    public class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder cb)
        {
            base.RegisterDependencies(cb);

            cb.RegisterType<CalculatorService>().As<ICalculatorService>();
        }
    }
}