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
    class CalculationRepository_Fixture
    {
        private ISessionFactory _sessionFactory;
        private Configuration _configuration;

        public void TextFixtureSetUp()
        {
            _configuration = new Configuration().Configure("hibernate.cfg.xml");
            _configuration.AddAssembly(typeof(Calculation).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();
        }
        public void SetupContext()
        {
            new SchemaExport(_configuration).Execute(false, true, false);
            
                
        }
    }
}
