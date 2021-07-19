using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class FingerPrintDatum
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public int? FingerPosition { get; set; }
        public string FingerData { get; set; }
    }
}
