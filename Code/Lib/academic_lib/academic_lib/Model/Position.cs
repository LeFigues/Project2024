using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class Position
    {
        [Key]
        public int Id { get; set; }
        public string PositionName { get; set; }
        public string? Description { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
