using Autofac;

namespace Fogvent.CrossCutting
{
    public class ContainerConfig
    {
        public IContainer ConfigureAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new Modules());

            return builder.Build();
        }
    }
}
