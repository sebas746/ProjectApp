using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Entities;

namespace WebApp.Interfaces.Service
{
    public interface IAccountService
    {
        LoginResponse ValidateUser(string username, string password);
        bool CreateUser(User userNew);
        LoginResponse ValidateToken(string username, string token);
    }
}
