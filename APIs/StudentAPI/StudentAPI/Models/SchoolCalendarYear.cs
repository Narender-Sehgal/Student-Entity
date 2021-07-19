using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class SchoolCalendarYear
    {
        public int Id { get; set; }
        public DateTime _1quarterStart { get; set; }
        public DateTime _1quarterEnd { get; set; }
        public DateTime _2quarterStart { get; set; }
        public DateTime _2quarterEnd { get; set; }
        public DateTime _3quarterStart { get; set; }
        public DateTime _3quarterEnd { get; set; }
        public DateTime _4quarterStart { get; set; }
        public DateTime _4quarterEnd { get; set; }
        public int? Attendance1Quarter { get; set; }
        public int? Attendance2Quarter { get; set; }
        public int? Attendance3Quarter { get; set; }
        public int? Attendance4Quarter { get; set; }
        public bool? Active { get; set; }
    }
}
