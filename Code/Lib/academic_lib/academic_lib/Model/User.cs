using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class User : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public int RolId { get; set; }
        public Rol? Rol { get; set; }

        public int PersonId { get; set; }
        public Person? Person { get; set; }

        public ICollection<StudentCycle>? Cycles { get; set; }
    }
}
