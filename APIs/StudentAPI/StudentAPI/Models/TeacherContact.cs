using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class TeacherContact
    {
        public int Id { get; set; }
        public string TeacherFullName { get; set; }
        public string Grade { get; set; }
        public string Quarter { get; set; }
        public int? SchoolYearId { get; set; }
        public DateTime? ContactDate { get; set; }
        public string ModeOfContact { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public int? StudentId { get; set; }
        public string TeacherClass { get; set; }

        public virtual SchoolYear SchoolYear { get; set; }
        public virtual Student Student { get; set; }
    }
}
