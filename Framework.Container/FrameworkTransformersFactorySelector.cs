using System.Reflection;
using Castle.Facilities.TypedFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel;
using Framework.Transformers;

namespace Framework.Container
{
    public class FrameworkTransformersFactorySelector : DefaultTypedFactoryComponentSelector
    {
        public FrameworkTransformersList GenericComponentList { get; set; }

        public FrameworkTransformersFactorySelector(FrameworkTransformersList genericComponentList)

        {

            this.GenericComponentList = genericComponentList;

        }


 
        protected override Func<IKernelInternal, IReleasePolicy, object> BuildFactoryComponent(MethodInfo method, string componentName, Type componentType, System.Collections.IDictionary additionalArguments)

        {

            Type genericType = typeof(ObjectTransformationRule<>).MakeGenericType(additionalArguments["parameter"].GetType());


 
            if (this.GenericComponentList.ApplicationTransformersList.Where(x => x == genericType).Any())

            {

                return base.BuildFactoryComponent(method, null, genericType, additionalArguments);

            }

            return base.BuildFactoryComponent(method, null, typeof(IObjectTransformationRuleExecutor), additionalArguments);

        }

    }
}
