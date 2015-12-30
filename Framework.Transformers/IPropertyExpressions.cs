using System;
using System.Linq.Expressions;

namespace Framework.Transformers
{
    /// <summary>
    /// Expression lardan property degerlerinin okunup degistirilmesini saglar
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPropertyExpressions<T>
    {
        /// <summary>
        /// Verilen expression ı instance uzerinde calistirarak property degerini okur
        /// </summary>
        /// <param name="instance">Property degerinin okunacagi instance</param>
        /// <param name="memberLamda">Instance ın uzerinde calistirilacak expression</param>
        /// <returns></returns>
        object ReadReadPropertyValue(object instance, Expression<Func<T, object>> memberLamda);
        /// <summary>
        /// Verilen expression ı instance uzerinde calistirarak property degerini verilen deger ile degistirir
        /// </summary>
        /// <param name="instance">Property degerinin degistirilecegi instance</param>
        /// <param name="memberLamda">Instance uzerinde calistirilacak expression</param>
        /// <param name="value">Property nin yeni degeri</param>
        void SetPropertyValue(object instance, Expression<Func<T, object>> memberLamda, object value);
    }
}
