using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class StudentTeacher
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherClassId { get; set; }
        public int? ItemOrder { get; set; }
        public string SchoolYear { get; set; }
        public bool? Active { get; set; }

        public virtual Student Student { get; set; }
        public virtual TeacherClass TeacherClass { get; set; }
    }
}
