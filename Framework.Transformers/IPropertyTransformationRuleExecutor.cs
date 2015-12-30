

namespace Framework.Transformers
{
    /// <summary>
    /// Property ler uzerinde uygulanmasi istenen kurallari calistirir
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPropertyTransformationRuleExecutor<T>
    {
        /// <summary>
        /// Belirtilen property e maskeleme kuralini calistir
        /// </summary>
        /// <param name="propertyTransformationRule">Property ile ilgili bilgilerin belirtildigi kurallar</param>
        /// <param name="instance">Kurallarin calistirilacagi instance</param>
        /// <returns></returns>
        object MaskPropertyValue(PropertyTransformationRule<T> propertyTransformationRule, object instance);

        /// <summary>
        /// Belirtilen property nin degerinin kaldirilmasini saglar
        /// </summary>
        /// <param name="propertyTransformationRule">Property ile ilgili bilgilerin belirtildigi kurallar</param>
        /// <param name="instance">Kurallarin calistirilacagi instance</param>
        /// <returns></returns>
        object RemovePropertyValue(PropertyTransformationRule<T> propertyTransformationRule, object instance);

        object ExecuteCollectionRules(PropertyTransformationRule<T> propertyTransformationRule, IObjectTransformationRuleExecutor customRules, object instance);
  
    }
}
