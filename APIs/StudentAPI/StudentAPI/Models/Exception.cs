using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Exception
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public string ExceptionValue { get; set; }
    }
}
