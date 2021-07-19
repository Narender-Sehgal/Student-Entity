using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Studentnote
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mentor { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Note { get; set; }
        public int SchoolId { get; set; }
    }
}
