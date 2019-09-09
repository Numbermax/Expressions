using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Base
{
    public interface ICalculationRepository
    {
        void Add(Calculation calculation);
        void Update(Calculation calculation);
        void Remove(Calculation calculation);
        Calculation GetByID(int id);
        ICollection<Calculation> GetByUserId(int id);
    }
}
