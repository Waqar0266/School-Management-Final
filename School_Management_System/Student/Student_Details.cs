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

namespace School_Management_System.Student
{
    public partial class Student_Details : Form
    {
        
        public Student_Details()
        {
            InitializeComponent();
           
        }

        public void studentDetail_Load()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var studentDetails = schoolManagementSystemEntities.students.Select(x => new StudentVM
                {
                    std_id = x.std_id,
                    name_ = x.name_,
                    address = x.address,
                    admission_date = x.admission_date,
                    class_id = x.class_id,
                    dob = x.dob,
                    f_id = x.f_id,
                    status = x.status
                }).ToList();
                studentDataGridView.DataSource = studentDetails;
            }


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Student std = new Student(this))
            {
                std.lbl = "Add New Student";
                std.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (Edit_Student updateStudent = new Edit_Student(0,this))
            {
updateStudent.ShowDialog();
            }
        }

        private void Student_Details_Load(object sender, EventArgs e)
        {
            studentDetail_Load();
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
               
                int editStudentId = Convert.ToInt32(studentDataGridView.Rows[e.RowIndex].Cells["stdId"].Value);
                Edit_Student editForm = new Edit_Student(editStudentId, this);
                editForm.ShowDialog();
            }
            if (studentDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int studentId = Convert.ToInt32(studentDataGridView.Rows[e.RowIndex].Cells["stdId"].Value);
                string message = "Are you sure to delete this record";
                string title = "Delete Student";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    DeleteStudent(studentId);
                }
                }
        }

        public void DeleteStudent(int studentId)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var getStudentRecord = schoolManagementSystemEntities.students.Where(x => x.std_id == studentId).FirstOrDefault();
                if(getStudentRecord!=null)
                {
                    schoolManagementSystemEntities.students.Remove(getStudentRecord);
                    schoolManagementSystemEntities.SaveChanges();
                    MessageBox.Show("Record deleted");
                    var studentDetails = schoolManagementSystemEntities.students.Select(x => new StudentVM
                    {
                        std_id = x.std_id,
                        name_ = x.name_,
                        address = x.address,
                        admission_date = x.admission_date,
                        class_id = x.class_id,
                        dob = x.dob,
                        f_id = x.f_id,
                        status = x.status
                    }).ToList();
                    studentDataGridView.DataSource = studentDetails;
                }
                else
                {
                    MessageBox.Show("Record doesn't exists");
                }
            }
        }

        private void stdSearch_txtbox_TextChanged_1(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var studentDetails = schoolManagementSystemEntities.students.Select(x => new StudentVM
                {
                    std_id = x.std_id,
                    name_ = x.name_,
                    address = x.address,
                    admission_date = x.admission_date,
                    class_id = x.class_id,
                    dob = x.dob,
                    f_id = x.f_id,
                    status = x.status
                }).Where(x => x.name_.Contains(stdSearch_txtbox.Text)).ToList();
                studentDataGridView.DataSource = studentDetails;
            }
        }
    }
}
