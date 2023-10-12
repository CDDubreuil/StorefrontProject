using System;
using System.Collections.Generic;

namespace Storefront.DATA.EF.Models
{
    public partial class RecordOrder
    {
        public RecordOrder()
        {
            Records = new HashSet<Record>();
        }

        public int RecordOrderId { get; set; }
        public int? OrderId { get; set; }
        public int? RecordId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
