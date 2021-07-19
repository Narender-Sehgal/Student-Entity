using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class RptStudentSdfreport
    {
        public long Id { get; set; }
        public string FullNameStudent { get; set; }
        public string Fullnameteacher { get; set; }
        public string SchoolYear { get; set; }
        public string StudentId { get; set; }
        public string Quarter { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public string Weekvalue { get; set; }
        public string Weekname { get; set; }
    }
}
