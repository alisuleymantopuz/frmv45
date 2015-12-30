
namespace Framework.Transformers
{
    /// <summary>
    /// Property uzerinde calistirilabilecek kurallari barindirir
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPropertyTransformationRuleSetup<T>
    {
        /// <summary>
        /// Belirtilen property icin maskeleme kurali olusturur
        /// </summary>
        /// <param name="howManyEarlyDigistShouldNotToBeMask">Propertynin degerinin ilk kac hanesi maskelenmeyecegini belirtir</param>
        /// <param name="howManyLastDigistShouldNotToBeMask">Propertynin degerinin son kac hanesi maskelenmeyecegini belirtir</param>
        void ShouldBeMasked(int howManyEarlyDigistShouldNotToBeMask, int howManyLastDigistShouldNotToBeMask);
        /// <summary>
        /// Belirtilen propertynin  degerini kaldirmak icin bir kural olusturur.
        /// </summary>
        void ShouldBeRemoved();

        /// <summary>
        /// Collectionlar için rule customizasyonu
        /// </summary>
        /// <param name="collectionRule"></param>
        void SetCollectionRules(IObjectTransformationRuleExecutor collectionRule);
  

    }
}
