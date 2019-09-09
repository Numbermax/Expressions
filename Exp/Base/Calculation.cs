
using System;
namespace Exp.Base
{
    public class Calculation
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string Formula { get; set; }
        public virtual long CalcTime { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Result { get; set; }
        public override string ToString()
        {
            return Formula;
        }
    }
}
