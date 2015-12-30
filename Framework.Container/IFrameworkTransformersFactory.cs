using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Transformers;

namespace Framework.Container
{
  public interface IFrameworkTransformersFactory
    {
        IObjectTransformationRuleExecutor GetTransformersWithParam(object parameter);

        void Release(object instance);

    }
}
