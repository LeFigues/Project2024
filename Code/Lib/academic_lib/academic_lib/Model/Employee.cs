using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class Employee : Person
    {
        public decimal Salary { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? FinishDate { get; set; }

        public int PositionId { get; set; }
        public Position? Position { get; set; }
    }
}
