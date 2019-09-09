using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Base
{
    public interface ICostRepository
    {
        void Add(Cost cost);
        float GetByDate(DateTime date);
        void Update(Cost cost);
        void Remove(Cost cost);
        List<Cost> GetAll();
    }
}
