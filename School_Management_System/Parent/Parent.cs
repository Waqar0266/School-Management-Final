using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Parent
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        public string lbl;
        private void Parent_Load(object sender, EventArgs e)
        {
            lblheading.Text = lbl;
            if (lblheading.Text == "Add New Parent")
            {
                addParent.Text = "Add Parent";
            }
            else if(lblheading.Text== "Update Parent")
            {
                addParent.Text = "Update Parent";
            }
        }

        private void addParent_Click(object sender, EventArgs e)
        {
            SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities();
            parent p = new parent();
            p.name_ = parentName.Text;
            p.email = parentEmail.Text;
            p.cnic = parentCnic.Text;
            p.cell_no = parentCellno.Text;
            p.occupation = parentOccupation.Text;
            p.office_no = parentOfficeno.Text;
            if (parentMonthlyIncm.Text!="" )
            {
                p.monthly_income = Convert.ToInt32(parentMonthlyIncm.Text);
            }
            p.status = parentStatus.Text;
            schoolManagementSystemEntities.parents.Add(p);
            schoolManagementSystemEntities.SaveChanges();
            this.Close();
            MessageBox.Show("Data Inserted Successfully.");
            this.Close();
            Parent_Details fr = new Parent_Details();
            fr.Show();
            
        }
        private void parentMonthlyIncm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }



        }

       
    }
}
