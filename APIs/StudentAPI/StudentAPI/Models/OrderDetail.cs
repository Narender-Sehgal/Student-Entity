using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Brand { get; set; }
        public double? Price { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }

        public virtual OrderHeader OrderHeader { get; set; }
        public virtual Product Product { get; set; }
    }
}
