using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fogvent.Core.Extensions;
using Ninject.Modules;

namespace Fogvent.CrossCutting
{
    public class Modules:NinjectModule
    {
        public override void Load()
        {
            var SelectedProvider = "DefaultProvider".GetConfigurationValue();
            Bind<>()
        }
    }
}
