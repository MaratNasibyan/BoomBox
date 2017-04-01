using System;
using System.Collections.Generic;

namespace DbMap.Entities
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifyDate { get; set; }
    }
}
