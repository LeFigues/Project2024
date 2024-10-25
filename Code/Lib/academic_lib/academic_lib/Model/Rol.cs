using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class Rol
    {
        [Key]
        public int Id { get; set; }
        public string RolName { get; set; }
        public string? Description { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
