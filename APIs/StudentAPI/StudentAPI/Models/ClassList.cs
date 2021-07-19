using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class ClassList
    {
        public ClassList()
        {
            TeacherClasses = new HashSet<TeacherClass>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeacherClass> TeacherClasses { get; set; }
    }
}
