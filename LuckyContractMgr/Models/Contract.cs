using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuckyContractMgr.Models
{
    public class Contract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string VendorCompanyName { get; set; }
        public string VendorContactPerson { get; set; }
        public string RFQNumber { get; set; }
        public string PONumber { get; set; }
        public string ScopeOfWork { get; set; }
        public string PaymentTerms { get; set; }
        public string TerminationTerms { get; set; }
        public DateTime ContractExecutedOn { get; set; }
        public DateTime ContractTerminateOn { get; set; }

    }
}
