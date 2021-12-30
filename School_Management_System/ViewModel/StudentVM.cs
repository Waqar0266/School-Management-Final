using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.ViewModel
{
    class StudentVM
    {
        public int std_id { get; set; }
        public string name_ { get; set; }
        public Nullable<int> f_id { get; set; }
        public Nullable<int> class_id { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public Nullable<System.DateTime> admission_date { get; set; }
        public string status { get; set; }
    }
}
