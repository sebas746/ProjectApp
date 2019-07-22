using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Entities;
using WebApp.Entities.Utilities;
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

        public LoginResponse ValidateUser(string username, string password)
        {
            try
            {
                var loginResponse = new LoginResponse();
                var response = _AccountDAC.ValidateUser(username, password);

                if(response)
                {
                    var token = TokenManager.GenerateToken(username);
                    loginResponse.Message = token;
                    loginResponse.Status = "Success";
                }
                else
                {
                    loginResponse.Message = "Username or password invalid.";
                    loginResponse.Status = "Error";
                }

                return loginResponse;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public LoginResponse ValidateToken(string username, string token)
        {
            try
            {
                var loginResponse = new LoginResponse();
                var userToken = TokenManager.ValidateToken(token);

                if (userToken.Equals(username))
                {   
                    loginResponse.Message = token;
                    loginResponse.Status = "Success";
                }
                else
                {
                    loginResponse.Message = "Username or password invalid.";
                    loginResponse.Status = "Error";
                }

                return loginResponse;
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
