using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Container
{
    public class FrameworkTransformersInstaller<T> : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<FrameworkTransformersList>().LifestyleSingleton());

            container.AddFacility<FrameworkTransformersFacility>();

            container.Register(Component.For<IFrameworkTransformersFactory>().AsFactory(s => s.SelectedWith<FrameworkTransformersFactorySelector>()),

                               Component.For<IObjectTransformationRuleExecutor>().ImplementedBy<EmptyTransformers>().IsDefault(),

                               Component.For<FrameworkTransformersFactorySelector>());

            container.Register(Classes.FromAssemblyContaining(typeof(T))

                                          .BasedOn(typeof(ObjectTransformationRule<>))

                                          .WithService.Base()

                                          .Configure(c => c.LifestyleTransient()));

        }
    }
}
