using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class ParentContact
    {
        public int Id { get; set; }
        public string TypeOfContact { get; set; }
        public string ModeOfContact { get; set; }
        public DateTime? Date { get; set; }
        public string ParentName { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
