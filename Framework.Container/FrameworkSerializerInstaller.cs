using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Framework.Serialization;

namespace Framework.Container
{
    public class FrameworkSerializerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ISerializer<string, object>>().ImplementedBy<XmlSerializationObject>().LifeStyle.Singleton);
            container.Register(Component.For<ISerializer<byte[], object>>().ImplementedBy<BinarySerializationObject>().LifeStyle.Singleton);
            container.Register(Component.For<ISerializer<string, object>>().ImplementedBy<JsonSerializationObject>().LifeStyle.Singleton);

        }
    }
}
