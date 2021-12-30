using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management_System.ViewModel;

namespace School_Management_System.Class
{
    public partial class Class_Details : Form
    {
        public Class_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_Class cls = new Add_Class())
            {
                cls.lbl = "Add New Class";
                cls.ShowDialog();




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_Class cls = new Add_Class())
            {
                cls.lbl = "Update Class";
                cls.ShowDialog();


            }
        }

        public void ClassDataGridView()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {

                var test = schoolManagementSystemEntities.classes.Select(x => new ClassVM
                {
                    class_id = x.class_id,
                    name = x.name,
                    no_of_std = x.no_of_std,
                    no_of_chairs = x.no_of_chairs,
                    no_of_tables = x.no_of_tables,
                    section_ = x.section_

                }).ToList();

                class_dataGridView.DataSource = test;

            }
        }

        private void class_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Class_Details_Load(object sender, EventArgs e)
        {
            ClassDataGridView();
        }

        private void class_dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void class_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (class_dataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                int editClassId = Convert.ToInt32(class_dataGridView.Rows[e.RowIndex].Cells["classId"].Value);
                Edit_Class editForm = new Edit_Class(editClassId);
                editForm.ShowDialog();
            }
            if (class_dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")

            {
                int deleteClassId = Convert.ToInt32(class_dataGridView.Rows[e.RowIndex].Cells["classId"].Value);
                if (deleteClassId != null && deleteClassId != 0)
                {
                    using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
                    {
                        var getClassDetail = schoolManagementSystemEntities.classes.Where(x => x.class_id == deleteClassId).FirstOrDefault();
                        if (getClassDetail != null)
                        {
                            schoolManagementSystemEntities.classes.Remove(getClassDetail);
                            schoolManagementSystemEntities.SaveChanges();

                        }
                        else
                        {
                            MessageBox.Show("Record does not exists");
                        }



                    }
                }
                MessageBox.Show("Are you Sure!!");
                MessageBox.Show("Deleted");
            }


        }

        //private void Class_Details_Activated(object sender, EventArgs e)
        //{
        //    ClassDataGridView();
        //}

        private void searchClass_btn_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var test = schoolManagementSystemEntities.classes.Select(x => new ClassVM
                {
                    class_id = x.class_id,
                    name = x.name,
                    no_of_std = x.no_of_std,
                    no_of_chairs = x.no_of_chairs,
                    no_of_tables = x.no_of_tables,
                    section_ = x.section_

                }).Where(x => x.name.Contains(searchClass_txtbox.Text)).ToList();

                class_dataGridView.DataSource = test;
            }
        }

        private void searchClass_txtbox_TextChanged(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var test = schoolManagementSystemEntities.classes.Select(x => new ClassVM
                {
                    class_id = x.class_id,
                    name = x.name,
                    no_of_std = x.no_of_std,
                    no_of_chairs = x.no_of_chairs,
                    no_of_tables = x.no_of_tables,
                    section_ = x.section_

                }).Where(x => x.name.Contains(searchClass_txtbox.Text)).ToList();

                class_dataGridView.DataSource = test;
            }
        }
    }
}
