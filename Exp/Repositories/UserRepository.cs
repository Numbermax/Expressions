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
    class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(user);
                transaction.Commit();
            }
        }
              
        public User GetByLogin(string login)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var user = session
                      .CreateCriteria(typeof(User))
                      .Add(Restrictions.Eq("Login", login))
                      .UniqueResult<User>();
                return user;
            }
        }

        public void Remove(User user)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(user);
                transaction.Commit();
            }
        }

        public void Update(User user)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(user);
                transaction.Commit();
            }
        }

        public User ValidatePassword(string login,string pass)
        {
            var user = GetByLogin(login);
            if (user == null) return null;
            if (user.Password == pass)
            {
                return user;
            }
            return null;
        }

        public User GetById(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<User>(id);
            }
        }
    }
}
