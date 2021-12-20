using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.Linq;

namespace School_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form1 frm = new Form1())
            {
                using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
                {
                    //var loginCredentials = schoolManagementSystemEntities.Operators.Where(x => x.user_name == username.Text && x.password_ == password.Text).FirstOrDefault();
                    //if (loginCredentials != null)
                    //{
                        frm.ShowDialog();
                    //}
                    //else
                    //{
                    //    InvalidUserPasstxtbox.Visible = true;
                    //}
                }
               
                
            }
        }
    }
}
