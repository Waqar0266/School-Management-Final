using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.ViewModel
{
    class SalaryVM
    {
        public int sal_id { get; set; }
        
        public string emp_num { get; set; }
        public string emp_name { get; set; }
        public string emp_Cnic { get; set; }
        public string emp_desgn { get; set; }
        
        public string month_ { get; set; }
        public Nullable<System.DateTime> issue_date { get; set; }
        public Nullable<decimal> basic_sal { get; set; }
        public Nullable<decimal> deduction { get; set; }
        public Nullable<decimal> allowances { get; set; }
        public Nullable<decimal> advance_sal { get; set; }
        public Nullable<decimal> total_amount { get; set; }
    }
}
