using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataContext.WebApp;
using WebApp.Entities.DTO;

namespace WebApp.Entities.Utilities
{
    public static class ConvertDTO
    {
        public static PolicyDTO ConvertToPolicyDTO(Policy policy)
        {
            return new PolicyDTO
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
        }

        public static List<PolicyDTO> ConvertToPolicyDTO(List<Policy> policies)
        {
            var policiesDTO = new List<PolicyDTO>();
            foreach(var policy in policies)
            {
                var pol = new PolicyDTO
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
                policiesDTO.Add(pol);
            }
            return policiesDTO;
        }
    }
}
