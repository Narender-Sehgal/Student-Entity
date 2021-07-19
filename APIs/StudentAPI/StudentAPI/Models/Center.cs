using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Center
    {
        public Center()
        {
            CenterSchools = new HashSet<CenterSchool>();
            ProductInventories = new HashSet<ProductInventory>();
            ProductMovementTrFromLocationNavigations = new HashSet<ProductMovementTr>();
            ProductMovementTrToLocationNavigations = new HashSet<ProductMovementTr>();
            Usercenters = new HashSet<Usercenter>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string OpenHour { get; set; }
        public string CloseHour { get; set; }

        public virtual ICollection<CenterSchool> CenterSchools { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductMovementTr> ProductMovementTrFromLocationNavigations { get; set; }
        public virtual ICollection<ProductMovementTr> ProductMovementTrToLocationNavigations { get; set; }
        public virtual ICollection<Usercenter> Usercenters { get; set; }
    }
}
