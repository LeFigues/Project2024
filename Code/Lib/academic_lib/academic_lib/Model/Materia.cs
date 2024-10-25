using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class Materia
    {
        [Key]
        public int Id { get; set; }
        public string MateriaName { get; set; }
        public decimal Credit { get; set; }

        public int? IsRequiredForId { get; set; }
        public Materia? IsRequiredFor { get; set; }
        public ICollection<Materia>? RequiredMaterias { get; set; }

        public int GradeId { get; set; }
        public Grade? Grade { get; set; }
    }
}
