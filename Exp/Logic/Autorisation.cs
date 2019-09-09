using Exp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Logic
{
    public static class Autorisation
    {
        static User _user = new User();
        public static void LogIn(User user)
        {
            _user = user;
        } 
        public static User GetAutorisedUser()
        {
            return _user;
        }
        public static string GetName()
        {
            return _user.FullName;
        }
        public static bool IsAdmin()
        {
            return _user.IsAdmin;
        }
        public static int GetUserId()
        {
            return _user.Id;
        }


    }
}
