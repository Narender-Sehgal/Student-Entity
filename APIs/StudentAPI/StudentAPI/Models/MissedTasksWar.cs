using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class MissedTasksWar
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Class { get; set; }
        public string Task { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
    }
}
