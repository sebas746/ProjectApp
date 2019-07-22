using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Entities.DTO;
using WebApp.Interfaces.DAC;

namespace WebApp.DataAccess
{
    public class PoliciesDAC : IPoliciesDAC
    {
        public List<PolicyDTO> GetAllPolicies()
        {
            using (WebAppDataContext dbContext = new WebAppDataContext())
            {
                var response = from policy in dbContext.Policy
                               select new PolicyDTO()
                               {
                                   CoverageTypeId = policy.CoverageTypeId,
                                   CoverageTypeName = policy.CoverageType.CoverageTypeName,
                                   PolicyDescription = policy.PolicyDescription,
                                   PolicyId = policy.PolicyId,
                                   PolicyName = policy.PolicyName,
                                   PolicyPeriod = policy.PolicyPeriod,
                                   PolicyPrice = policy.PolicyPrice,
                                   PolicyStartDate = policy.PolicyStartDate,
                                   RiskTypeId = policy.RiskTypeId,
                                   RiskTypeName = policy.RiskType.RiskTypeName
                               };

                return response.ToList();
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

        public bool CreatePolicy(Policy policy)
        {
            using (WebAppDataContext dbContext = new WebAppDataContext())
            {
                dbContext.Policy.Add(policy);
                var result = dbContext.SaveChanges();

                return (result > 0) ? true : false;
            }
        }
    }
}
