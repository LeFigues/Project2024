using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class Cycle
    {
        public int Id { get; set; }
        public string CycleName { get; set; }
        public DateOnly Start { get; set; }
        public DateOnly? Finish { get; set; }

        public ICollection<StudentCycle>? Students { get; set; }
    }
}
