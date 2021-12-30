using School_Management_System.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Subjects
{
    public partial class Subjects_Details : Form
    {
        public Subjects_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (subject sub = new subject())
            {
                sub.lbl = "Add New Subject";
                sub.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (subject sub = new subject())
            {
                sub.lbl = "Update Subject";
                sub.ShowDialog();
            }
        }
        public void SubjectDataGridView()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var searchResult = schoolManagementSystemEntities.subjects.Select(x => new SubjectVM
                {
                    name_ = x.name_,
                    descripition = x.descripition,
                    author = x.author


                }).ToList();

                Subject_dataGridView.DataSource = searchResult;

            }
        }
        private void Subject_Details_Load(object sender, EventArgs e)
        {
            SubjectDataGridView();
        }

        private void searchSubject_btn_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                
                if (searchSubject_Combo.Text == "Author")
                {
                    if (searchSubject_txtbox.Text!="")
                    {
                        var result1 = schoolManagementSystemEntities.subjects.Select(x => new SubjectVM
                        {
                            sub_id = x.sub_id,
                            name_ = x.name_,
                            author = x.author,
                            descripition = x.descripition,
                            class_id = x.class_id

                        }).Where(x => x.author == searchSubject_txtbox.Text).ToList();
                        Subject_dataGridView.DataSource = result1;
                    }
                    else
                    {
                        MessageBox.Show("@Author Name Canot Null ");
                    }
                    
                    
                }
                else if (searchSubject_Combo.Text == "Class")
                {
                    if (searchSubject_txtbox.Text != "")
                    {
                        var result2 = schoolManagementSystemEntities.subjects.Select(x => new SubjectVM
                        {
                            sub_id = x.sub_id,
                            name_ = x.name_,
                            author = x.author,
                            descripition = x.descripition,
                            class_id = x.class_id

                        }).Where(x => x.class_id == Convert.ToInt32(searchSubject_txtbox.Text)).ToList();

                        Subject_dataGridView.DataSource = result2;
                    }
                    else
                    {
                        MessageBox.Show("@Class Name Canot Null ");
                    }
                }

                else
                {
                    MessageBox.Show("Kindly select @search By Name");
                }
            }
        }

        private void searchSubject_txtbox_TextChanged(object sender, EventArgs e)
        {

                using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
                {

                    if (searchSubject_Combo.Text == "Author")
                    {

                        var result1 = schoolManagementSystemEntities.subjects.Select(x => new SubjectVM
                        {
                            sub_id = x.sub_id,
                            name_ = x.name_,
                            author = x.author,
                            descripition = x.descripition,
                            class_id = x.class_id

                        }).Where(x => x.author.Contains(searchSubject_txtbox.Text)).ToList();
                        Subject_dataGridView.DataSource = result1;
                    }

                    else if (searchSubject_Combo.Text == "Class")
                    {

                        var result2 = schoolManagementSystemEntities.subjects.Select(x => new SubjectVM
                        {
                            sub_id = x.sub_id,
                            name_ = x.name_,
                            author = x.author,
                            descripition = x.descripition,
                            class_id = x.class_id

                        }).Where(x => x.class_id == Convert.ToInt32(searchSubject_txtbox.Text)).ToList();

                        Subject_dataGridView.DataSource = result2;
                    }
                    else
                    {
                        MessageBox.Show("Kindly select @search By Name");
                    searchSubject_txtbox.Text="";

                    }
                }
            }

        private void Subject_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Subject_dataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                int editSubId = Convert.ToInt32(Subject_dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                Edit_Subject editForm = new Edit_Subject(editSubId);
                editForm.ShowDialog();
            }
            if (Subject_dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int deletesubId = Convert.ToInt32(Subject_dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                if (deletesubId != 0)
                {
                    using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
                    {
                        var getsubDetail = schoolManagementSystemEntities.classes.Where(x => x.class_id == deletesubId).FirstOrDefault();
                        if (getsubDetail != null)
                        {
                            schoolManagementSystemEntities.classes.Remove(getsubDetail);
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
