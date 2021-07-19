using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class PinnacleQuarterClass
    {
        public int Id { get; set; }
        public int? PinnacleQuarterHeaderId { get; set; }
        public int? TeacherId { get; set; }
        public string Pinnacle1Quarter { get; set; }
        public string Grade1Quarter { get; set; }
        public string Points1Quarter { get; set; }
        public string FinalGrade1Quarter { get; set; }
        public string Pinnacle2Quarter { get; set; }
        public string Grade2Quarter { get; set; }
        public string Points2Quarter { get; set; }
        public string FinalGrade2Quarter { get; set; }
        public string Pinnacle3Quarter { get; set; }
        public string Grade3Quarter { get; set; }
        public string Points3Quarter { get; set; }
        public string FinalGrade3Quarter { get; set; }
        public string Pinnacle4Quarter { get; set; }
        public string Grade4Quarter { get; set; }
        public string Points4Quarter { get; set; }
        public string FinalGrade4Quarter { get; set; }
        public string FinalGrade { get; set; }
        public string Credits { get; set; }
        public int? ItemOrder { get; set; }

        public virtual PinnacleQuarterHeader PinnacleQuarterHeader { get; set; }
        public virtual TeacherClass Teacher { get; set; }
    }
}
