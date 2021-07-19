using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class PinnacleSemester
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string SchoolYear { get; set; }
        public int? TeacherId { get; set; }
        public string Pinnacle1Quarter { get; set; }
        public string Grade1Quarter { get; set; }
        public string Points1Quarter { get; set; }
        public string Pinnacle2Quarter { get; set; }
        public string Grade2Quarter { get; set; }
        public string Points2Quarter { get; set; }
        public string ExGrade1Semester { get; set; }
        public string SemGrade1Semester { get; set; }
        public string Pinnacle3Quarter { get; set; }
        public string Grade3Quarter { get; set; }
        public string Points3Quarter { get; set; }
        public string Pinnacle4Quarter { get; set; }
        public string Grade4Quarter { get; set; }
        public string Points4Quarter { get; set; }
        public string ExGrade2Semester { get; set; }
        public string SemGrade2Semester { get; set; }
        public int? ItemOrder { get; set; }

        public virtual Student Student { get; set; }
        public virtual TeacherClass Teacher { get; set; }
    }
}
