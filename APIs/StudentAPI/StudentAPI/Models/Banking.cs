using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Banking
    {
        public Banking()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Checking { get; set; }
        public string Saving { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
