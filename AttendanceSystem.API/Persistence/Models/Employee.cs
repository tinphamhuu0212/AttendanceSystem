using System;
using System.Collections.Generic;

namespace AttendanceSystem.API.Persistence.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Schedule = new HashSet<Schedule>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
