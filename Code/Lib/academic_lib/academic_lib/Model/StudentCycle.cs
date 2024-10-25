﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class StudentCycle
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
        public int CycleId { get; set; }
        public Cycle? Cycle { get; set; }
    }
}
