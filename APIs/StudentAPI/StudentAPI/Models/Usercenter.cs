using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Usercenter
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CenterId { get; set; }

        public virtual Center Center { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
