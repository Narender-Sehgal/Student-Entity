using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class TeacherClass
    {
        public TeacherClass()
        {
            PinnacleQuarterClasses = new HashSet<PinnacleQuarterClass>();
            PinnacleSemesters = new HashSet<PinnacleSemester>();
            PinnacleWeeklies = new HashSet<PinnacleWeekly>();
            StudentTeachers = new HashSet<StudentTeacher>();
        }

        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public int? ClassId { get; set; }

        public virtual ClassList Class { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<PinnacleQuarterClass> PinnacleQuarterClasses { get; set; }
        public virtual ICollection<PinnacleSemester> PinnacleSemesters { get; set; }
        public virtual ICollection<PinnacleWeekly> PinnacleWeeklies { get; set; }
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
