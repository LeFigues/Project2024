using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_lib.Model
{
    internal class BaseModel
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdate { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
    }
}
