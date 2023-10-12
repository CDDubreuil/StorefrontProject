﻿using System;
using System.Collections.Generic;

namespace Storefront.DATA.EF.Models
{
    public partial class ProductStatus
    {
        public ProductStatus()
        {
            Records = new HashSet<Record>();
        }

        public int StatusId { get; set; }
        public string? RecordName { get; set; }
        public string? ProductStatus1 { get; set; }
        public string? StatusDescription { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
