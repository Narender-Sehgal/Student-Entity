using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class TutoringGroup
    {
        public TutoringGroup()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
