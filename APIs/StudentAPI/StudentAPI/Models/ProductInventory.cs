using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class ProductInventory
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Center Center { get; set; }
        public virtual Product Product { get; set; }
    }
}
