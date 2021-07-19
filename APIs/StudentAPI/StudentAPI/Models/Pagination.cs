using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    public class Pagination<T>
    {
        public int ItemsPerPage { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }

        public List<T> Student { get; set; }
    }
}
