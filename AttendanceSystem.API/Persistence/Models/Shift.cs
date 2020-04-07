using System;
using System.Collections.Generic;

namespace AttendanceSystem.API.Persistence.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Schedule = new HashSet<Schedule>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }

        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
