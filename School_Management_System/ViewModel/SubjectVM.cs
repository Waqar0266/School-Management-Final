using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.ViewModel
{
    class SubjectVM
    {
        public int sub_id { get; set; }
        public string name_ { get; set; }
        public Nullable<int> class_id { get; set; }
        public string author { get; set; }
        public string descripition { get; set; }

        public virtual @class @class { get; set; }
        public virtual ICollection<paper> papers { get; set; }
        
        public virtual ICollection<test> tests { get; set; }
    }
}
