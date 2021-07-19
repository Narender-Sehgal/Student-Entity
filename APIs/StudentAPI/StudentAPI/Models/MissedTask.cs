using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class MissedTask
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Task { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public string Class { get; set; }
        public string UserId { get; set; }

        public virtual Student Student { get; set; }
    }
}
