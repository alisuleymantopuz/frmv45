
using Omu.ValueInjecter;

namespace Framework.Transformers
{

    public class ObjectCopier : IObjectCopier
    {
        public void CopyObjectData(object source, object target)
        {
            target.InjectFrom<CloneInjection>(source);
        }

    }    
}
