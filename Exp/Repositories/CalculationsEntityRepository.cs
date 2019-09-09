using Exp.Base;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Repositories
{
    class CalculationsEntityRepository
    {
        public List<CalculationEntity> GetCalculationEntities()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                CostRepository costs = new CostRepository();
                UserRepository users = new UserRepository();
                var calculations = session.Query<Calculation>().Select(x => new CalculationEntity
                {
                    Id = x.Id,
                    CalcTime = x.CalcTime,
                    CreateDate = x.CreateDate,
                    Formula = x.Formula,
                    Cost = "",
                    User = x.UserId.ToString()
                }).ToList();

                // затычка нужно разобраться с NHibernate лучше
                foreach (CalculationEntity  item in calculations)
                {
                    item.Cost = (costs.GetByDate(item.CreateDate) * item.CalcTime).ToString();
                    item.User = users.GetById(int.Parse(item.User)).FullName;
                }
                
                return calculations;
            }
        }
    }
}
