using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class StudentSign
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastSignIn { get; set; }
        public DateTime? LastSignOut { get; set; }
        public string Reason { get; set; }
        public DateTime? FilterDate { get; set; }

        public virtual Student Student { get; set; }
    }
}
