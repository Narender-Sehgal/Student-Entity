using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class RptAttendaceReport
    {
        public long Id { get; set; }
        public string SchoolYear { get; set; }
        public int? Quarter { get; set; }
        public int? WeekNo { get; set; }
        public string StudentId { get; set; }
        public string Fullname { get; set; }
        public string SchoolName { get; set; }
        public int? StudentWeeklyAttendance { get; set; }
        public int RequiredWeeklyAttendance { get; set; }
        public int? RequiredQuarterAttendance { get; set; }
    }
}
