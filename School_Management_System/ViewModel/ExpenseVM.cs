using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.ViewModel
{
    class ExpenseVM
    {
        public int ex_id { get; set; }
        public string ex_type { get; set; }
        public string name_ { get; set; }
        public Nullable<System.DateTime> date_ { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string descripition { get; set; }
    }
}
