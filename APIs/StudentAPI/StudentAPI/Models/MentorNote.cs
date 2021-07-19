using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class MentorNote
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Notes { get; set; }
        public DateTime? DateLog { get; set; }
        public string UserName { get; set; }
    }
}
