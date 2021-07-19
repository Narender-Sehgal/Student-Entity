using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
