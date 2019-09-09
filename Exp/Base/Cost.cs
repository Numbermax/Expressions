using System;

namespace Exp.Base
{
    public class Cost
    {
       
        public virtual int Id { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual DateTime DateEnd { get; set; }
        public virtual float CostValue { get; set; }
        public override string ToString()
        {
            return CostValue.ToString();
        }
    }
}
