using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class AcademicNote
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Note { get; set; }
        public string UserId { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
