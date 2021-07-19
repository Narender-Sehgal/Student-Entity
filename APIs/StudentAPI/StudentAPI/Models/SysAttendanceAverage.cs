using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class SysAttendanceAverage
    {
        public int Id { get; set; }
        public int? Quarter { get; set; }
        public string StudentId { get; set; }
        public int? RequiredWeeklyAttendance { get; set; }
        public int? StudentWeeklyAttendance { get; set; }
        public int? AttendanceAverage { get; set; }
    }
}
