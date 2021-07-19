using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class PinnacleQuarterPoint
    {
        public int Id { get; set; }
        public int? PinnacleQuarterHeaderId { get; set; }
        public string Quarter { get; set; }
        public string Points { get; set; }

        public virtual PinnacleQuarterHeader PinnacleQuarterHeader { get; set; }
    }
}
