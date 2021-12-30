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

namespace School_Management_System.Parent
{
    public partial class Parent_Details : Form
    {
        public Parent_Details()
        {
            InitializeComponent();
        }
        public void ParentDataGridView()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var parentDetails = schoolManagementSystemEntities.parents.Select(x => new ParentVM
                {
                    prent_id = x.pr_id,
                    Parent_name = x.name_,
                    email = x.email,
                    cnic = x.cnic,
                    cell_no = x.cell_no,
                    occupation = x.occupation,
                    office_no = x.office_no,
                    monthly_income = x.monthly_income,
                    status = x.status

                }).ToList();

                Parent_dataGridView.DataSource = parentDetails;

            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Parent pr = new School_Management_System.Parent.Parent())
            {
                pr.lbl = "Add New Parent";
                pr.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (Parent pr = new School_Management_System.Parent.Parent())
            {
                pr.lbl = "Update Parent";
                pr.ShowDialog();
            }
        }

        private void Parent_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementSystemDataSet3.parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter1.Fill(this.schoolManagementSystemDataSet3.parent);
            ParentDataGridView();
            // TODO: This line of code loads data into the 'schoolManagementSystemDataSet.parent' table. You can move, or remove it, as needed.
            //this.parentTableAdapter.Fill(this.schoolManagementSystemDataSet.parent);

        }

        private void searchClass_Btn_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var searchResult = schoolManagementSystemEntities.parents.Select(x => new ParentVM
                {
                    prent_id = x.pr_id,
                    Parent_name = x.name_,
                    email = x.email,
                    cnic = x.cnic,
                    cell_no = x.cell_no,
                    occupation = x.occupation,
                    office_no = x.office_no,
                    monthly_income = x.monthly_income,
                    status = x.status

                }).Where(x => x.Parent_name == searchParent_txtbox.Text).ToList();

                Parent_dataGridView.DataSource = searchResult;
            }
        }

        private void searchParent_txtbox_TextChanged(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var searchResult = schoolManagementSystemEntities.parents.Select(x => new ParentVM
                {
                    prent_id = x.pr_id,
                    Parent_name = x.name_,
                    email = x.email,
                    cnic = x.cnic,
                    cell_no = x.cell_no,
                    occupation = x.occupation,
                    office_no = x.office_no,
                    monthly_income = x.monthly_income,
                    status = x.status

                }).Where(x => x.Parent_name.Contains(searchParent_txtbox.Text)).ToList();

                Parent_dataGridView.DataSource = searchResult;
            }
        }




        private void Parent_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Parent_dataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                int ediParentId = Convert.ToInt32(Parent_dataGridView.Rows[e.RowIndex].Cells["parentId"].Value);
                Edit_Parent editForm = new Edit_Parent(ediParentId);
                editForm.ShowDialog();
            }
            if (Parent_dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")

            {
                int deleteParentId = Convert.ToInt32(Parent_dataGridView.Rows[e.RowIndex].Cells["parentid"].Value);
                if (deleteParentId != 0)
                {
                    using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
                    {
                        var getParentDetail = schoolManagementSystemEntities.parents.Where(x => x.pr_id == deleteParentId).FirstOrDefault();
                        if (deleteParentId != 0 && getParentDetail !=null)
                        {
                            schoolManagementSystemEntities.parents.Remove(getParentDetail);
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
    }
}
