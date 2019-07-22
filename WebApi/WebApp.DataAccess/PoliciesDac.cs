using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Interfaces.DAC;

namespace WebApp.DataAccess
{
    public class PoliciesDAC : IPoliciesDAC
    {
        public List<Policy> GetAllPolicies()
        {
            using (WebAppDataContext dbContext = new WebAppDataContext())
            {
                var response =  dbContext.Policy.ToList();
                return response;
            }
        }

        public Policy GetPolicyById(int PolicyId)
        {
            using (WebAppDataContext dbContext = new WebAppDataContext())
            {
                var response = dbContext.Policy.Where(x => x.PolicyId == PolicyId).FirstOrDefault();
                return response;
            }
        }
    }
}
