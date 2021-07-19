using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class TestScore
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string TestName { get; set; }
        public decimal? Score { get; set; }
        public decimal? Levels { get; set; }
        public string Ndpercentile { get; set; }

        public virtual Student Student { get; set; }
    }
}
