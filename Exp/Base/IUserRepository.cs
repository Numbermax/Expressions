using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Base
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        User GetById(int id);
        User GetByLogin(string login);
        User ValidatePassword(string login,string pass);
        void Remove(User user);
    }
}
