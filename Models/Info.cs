using System;
using System.Collections.Generic;

namespace DFEFCoreCRUD.Models
{
    public partial class Info
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Salary { get; set; }
        public string Designation { get; set; } = null!;
    }
}
