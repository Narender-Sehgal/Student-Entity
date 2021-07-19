using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Query
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? Date { get; set; }
        public string ParentName { get; set; }
        public string TypeOfContact { get; set; }
        public string ModeOfContact { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
    }
}
