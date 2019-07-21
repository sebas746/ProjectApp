using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Interfaces.DAC;
using WebApp.Interfaces.Service;

namespace WebApp.Services
{
    public class AccountService : IAccountService
    {
        public IAccountsDAC _AccountDAC { get; set; }

        public AccountService(IAccountsDAC AccountDAC)
        {
            this._AccountDAC = AccountDAC;
        }

        public bool ValidateUser(string username, string password)
        {
            try
            {
                return _AccountDAC.ValidateUser(username, password);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public bool CreateUser(User userNew)
        {
            try
            {
                return _AccountDAC.CreateUser(userNew);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
