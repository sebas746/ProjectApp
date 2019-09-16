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
    [Authorize]
    public class ClientsController : ApiController
    {
        public IClientService _ClientService;

        public ClientsController(IClientService ClientService)
        {
            this._ClientService = ClientService;
        }

        [HttpGet]
        public IEnumerable<Client> GetClients()
        {
            return _ClientService.GetClients();
        }

        [HttpGet]
        public Client GetClients(int id)
        {
            return _ClientService.GetClients(id);
        }
    }
}
