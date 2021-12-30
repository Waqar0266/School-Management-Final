using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.ViewModel
{
    class ParentVM
    {
        public int prent_id { get; set; }
        public string Parent_name { get; set; }
        public string email { get; set; }
        public string cnic { get; set; }
        public string cell_no { get; set; }
        public string occupation { get; set; }
        public string office_no { get; set; }
        public Nullable<decimal> monthly_income { get; set; }
        public string status { get; set; }
        
    }
}
