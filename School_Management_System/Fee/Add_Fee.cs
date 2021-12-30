using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Fee
{
    public partial class Add_Fee : Form
    {
        public Add_Fee()
        {
            InitializeComponent();
            GetAllClasses();
           
        }
        int x = 0;
        public string lbl;
        public int selectedClassId;
        
        public void GetAllClasses()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var getClasses = schoolManagementSystemEntities.classes.ToList();
                if (getClasses.Count() > 0)
                {
                    feeClassId_comboBox.DataSource = getClasses;
                    feeClassId_comboBox.DisplayMember = "name";
                    feeClassId_comboBox.ValueMember = "class_id";
                }
            }
        }
        private void Add_Fee_Load(object sender, EventArgs e)
        {
            lblfee.Text = lbl;
            feeClassId_comboBox.SelectedItem = null;
            feeClassId_comboBox.SelectedText = "--select--";
            if (lblfee.Text == "Add New Fee")
            {
                feeAdd_btn.Text = "Add Fee";
            }
            else if (lblfee.Text == "Update Fee")
            {
                feeAdd_btn.Text = "Update Fee";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x > 0)
            {
                selectedClassId = Convert.ToInt32(feeClassId_comboBox.SelectedValue);
            }
            else
            {
                x = 1;
              
            }
            if (selectedClassId > 0)
            {
                using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
                {
                    var studentListOnClassSelected = schoolManagementSystemEntities.students.Where(x => x.class_id == selectedClassId).ToList();
                    if (studentListOnClassSelected.Count() > 0)
                    {
                        feeStd_comboBox.DataSource = studentListOnClassSelected;
                        feeStd_comboBox.DisplayMember = "name_";
                        feeStd_comboBox.ValueMember = "std_id";
                    }
                }
            }
        }

        private void feePaid_txtbox_TextChanged(object sender, EventArgs e)
        {
            feeRemaining_txtbox.Text = Convert.ToString(Convert.ToInt32(feePaid_txtbox.Text) - Convert.ToInt32(feeSubTotal_txtbox.Text));
        }

        private void feeDiscount_txtbox_TextChanged(object sender, EventArgs e)
        {
            feeSubTotal_txtbox.Text = Convert.ToString(Convert.ToInt32(feeTotal_txtbox.Text) - Convert.ToInt32(feeDiscount_txtbox.Text));
        }
    }
}
