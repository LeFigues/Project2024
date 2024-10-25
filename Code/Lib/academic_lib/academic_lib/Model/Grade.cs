using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class Grade
    {
        [Key]
        public int Id { get; set; }
        public string GradeName { get; set; }

        public ICollection<Materia>? Materias { get; set; }
    }
}
