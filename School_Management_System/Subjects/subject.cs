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
    public partial class subject : Form
    {
        public subject()
        {
            InitializeComponent();
        }

        public string lbl;

        public string section_ { get; private set; }

        private void subject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementSystemDataSet1._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.schoolManagementSystemDataSet1._class);
            lblsub.Text = lbl;
            if (lblsub.Text== "Add New Subject")
            {
                subjectAdd.Text = "Add Subject";
            }
            else if (lblsub.Text== "Update Subject")
            {
                subjectAdd.Text ="Update Subject";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classTableAdapter.FillBy(this.schoolManagementSystemDataSet1._class);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
        private void subjectAdd_btn_Click(object sender, EventArgs e)
        {

        }

        private void subjectAdd_btn_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        

        private void subjectAdd_Click(object sender, EventArgs e)
        {

            School_Management_System.subject subObj = new School_Management_System.subject()
            {
                name_ = subjectName.Text,
                author = subjectAuth.Text,
                descripition = subjectDesc.Text,
                //class_id=int.Parse(subjectClassID.Text)

            };

            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                Subjects_Details form2 = new Subjects_Details();
                schoolManagementSystemEntities.subjects.Add(subObj);
                schoolManagementSystemEntities.SaveChanges();
                MessageBox.Show("Class Added Successfully");
                this.Close();
                this.Hide();
                form2.Hide();
                form2.ShowDialog();

            }
        }
    }
}
