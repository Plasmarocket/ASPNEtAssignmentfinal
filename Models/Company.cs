using System;
using System.Collections.Generic;

namespace Assign2ment.Models
{
    public partial class Company
    {
        public Company()
        {
            Customer = new HashSet<Customer>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCeo { get; set; }
        public int? CompanyAge { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
