using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class BankingHistory
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string AccountNumber { get; set; }
        public string TransType { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string S { get; set; }
        public string Value { get; set; }
        public string UserId { get; set; }
    }
}
