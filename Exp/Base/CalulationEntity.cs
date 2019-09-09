using System;

namespace Exp.Base
{
    class CalculationEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Formula { get; set; }
        public string User { get; set; }
        public long CalcTime { get; set; }
        public string Cost { get; set; }

    }
}
