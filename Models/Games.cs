using System;
using System.Collections.Generic;

namespace Assign2ment.Models
{
    public partial class Games
    {
        public Games()
        {
            Customer = new HashSet<Customer>();
        }

        public string Title { get; set; }
        public int? CompanyId { get; set; }
        public int? AgeRestriction { get; set; }
        public decimal? Price { get; set; }
        public string CustomerName { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
