using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Entities;
using WebApp.Entities.DTO;

namespace WebApp.Interfaces.Service
{
    public interface IPoliciesService
    {
        List<PolicyDTO> GetAllPolicies();
        Policy GetPolicyById(int PolicyId);
        TransactionResponse CreatePolicy(Policy policy);
    }
}
