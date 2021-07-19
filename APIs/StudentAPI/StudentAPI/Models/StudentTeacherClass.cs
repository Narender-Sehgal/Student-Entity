using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class StudentTeacherClass
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? TeacherClassId { get; set; }
        public string SchoolYear { get; set; }
        public int? ItemOrder { get; set; }
        public int? Active { get; set; }
    }
}
