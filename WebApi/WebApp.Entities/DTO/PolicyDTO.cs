using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Entities.DTO
{
    public class PolicyDTO
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDescription { get; set; }
        public int PolicyPeriod { get; set; }
        public long PolicyPrice { get; set; }
        public int RiskTypeId { get; set; }
        public int CoverageTypeId { get; set; }
        public System.DateTime PolicyStartDate { get; set; }
        public string CoverageTypeName { get; set; }
        public string RiskTypeName { get; set; }
        
    }
}
