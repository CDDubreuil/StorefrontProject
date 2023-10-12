using System;
using System.Collections.Generic;

namespace Storefront.DATA.EF.Models
{
    public partial class CustomerDatum
    {
        public CustomerDatum()
        {
            Orders = new HashSet<Order>();
        }

        public string CustomerId { get; set; } = null!;
        public string? FirstName { get; set; }
        public string LastName { get; set; } = null!;
        public int OrderId { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerState { get; set; }
        public string? CustomerZip { get; set; }
        public string CustomerCountry { get; set; } = null!;
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
