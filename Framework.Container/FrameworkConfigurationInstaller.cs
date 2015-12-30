using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FrameworkRepository = Framework.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Framework.Container
{
    public class FrameworkConfigurationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<FrameworkRepository.IConfigurationStore>().ImplementedBy<FrameworkRepository.ConfigurationStore>().LifeStyle.Singleton);
            container.Register(Component.For<FrameworkRepository.FrameworkConfiguration>().LifestyleSingleton());
        }
    }
}
