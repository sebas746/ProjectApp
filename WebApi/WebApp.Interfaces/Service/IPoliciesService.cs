using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Entities;

namespace WebApp.Interfaces.Service
{
    public interface IPoliciesService
    {
        List<Policy> GetAllPolicies();
        Policy GetPolicyById(int PolicyId);
    }
}
