
using System;
using System.Collections.Generic;

namespace Exp.Base
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual string FullName { get; set; }
        public virtual bool IsAdmin { get; set; }
       

        public override string ToString()
        {
            return FullName;
        }
    }
}
