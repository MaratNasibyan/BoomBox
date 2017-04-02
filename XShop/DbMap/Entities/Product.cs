using System;
using System.Collections.Generic;

namespace DbMap.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifyDate { get; set; }

        public virtual Department Department { get; set; }
    }
}
