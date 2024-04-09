using Ems.data;
using Ems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ems.Services
{
    public class LoginServices
    {
        private readonly DbContextDemo _dbContextDemo;
        public LoginServices(DbContextDemo dbContext)
        {
            _dbContextDemo=dbContext;
        }
        /*public List<LoginDetails> GetLoginDetails()
        {
            return _dbContextDemo.LoginDetails.ToList();
        }*/
        public string AddLoginDetails(LoginDetails details)
        {
            bool found = _dbContextDemo.LoginDetails.Any(a => a.EmpId == details.EmpId);
            if (found)
            {
                return "Already exists";
            }
            else
            {
                _dbContextDemo.LoginDetails.Add(details);
                _dbContextDemo.SaveChanges();
                return "user details added";
            }
            
        }
        public bool VerifyUser(LoginDetails details)
        {
            var found = _dbContextDemo.LoginDetails.Any(a => a.EmpId == details.EmpId);
            if (found)
            {
                var res=_dbContextDemo.LoginDetails.Find(details.EmpId);
                if(details.EmpId == res.EmpId && details.Password == res.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
        
    }
}
