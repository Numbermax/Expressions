using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp.Base
{
    class ValidateSchema
    {

        
        public void Go()
        {
            var configuration = new Configuration().Configure("hibernate.cfg.xml");
            configuration.AddAssembly(typeof(Calculation).Assembly);
            try
            {
                new SchemaValidator(configuration).Validate();
            }
            catch (NHibernate.SchemaValidationException ex)
            {
                var answer = MessageBox.Show($"{ex.Message} Start Db Update?", "Database invalid.",  MessageBoxButtons.OKCancel);
                if(answer == DialogResult.OK)
                {
                    BaseSchemaUpdate update = new BaseSchemaUpdate();
                    update.TextFixtureSetUp();
                }
                else
                {
                    Application.Exit();
                }                
            }
        }
    }
}
