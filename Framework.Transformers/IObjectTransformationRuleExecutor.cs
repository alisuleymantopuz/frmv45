
namespace Framework.Transformers
{
    /// <summary>
    /// Client tarafından olusturulmus kurallari calistirir
    /// </summary>
    public interface IObjectTransformationRuleExecutor
    {
        /// <summary>
        /// Olusturulmus kurallarin, verilen instance uzerinden yeni bir kopya cikarilarak kopya uzerinde calistirilmasini saglar.
        /// </summary>
        /// <param name="instance">Kurallarin calistirilacagi nesne</param>
        /// <returns>Kurallarin calistirildi kopya nesneyi doner</returns>
        object ExecuteRules(object instance);
    }
}
