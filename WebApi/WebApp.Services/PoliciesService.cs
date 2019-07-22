using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataAccess;
using WebApp.DataContext.WebApp;
using WebApp.Entities;
using WebApp.Entities.Utilities;
using WebApp.Interfaces.DAC;
using WebApp.Interfaces.Service;

namespace WebApp.Services
{
    public class PoliciesService : IPoliciesService
    {
        public IPoliciesDAC _PoliciesDAC { get; set; }

        public PoliciesService(IPoliciesDAC PoliciesDAC)
        {
            this._PoliciesDAC = PoliciesDAC;
        }

        public List<Policy> GetAllPolicies()
        {
            try
            {
                var response = _PoliciesDAC.GetAllPolicies();
                return response;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Policy GetPolicyById(int PolicyId)
        {
            try
            {
                var response = _PoliciesDAC.GetPolicyById(PolicyId);
                return response;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
