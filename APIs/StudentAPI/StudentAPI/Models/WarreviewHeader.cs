using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class WarreviewHeader
    {
        public WarreviewHeader()
        {
            WarReviewDetails = new HashSet<WarReviewDetail>();
        }

        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<WarReviewDetail> WarReviewDetails { get; set; }
    }
}
