using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using WebApp.DataContext.WebApp;
using WebApp.Interfaces.DAC;

namespace WebApp.DataAccess
{
    public class AccountsDAC : IAccountsDAC
    {

        /// <summary>  
        ///   
        /// </summary>  
        /// <param name="username"></param>  
        /// <param name="password"></param>  
        /// <returns></returns>  
        public bool ValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            using (WebAppDataContext dbContext = new WebAppDataContext())
            {
                var user = (from us in dbContext.Users
                            where string.Compare(username, us.Username, StringComparison.OrdinalIgnoreCase) == 0
                            && string.Compare(password, us.Password, StringComparison.OrdinalIgnoreCase) == 0
                            && us.IsActive == true
                            select us).FirstOrDefault();

                return (user != null) ? true : false;
            }
        }

        public bool CreateUser(User userNew)
        {
            //Save User Data   
            using (WebAppDataContext dbContext = new WebAppDataContext())
            {
                var user = new User()
                {
                    Username = userNew.Username,
                    FirstName = userNew.FirstName,
                    LastName = userNew.LastName,
                    Email = userNew.Email,
                    Password = userNew.Password,
                    IsActive = true,
                    ActivationCode = Guid.NewGuid(),
                };

                dbContext.Users.Add(user);
                var result = dbContext.SaveChanges();

                return (result > 0) ? true : false;
            }
        }

    }
}
