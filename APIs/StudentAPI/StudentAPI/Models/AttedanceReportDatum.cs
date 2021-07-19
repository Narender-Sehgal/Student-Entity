using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class AttedanceReportDatum
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal? May1720211200am { get; set; }
        public decimal? May1820211200am { get; set; }
        public decimal? May1920211200am { get; set; }
        public decimal? May2020211200am { get; set; }
        public decimal? May2120211200am { get; set; }
    }
}
