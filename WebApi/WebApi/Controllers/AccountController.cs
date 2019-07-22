using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.DataContext.WebApp;
using WebApp.Interfaces.Service;

namespace WebApi.Controllers
{
    public class AccountController : ApiController
    {
        public IAccountService _AccountService;

        public AccountController(IAccountService AccountService)
        {
            this._AccountService = AccountService;
        }

        [HttpPost]
        [Route("api/Account/CreateUser/")]
        public IHttpActionResult CreateUser(User userNew)
        {
            var response = _AccountService.CreateUser(userNew);
            return Ok(response);
        }

        [HttpPost]
        [Route("api/Account/ValidateUser/")]
        public IHttpActionResult ValidateUser(User user)
        {
            var response = _AccountService.ValidateUser(user.Username, user.Password);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/Account/ValidateToken/")]
        public IHttpActionResult ValidateToken(string username, string token)
        {
            var response = _AccountService.ValidateToken(username, token);
            return Ok(response);
        }
    }
}
