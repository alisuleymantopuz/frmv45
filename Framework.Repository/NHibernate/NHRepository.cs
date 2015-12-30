using System;
using System.Collections.Generic;

namespace Framework.Repository.NHibernate
{
    using System.Linq.Expressions;

    using global::NHibernate;
    using global::NHibernate.Criterion;

    public class NHRepository : INHRepository
    {

        protected ISessionFactory sessionFactory;

        public NHRepository(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public ISession GetSession()
        {
            return this.sessionFactory.GetCurrentSession();
        }

        public T GetById<T>(object id)
        {
            return this.GetSession().Get<T>(id);
        }

        public int QueryOverWithRowCount<T>(Expression<Func<T, bool>> expression) where T : class
        {
            ISession session = this.GetSession();

            int returnValue = session.QueryOver<T>().Where(expression)
                .Select(Projections.RowCount()).FutureValue<int>().Value;

            return returnValue;
        }

        public List<T> GetByQuery<T>(Expression<Func<T, bool>> expression)
        {
            ISession session = this.GetSession();

            ICriteria criteria = session.CreateCriteria(typeof(T));
            criteria.Add(Restrictions.Where(expression));

            return (List<T>)criteria.List<T>();
        }

        public List<T> GetAll<T>() where T : class
        {
            ISession session = this.GetSession();

            return session.QueryOver<T>().List<T>() as List<T>;
        }

        public void Save<T>(T domainObject)
        {
            this.GetSession().SaveOrUpdate(domainObject);
        }

        public void Remove<T>(T domainObject)
        {
            this.GetSession().Delete(domainObject);
        }

        public void Flush()
        {
            this.GetSession().Flush();
        }
    }
}
