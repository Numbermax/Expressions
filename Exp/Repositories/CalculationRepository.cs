using Exp.Base;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Repositories
{
    class CalculationRepository : ICalculationRepository
    {
        public void Add(Calculation calculation)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(calculation);
                    transaction.Commit();
                }

        }

        public Calculation GetByID(int id)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<Calculation>(id);
            }
        }

        public ICollection<Calculation> GetByUserId(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var calculations = session
                      .CreateCriteria(typeof(Calculation))
                      .Add(Restrictions.Eq("UserId", id))
                      .List<Calculation>();
                return calculations;
            }
        }

        public void Remove(Calculation calculation)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(calculation);
                transaction.Commit();
            }
        }

        public void Update(Calculation calculation)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(calculation);
                transaction.Commit();
            }
        }
        public ICollection<Calculation> GetAll()
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                var calculations = session.Query<Calculation>().ToList();
                return calculations;
            }
        }
    }
}
