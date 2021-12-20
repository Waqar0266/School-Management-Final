using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Class
{
    public partial class Edit_Class : Form
    {
        int classId;
        public Edit_Class(int editClassId)
        {
            InitializeComponent();
            classId = editClassId;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void classId_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Class_Load(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {

                var getClassDetail = schoolManagementSystemEntities.classes.Where(x => x.class_id == classId).FirstOrDefault();
                if (getClassDetail != null)
                {
                    classId_txtbox.Text = getClassDetail.class_id.ToString();
                    className_txtbox.Text = getClassDetail.name.ToString();
                    section_txtbox.Text = getClassDetail.section_.ToString();
                    noChairs_txtbox.Text = getClassDetail.no_of_chairs.ToString();
                    noStd_txtbox.Text = getClassDetail.no_of_std.ToString();
                    noTables_txtbox.Text = getClassDetail.no_of_tables.ToString();

                }
            }
        }

        private void className_lbl_Click(object sender, EventArgs e)
        {

        }

        private void className_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void noStd_lbl_Click(object sender, EventArgs e)
        {

        }

        private void noStd_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void noChairs_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void noTable_lbl_Click(object sender, EventArgs e)
        {

        }

        private void noTables_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void classEdit_Btn_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var editClassDetail = schoolManagementSystemEntities.classes.Where(x => x.class_id == classId).FirstOrDefault();
                if (editClassDetail != null)
                {

                    editClassDetail.name = className_txtbox.Text;
                    editClassDetail.section_ = section_txtbox.Text;
                    editClassDetail.no_of_std = Convert.ToInt32(noStd_txtbox.Text);
                    editClassDetail.no_of_chairs = Convert.ToInt32(noChairs_txtbox.Text);
                    editClassDetail.no_of_tables = Convert.ToInt32(noTables_txtbox.Text);
                    schoolManagementSystemEntities.Entry(editClassDetail).State = EntityState.Modified;
                    schoolManagementSystemEntities.SaveChanges();
                    MessageBox.Show("Record Update Successfully");
                    this.Close();
                    Class_Details cls = new Class_Details();
                    cls.Activate();

                }
            }
        }
    }
}
