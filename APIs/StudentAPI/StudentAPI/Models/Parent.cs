using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Parent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relation { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? SendNotification { get; set; }

        public virtual Student Student { get; set; }
    }
}
