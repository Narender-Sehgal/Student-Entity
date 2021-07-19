using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Log
    {
        public DateTime? CmdDate { get; set; }
        public string CmdPerson { get; set; }
        public string Tablecmd { get; set; }
        public string Teacherid { get; set; }
        public string Studentid { get; set; }
        public string Cmd { get; set; }
    }
}
