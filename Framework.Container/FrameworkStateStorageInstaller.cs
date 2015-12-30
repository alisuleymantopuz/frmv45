using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Framework.StateStorage;
namespace Framework.Container
{
    public class FrameworkStateStorageInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<StateStorageConfiguration>().LifestyleSingleton());
            container.Register(Component.For<IStateStorageStrategy<string, CacheItem>>().ImplementedBy<AppFabricCacheStateStorageStrategy>().LifeStyle.Singleton);
            container.Register(Component.For<IStateStorageStrategy<string, CacheItem>>().ImplementedBy<AspNetCachingStateStorageStrategy>().LifeStyle.Singleton);
            container.Register(Component.For<IStateStorageStrategy<string, CacheItem>>().ImplementedBy<HttpContextStateStorageStrategy>().LifeStyle.Singleton);
            container.Register(Component.For<IStateStorageStrategy<string, CacheItem>>().ImplementedBy<InMemoryStateStorageStrategy>().LifeStyle.Singleton);
            
        }
    }
}
