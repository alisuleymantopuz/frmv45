
namespace Framework.Transformers
{
    /// <summary>
    /// Nesneleri kopyalamak icin kullanilir
    /// </summary>
    public interface IObjectCopier
    {
        /// <summary>
        /// Verilen nesnenin eski referansindan bagimsiz, yeni bir kopyasını olusturur.
        /// </summary>
        /// <param name="source">Kaynak nesne</param>
        /// <param name="target">Hedef nesne</param>
        void CopyObjectData(object source, object target);
    }
}
