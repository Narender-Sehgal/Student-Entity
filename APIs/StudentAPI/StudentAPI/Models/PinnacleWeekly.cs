using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class PinnacleWeekly
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string SchoolYear { get; set; }
        public string Quarter { get; set; }
        public int? TeacherId { get; set; }
        public string W1 { get; set; }
        public string W11 { get; set; }
        public string W2 { get; set; }
        public string W21 { get; set; }
        public string W3 { get; set; }
        public string W31 { get; set; }
        public string W4 { get; set; }
        public string W41 { get; set; }
        public string W5 { get; set; }
        public string W51 { get; set; }
        public string W6 { get; set; }
        public string W61 { get; set; }
        public string W7 { get; set; }
        public string W71 { get; set; }
        public string W8 { get; set; }
        public string W81 { get; set; }
        public string W9 { get; set; }
        public string W91 { get; set; }
        public string W10 { get; set; }
        public string W101 { get; set; }
        public string W111 { get; set; }
        public string W112 { get; set; }
        public string Goal { get; set; }
        public string FinalGrade { get; set; }
        public string ExamGrade { get; set; }
        public int? ItemOrder { get; set; }

        public virtual Student Student { get; set; }
        public virtual TeacherClass Teacher { get; set; }
    }
}
