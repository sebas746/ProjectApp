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
    public class ClientService : IClientService
    {
        private IClientDAC _clientDAC { get; set; }
        private IRepository<Client> _repository { get; set; }

        public ClientService(IClientDAC clientDAC, IRepository<Client> repository)
        {
            this._clientDAC = clientDAC;
            this._repository = repository;

        }

        public IEnumerable<Client> GetClients()
        {
            return _repository.Get();
        }

        public Client GetClients(int id)
        {
            return _repository.GetByID(id);
        }

    }
}
