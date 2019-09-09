using Exp.Base;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Repositories
{
    public class CostRepository : ICostRepository
    {
        public void Add(Cost cost)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(cost);
                transaction.Commit();
            }
        }

        public List<Cost> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var result = session.Query<Cost>().ToList();
                return result;
            }
        }

        public float GetByDate(DateTime date)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var result = session.Query<Cost>()
                    .Where(x => x.DateStart < date && x.DateEnd > date)
                    .Select(x => x.CostValue).FirstOrDefault();
                return result;
            }
        }

        public void Remove(Cost cost)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(cost);
                transaction.Commit();
            }
        }

        public void Update(Cost cost)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(cost);
                transaction.Commit();
            }
        }
    }
}
