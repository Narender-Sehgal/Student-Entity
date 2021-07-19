using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherClasses = new HashSet<TeacherClass>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Active { get; set; }
        public int? SchoolId { get; set; }

        public virtual School School { get; set; }
        public virtual ICollection<TeacherClass> TeacherClasses { get; set; }
    }
}
