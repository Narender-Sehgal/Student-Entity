using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class MovementTrsType
    {
        public MovementTrsType()
        {
            ProductMovementTrs = new HashSet<ProductMovementTr>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductMovementTr> ProductMovementTrs { get; set; }
    }
}
