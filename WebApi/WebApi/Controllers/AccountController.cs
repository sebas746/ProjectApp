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

        [HttpGet]
        [Route("api/Account/ValidateUser/")]
        public IHttpActionResult ValidateUser(string username, string password)
        {
            var response = _AccountService.ValidateUser(username, password);
            return Ok(response);
        }
    }
}
