using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.ViewModel
{
    class ClassVM
    {
        public int class_id { get; set; }
        public string name { get; set; }
        public int? no_of_std { get; set; }
        public int? no_of_chairs { get; set; }
        public int? no_of_tables { get; set; }
        public string section_ { get; set; }
    }
}
