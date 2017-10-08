using Autofac;
using Fogvent.Core;
using Fogvent.Core.Extensions;
using Fogvent.Data.Common;
using Fogvent.Data.SQL;

namespace Fogvent.CrossCutting
{
    public class Modules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            string selectedProvider = "DefaultProvider".GetConfigurationValue() ?? "MSSQL";

            switch (selectedProvider)
            {
                case "MSSQL":
                    RegisterMsSqlInterfaces(builder);
                    break;

                //Add Addional Providers
                default:
                    RegisterMsSqlInterfaces(builder);
                    break;
            }

            base.Load(builder);
        }

        //Registration Area
        private void RegisterMsSqlInterfaces(ContainerBuilder builder)
        {
            // DAL
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>));
            builder.RegisterType<EfUnitOfWork>().As<IUnitOfWork>();

            //Log
            builder.RegisterType<Logger.Logger>().As<ILogger>().SingleInstance();
        }



    }
}

