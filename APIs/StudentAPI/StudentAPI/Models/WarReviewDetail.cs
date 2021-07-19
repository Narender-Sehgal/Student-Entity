using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class WarReviewDetail
    {
        public int Id { get; set; }
        public int WarreviewHeaderId { get; set; }
        public string HomeWork { get; set; }
        public bool? HomeWorkCompleted { get; set; }

        public virtual WarreviewHeader WarreviewHeader { get; set; }
    }
}
