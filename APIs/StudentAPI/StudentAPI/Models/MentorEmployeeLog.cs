using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class MentorEmployeeLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string EmployeeAction { get; set; }
        public string Consequences { get; set; }
        public string SupervisorResponse { get; set; }
        public string Username { get; set; }
        public DateTime? DateLog { get; set; }
    }
}
