using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class UserSign
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime? LastSignIn { get; set; }
        public DateTime? LastSignOut { get; set; }
    }
}
