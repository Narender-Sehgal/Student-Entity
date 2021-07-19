using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class ProductMovementTr
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TypeId { get; set; }
        public int? FromLocation { get; set; }
        public int ToLocation { get; set; }
        public int Quantity { get; set; }

        public virtual Center FromLocationNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual Center ToLocationNavigation { get; set; }
        public virtual MovementTrsType Type { get; set; }
    }
}
