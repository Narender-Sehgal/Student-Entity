using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class CenterCalendar
    {
        public int Id { get; set; }
        public int? CenterId { get; set; }
        public int? TypeId { get; set; }
        public string Text { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserId { get; set; }
        public string AllCenters { get; set; }
        public string Description { get; set; }
    }
}
