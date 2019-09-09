using Exp.Repositories;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Base
{
    class BaseSchemaUpdate
    {
        //private ISessionFactory _sessionFactory;
        private Configuration _configuration;

        public void TextFixtureSetUp()
        {
            _configuration = new Configuration().Configure("hibernate.cfg.xml");
            _configuration.AddAssembly(typeof(Calculation).Assembly);            
            //_sessionFactory = _configuration.BuildSessionFactory();
            new SchemaExport(_configuration).Execute(false, true, false);
            UserRepository users = new UserRepository();
            users.Add(new User
            {
                Login = "admin",
                Password = "admin".GetHashCode().ToString(),
                FullName = "Mr. Main Admin",
                CreateDate = DateTime.Now,
                IsAdmin = true
            });
            users.Add(new User
            {
                Login = "Guest",
                Password = "Guest".GetHashCode().ToString(),
                FullName = "NoName Guest",
                CreateDate = DateTime.Now,
                IsAdmin = false
            });
            
        }
       
        public void SetupContext()
        {
            new SchemaExport(_configuration).Execute(false, true, false);


        }

    }
}
