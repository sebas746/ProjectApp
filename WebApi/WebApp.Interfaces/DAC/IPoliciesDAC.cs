using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Entities.DTO;

namespace WebApp.Interfaces.DAC
{
    public interface IPoliciesDAC
    {
        List<PolicyDTO> GetAllPolicies();
        Policy GetPolicyById(int PolicyId);
        bool CreatePolicy(Policy policy);
    }
}
