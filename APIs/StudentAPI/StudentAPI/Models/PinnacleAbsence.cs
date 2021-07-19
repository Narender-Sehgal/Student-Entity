using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class PinnacleAbsence
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string SchoolYear { get; set; }
        public string Quarter { get; set; }
        public string ExcusedAbsence { get; set; }
        public string UnexcusedAbsense { get; set; }
        public string InternalSuspension { get; set; }
        public string ExternalSuspension { get; set; }
        public string AlttoSuspension { get; set; }
    }
}
