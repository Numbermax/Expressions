using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp.Base;
using Exp.Repositories;
using ExspressionWorks;

namespace Exp.Logic
{
    class Operations
    {
        public string GetResultCalculation(int userId, string formula)
        {
            ExpressionWorks works = new ExpressionWorks();
            
            var timer = System.Diagnostics.Stopwatch.StartNew();
            string result = works.GetResult(formula);
            timer.Stop();
            var calculations = new CalculationRepository();
            calculations.Add(new Calculation
            {
                CalcTime = timer.ElapsedMilliseconds,
                UserId = userId,
                Formula = formula,
                Result = result,
                CreateDate = DateTime.Now
            });
            return result;

        }
        public bool LogIn(string login, int password)
        {
            var users = new UserRepository();
            var autorisedUser = users.ValidatePassword(login, password.ToString());
            if (autorisedUser != null)
            {
                Autorisation.LogIn(autorisedUser);
                return true;
            }
            return false;

        }

        public bool SigIn(string login, string fullName, int passHash)
        {
            UserRepository user = new UserRepository();

            user.Add(new User
            {
                Login = login,
                Password = passHash.ToString(),
                FullName = fullName,
                CreateDate = DateTime.Now,
                IsAdmin = false
            });
            return true;
        }       
    }
}
