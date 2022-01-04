using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Expenses
{
    public partial class Edit_Expense : Form
    {

        int expnsId;
        public Edit_Expense(int id)
        {
            InitializeComponent();
            expnsId = id;
        }

        private void Edit_Expense_Load(object sender, EventArgs e)
        {

        }
    }
}
