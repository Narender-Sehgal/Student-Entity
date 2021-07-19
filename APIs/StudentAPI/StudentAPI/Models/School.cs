using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class School
    {
        public School()
        {
            CenterSchools = new HashSet<CenterSchool>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<CenterSchool> CenterSchools { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
