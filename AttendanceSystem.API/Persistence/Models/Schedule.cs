using System;
using System.Collections.Generic;

namespace AttendanceSystem.API.Persistence.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            Attendance = new HashSet<Attendance>();
        }

        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public string ShiftId { get; set; }
        public DateTime Date { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
    }
}
