using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.ViewModel
{
    class AssetVM
    {
        public int as_id { get; set; }
        public string type_ { get; set; }
        public string name_ { get; set; }
        public Nullable<System.DateTime> date_ { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string descripition { get; set; }
    }
}
