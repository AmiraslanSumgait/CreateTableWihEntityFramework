using CreateTableWithEntityyFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTableWithEntityyFramework.Models
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; }

        public string PhoneNumber { get; set; }

        public virtual List<Operation> Operations { get; set; }
    }
}
