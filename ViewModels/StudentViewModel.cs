using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HertfordshireUniversity.ViewModels
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
