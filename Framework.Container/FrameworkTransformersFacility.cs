using Castle.MicroKernel;
using Castle.MicroKernel.Facilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Container
{
    public class FrameworkTransformersFacility : AbstractFacility
    {
        FrameworkTransformersList ComponentList;

        protected override void Init()
        {

            this.ComponentList = base.Kernel.Resolve<FrameworkTransformersList>();

            base.Kernel.ComponentRegistered += new Castle.MicroKernel.ComponentDataDelegate(Kernel_ComponentRegistered);

        }



        private void Kernel_ComponentRegistered(string key, IHandler handler)
        {

            Type assignable = typeof(IObjectTransformationRuleExecutor);

            if (handler.ComponentModel.Implementation != null)
            {

                if (assignable.IsAssignableFrom(handler.ComponentModel.Implementation))
                {

                    if (ComponentList.ApplicationTransformersList == null) ComponentList.ApplicationTransformersList = new List<Type>();

                    ComponentList.ApplicationTransformersList.Add(handler.ComponentModel.Services.FirstOrDefault());

                }

            }

        }

    }
}
