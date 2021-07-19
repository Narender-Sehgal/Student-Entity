using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class CenterSchool
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public int SchoolId { get; set; }

        public virtual Center Center { get; set; }
        public virtual School School { get; set; }
    }
}
