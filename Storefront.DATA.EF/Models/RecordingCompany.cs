using System;
using System.Collections.Generic;

namespace Storefront.DATA.EF.Models
{
    public partial class RecordingCompany
    {
        public RecordingCompany()
        {
            Artists = new HashSet<Artist>();
        }

        public int RecordLabelId { get; set; }
        public string? RecordLabelName { get; set; }
        public string RecordingCity { get; set; } = null!;
        public string RecordingState { get; set; } = null!;
        public string RecordingCountry { get; set; } = null!;
        public int? NumberOfArtistsSigned { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
