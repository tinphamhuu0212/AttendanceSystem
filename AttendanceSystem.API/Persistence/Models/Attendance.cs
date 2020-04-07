using System;
using System.Collections.Generic;

namespace AttendanceSystem.API.Persistence.Models
{
    public partial class Attendance
    {
        public string Id { get; set; }
        public string ScheduleId { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
