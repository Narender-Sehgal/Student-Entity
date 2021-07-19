using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class SchoolYear
    {
        public SchoolYear()
        {
            TeacherContacts = new HashSet<TeacherContact>();
        }

        public int Id { get; set; }
        public string SchoolYear1 { get; set; }

        public virtual ICollection<TeacherContact> TeacherContacts { get; set; }
    }
}
