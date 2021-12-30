using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Student
{
    public partial class Student : Form
    {

        public Student()
        {
            InitializeComponent();

        }
        Student_Details studentDetailForm;
        public Student(Student_Details _f1) : this()
        {
            this.studentDetailForm = _f1;
        }
        byte[] FileName;
        public delegate void DoEvent();
        public event DoEvent studentDetail_Load;
        public string lbl;
        private void Student_Load(object sender, EventArgs e)
        {
            lblstd.Text = lbl;
            if (lblstd.Text == "Add New Student")
            {
                stdAdd_btn.Text = "Add Student";
                GetAllFathersInfo();
                GetAllClassesInfo();
            }
            else if (lblstd.Text == "Update Student")
            {
                stdAdd_btn.Text = "Update Student";
            }


        }

        public void GetAllFathersInfo()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var fatherDetails = schoolManagementSystemEntities.parents.ToList();
                if (fatherDetails.Count() > 0)
                {
                    stdFather_comboBox.DataSource = fatherDetails;
                    stdFather_comboBox.DisplayMember = "name_";
                    stdFather_comboBox.ValueMember = "pr_id";

                }
            }
        }

        public void GetAllClassesInfo()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var classDetails = schoolManagementSystemEntities.classes.ToList();
                if (classDetails.Count() > 0)
                {
                    stdClass_comboBox.DataSource = classDetails;
                    stdClass_comboBox.DisplayMember = "name";
                    stdClass_comboBox.ValueMember = "class_id";

                }
            }
        }
        byte[] ImageToByteArray(Image img, PictureBox px)
        {

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (px != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            return ms.ToArray();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ////
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            //  open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // image file path  
                FileName = ImageToByteArray(pictureBox1.Image, pictureBox1);
            }

        }
        private void stdAdd_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(stdName_txtbox.Text))
            {
                stdNameError_lbl.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(stdFather_comboBox.Text))
            {
                stdFatherError_lbl.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(stdClass_comboBox.Text))
            {
                stdClassError_lbl.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(stdAdmission_dateTimePicker.Text))
            {
                stdAdmissionError_lbl.Visible = true;
                return;
            }
            student studentObj = new student
            {
                name_ = stdName_txtbox.Text,
                f_id = Convert.ToInt16(stdFather_comboBox.SelectedValue),
                class_id = Convert.ToInt16(stdClass_comboBox.SelectedValue),
                admission_date = stdAdmission_dateTimePicker.Value,
                address = stdAddress_txtbox.Text,
                cell_no = stdPhone_maskedTextBox.Text,
                dob = stdDob_dateTimePicker.Value,
                status = stdStatus_textBox.Text,
                image = FileName
            };
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                schoolManagementSystemEntities.students.Add(studentObj);
                schoolManagementSystemEntities.SaveChanges();
                MessageBox.Show("Student Added Successfully");
                this.Close();
                this.Hide();
                studentDetailForm.studentDetail_Load();
            }
        }
    }
}
