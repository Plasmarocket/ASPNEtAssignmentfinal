using System;
using System.Collections.Generic;

namespace Assign2ment.Models
{
    public partial class Customer
    {
        public string CustomerName { get; set; }
        public string Title { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Games TitleNavigation { get; set; }
    }
}
