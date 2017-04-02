using System;
using System.Collections.Generic;

namespace DbMap.Entities
{
    public partial class Department
    {
        public Department()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifyDate { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
