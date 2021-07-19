﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateModify { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
