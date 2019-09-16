using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Interfaces.DAC;

namespace WebApp.DataAccess
{
    public class ClientsDAC : IClientDAC
    {
        private WebAppDataContext _context;
        public ClientsDAC(WebAppDataContext context)
        {
            this._context = context;
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients;
        }

    }
}
