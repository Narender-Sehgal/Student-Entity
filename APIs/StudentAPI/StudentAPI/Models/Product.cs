using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductInventories = new HashSet<ProductInventory>();
            ProductMovementTrs = new HashSet<ProductMovementTr>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string Size { get; set; }
        public string Barcode { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string ImgFileName { get; set; }

        public virtual ProductCategory Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductMovementTr> ProductMovementTrs { get; set; }
    }
}
