using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class PinnacleQuarterHeader
    {
        public PinnacleQuarterHeader()
        {
            PinnacleQuarterClasses = new HashSet<PinnacleQuarterClass>();
            PinnacleQuarterPoints = new HashSet<PinnacleQuarterPoint>();
        }

        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string SchoolYear { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<PinnacleQuarterClass> PinnacleQuarterClasses { get; set; }
        public virtual ICollection<PinnacleQuarterPoint> PinnacleQuarterPoints { get; set; }
    }
}
