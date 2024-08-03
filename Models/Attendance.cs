using System;

namespace HRMSApp.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime AttendanceDate { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
    }
}
