using System;
using System.Collections.Generic;

namespace Framework.Repository.NHibernate
{
    using System.Linq.Expressions;

    using global::NHibernate;

    public interface INHRepository
    {
        ISession GetSession();

        T GetById<T>(object id);

        int QueryOverWithRowCount<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : class;

        List<TEntity> GetByQuery<TEntity>(Expression<Func<TEntity, bool>> expression);

        List<T> GetAll<T>() where T : class;

        void Save<T>(T domainObject);
        void Remove<T>(T domainObject);
        void Flush();
    }
}
