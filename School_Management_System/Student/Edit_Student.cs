using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Student
{
    public partial class Edit_Student : Form
    {
        int studentId;
        Student_Details studentDetailForm;
       
        public Edit_Student()
        {
            InitializeComponent();

        }
        public Edit_Student(int editStudentId, Student_Details _f1) :this()
        {
           
            studentId = editStudentId;
            studentDetailForm = _f1;
        }

        public delegate void DoEvent();
        public event DoEvent studentDetail_Load;

        List<parent> parentList = new List<parent>();
        List<@class> classList = new List<@class>();
        public void getParentAndClassData()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                parentList = schoolManagementSystemEntities.parents.ToList();
                classList = schoolManagementSystemEntities.classes.ToList();
            }
        }
        byte[] FileName;
        byte[] ImageToByteArray(Image img, PictureBox px)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (px != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            return ms.ToArray();

        }


        private void stdEdit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(stdName_txtbox.Text))
            {
                stdNameError_lbl.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(stdFatherEdit_comboBox.Text))
            {
                stdFatherError_lbl.Visible = true;
                return;

            }
            if (string.IsNullOrEmpty(stdClassEdit_comboBox.Text))
            {
                stdClassError_lbl.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(stdAdmission_dateTimePicker.Text))
            {
                stdAdmissionError_lbl.Visible = true;
                return;
            }
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var getStudentDetail = schoolManagementSystemEntities.students.Where(x => x.std_id == studentId).FirstOrDefault();
                if (getStudentDetail != null)
                {
                    getStudentDetail.name_ = stdName_txtbox.Text;
                    getStudentDetail.f_id = Convert.ToInt16(stdFatherEdit_comboBox.SelectedValue);
                    getStudentDetail.class_id = Convert.ToInt16(stdClassEdit_comboBox.SelectedValue);
                    getStudentDetail.admission_date = stdAdmission_dateTimePicker.Value;
                    getStudentDetail.address = stdAddress_txtbox.Text;
                    getStudentDetail.cell_no = stdPhone_maskedTextBox.Text;
                    getStudentDetail.dob = stdDob_dateTimePicker.Value;
                    getStudentDetail.status = stdStatus_textBox.Text;
                    if (FileName == null)
                    {
                        byte[] imgData = getStudentDetail.image;
                        MemoryStream stream = new MemoryStream(imgData);
                        pictureBox1.BackgroundImage = Image.FromStream(stream);
                        FileName = ImageToByteArray(pictureBox1.BackgroundImage, pictureBox1);

                    }
                    getStudentDetail.image = FileName;
                    schoolManagementSystemEntities.Entry(getStudentDetail).State = EntityState.Modified;
                    schoolManagementSystemEntities.SaveChanges();
                    MessageBox.Show("Record Updated Successfully");
                    this.Close();
                    this.Hide();
                    studentDetailForm.studentDetail_Load();
                }
            }
        }

        private void Edit_Student_Load(object sender, EventArgs e)
        {
            getParentAndClassData();
            MapStudentEntries();
        }
        public void MapStudentEntries()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                ///asad
                ///waqar if
                var getStudentDetails = schoolManagementSystemEntities.students.Where(x => x.std_id == studentId).FirstOrDefault();
                if (getStudentDetails != null)
                {
                    studentId_txtbox.Text = Convert.ToString(getStudentDetails.std_id);
                    stdName_txtbox.Text = getStudentDetails.name_;
                    stdFatherEdit_comboBox.DataSource = parentList;
                    stdFatherEdit_comboBox.DisplayMember = "name_";
                    stdFatherEdit_comboBox.ValueMember = "pr_id";
                    stdFatherEdit_comboBox.SelectedValue = getStudentDetails.parent.pr_id;
                    stdClassEdit_comboBox.DataSource = classList;
                    stdClassEdit_comboBox.DisplayMember = "name";
                    stdClassEdit_comboBox.ValueMember = "class_id";
                    stdClassEdit_comboBox.SelectedValue = getStudentDetails.@class.class_id;
                    stdDob_dateTimePicker.Text = Convert.ToString(getStudentDetails.dob);
                    stdAdmission_dateTimePicker.Text = Convert.ToString(getStudentDetails.admission_date);
                    stdAddress_txtbox.Text = getStudentDetails.address;
                    stdStatus_textBox.Text = getStudentDetails.status;
                    stdPhone_maskedTextBox.Text = getStudentDetails.cell_no;
                    if (getStudentDetails.image != null)
                    {
                        byte[] imgData = getStudentDetails.image;
                        MemoryStream stream = new MemoryStream(imgData);
                        pictureBox1.Image = Image.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                }
            }
        }

        private void stdClass_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            //  open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);

                // image file path  
                FileName = ImageToByteArray(pictureBox1.Image, pictureBox1);
            }

        }

    }
}
