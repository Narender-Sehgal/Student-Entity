using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class UserTime
    {
        public int Id { get; set; }
        public bool? Enable { get; set; }
        public bool? Weekend { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Userid { get; set; }
    }
}
