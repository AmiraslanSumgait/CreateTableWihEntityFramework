using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTableWithEntityyFramework.Models
{
    public class Operation:BaseEntity
    {
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Book Book { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
