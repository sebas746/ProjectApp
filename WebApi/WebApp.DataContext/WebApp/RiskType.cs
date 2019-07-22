using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DataContext.WebApp
{
    public class RiskType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RiskType()
        {
            this.Policies = new HashSet<Policy>();
        }

        public int RiskTypeId { get; set; }
        public string RiskTypeName { get; set; }
        public string RiskTypeDescription { get; set; }
        public int RiskTypePercentageCoverage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policy> Policies { get; set; }
    }
}
