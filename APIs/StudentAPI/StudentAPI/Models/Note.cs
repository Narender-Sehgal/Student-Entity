using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Note1 { get; set; }
        public string CreatedBy { get; set; }

        public virtual Student Student { get; set; }
    }
}
