using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ViewStudentReport
    {
       public int StudenId { get; set; }
        public string StudentName { get; set;}
        public string StudentClass { get; set;}
        public string StudentShift { get; set;}
        public int StudentNumberOfAttendance { get; set; }
        public int StudentNumberOfAbsences { get; set; }
        public string percentage { get; set; }
    }
}
