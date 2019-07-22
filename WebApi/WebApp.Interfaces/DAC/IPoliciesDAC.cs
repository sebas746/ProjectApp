using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;

namespace WebApp.Interfaces.DAC
{
    public interface IPoliciesDAC
    {
        List<Policy> GetAllPolicies();
        Policy GetPolicyById(int PolicyId);
    }
}
